using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessApp.Business.Handlers;
using FitnessApp.Context;
using FitnessApp.Extensions;
using FitnessApp.Helpers;
using FitnessApp.Models;
using FitnessApp.Models.Enums;

namespace FitnessApp
{
  public partial class WorkoutForm : Form
  {
    private WorkoutService _workoutService;

    public WorkoutForm()
    {
      InitializeComponent();
      LoadWorkoutTypes();
      _workoutService = new WorkoutService();
      dtWorkoutPicker.MaxDate = DateTime.Today;
    }

    private void LoadWorkoutTypes()
    {
      cmbWorkoutTypes.Items.Add(string.Empty);
      cmbWorkoutTypes.Items.AddRange(EnumHelper.LoadItems<ExerciseType>());
    }

    private void OnSelectedWorkoutType_Changed(object sender, EventArgs e)
    {
      var item = cmbWorkoutTypes.SelectedItem;
      if (!string.IsNullOrEmpty(item.ToString()))
      {
        ExerciseType exercise = (ExerciseType)item;
        pnlWorkoutControls.Controls.Clear();
        pnlWorkoutControls.Controls.AddRange(FormControlHelper.GetExerciseTypeControls(exercise));
        // resize the panel (extension method)
        pnlWorkoutControls.ResizePanel(5);
        pnlWorkoutControls.Show();

        // bring the date panel closer to workout panel (extension method).
        pnlWorkoutDate.BringCloserTo(pnlWorkoutControls, 10);
        pnlWorkoutDate.Show();
      }
      else
      {
        pnlWorkoutControls.Controls.Clear();
        pnlWorkoutControls.Hide();
        pnlWorkoutDate.Hide();
      }
    }

    private void btnAddWorkout_Click(object sender, EventArgs e)
    {
      if (ValidateChildren(ValidationConstraints.Enabled) && ValidateAdditionalFields())
      {
        CreateWorkout();
        LoadDashboard();
      }
    }

    private void CreateWorkout()
    {
      ExerciseType exercise = (ExerciseType)cmbWorkoutTypes.SelectedItem;
      DateTime workoutDate = dtWorkoutPicker.Value;
      Workout workout = new Workout
      {
        Exercise = exercise,
        User = UserContext.CurrentProfile.User,
        Created = workoutDate
      };

      GetAdditionalFieldData(workout);
      _workoutService.CreateWorkout(workout);
    }

    private void GetAdditionalFieldData(Workout workout)
    {
      var fields = new Dictionary<string, double>();
      switch (workout.Exercise)
      {
        case ExerciseType.Walking:
        case ExerciseType.Running:
        case ExerciseType.Cycling:
          CreateDistanceFields(fields);
          break;
        case ExerciseType.Plank:
          CreateTimeFields(fields);
          break;
        case ExerciseType.BenchPress:
        case ExerciseType.BicepCurls:
        case ExerciseType.DeadLifts:
        case ExerciseType.LegPress:
          CreateCompositeControls(fields);
          break;
        case ExerciseType.Pushups:
        case ExerciseType.Pullups:
        case ExerciseType.Crunches:
        case ExerciseType.Squats:
          CreateRepControls(fields);
          break;
      }
      workout.Fields = fields;
    }

    #region Creating Fields
    private void CreateDistanceFields(Dictionary<string, double> fields)
    {
      var controls = pnlWorkoutControls.Controls.Find("txtDistance", false).First();
      if (controls is TextBox txtBox)
      {
        fields.Add("Distance", double.Parse(txtBox.Text));
      }
    }

    private void CreateTimeFields(Dictionary<string, double> fields)
    {
      var controls = pnlWorkoutControls.Controls.Find("txtTime", false).First();
      if (controls is TextBox txtBox)
      {
        fields.Add("Time", double.Parse(txtBox.Text));
      }
    }
    private void CreateCompositeControls(Dictionary<string, double> fields)
    {
      var weightControl = pnlWorkoutControls.Controls.Find("txtWeight", false).First();
      if (weightControl is TextBox txtBox)
      {
        fields.Add("Weight", double.Parse(txtBox.Text));
      }

      CreateRepControls(fields);
    }
    private void CreateRepControls(Dictionary<string, double> fields)
    {
      var repsControl = pnlWorkoutControls.Controls.Find("txtReps", false).First();
      if (repsControl is TextBox txtBox)
      {
        fields.Add("Reps", double.Parse(txtBox.Text));
      }
    }
    #endregion

    #region Workout TextBox Validation
    private bool ValidateAdditionalFields()
    {
      foreach (Control control in pnlWorkoutControls.Controls)
      {
        if (control.GetType() == typeof(TextBox))
        {
          TextBox txtBox = control as TextBox;
          int number;
          if (string.IsNullOrWhiteSpace(txtBox.Text))
          {
            WorkoutErrorHandler.SetError(txtBox, $"{txtBox.Tag} must not contain empty.");
            return false;
          }
          if (!int.TryParse(txtBox.Text, out number))
          {
            WorkoutErrorHandler.SetError(txtBox, $"{txtBox.Tag} must contain a number.");
            return false;
          }
          if (number < 0)
          {
            WorkoutErrorHandler.SetError(txtBox, $"{txtBox.Tag} must be a positive number.");
            return false;
          }
          else
          {
            WorkoutErrorHandler.SetError(txtBox, string.Empty);
          }
        }
      }

      return true;
    }

    private void WorkoutText_Validate(object sender, CancelEventArgs e)
    {
      TextBox txtBox = sender as TextBox;
      int number;
      if (string.IsNullOrWhiteSpace(txtBox.Text))
      {
        e.Cancel = true;
        //txtBox.Focus();
        WorkoutErrorHandler.SetError(txtBox, $"{txtBox.Tag} must not contain empty.");
      }
      else if (!int.TryParse(txtBox.Text, out number))
      {
        e.Cancel = true;
        //txtBox.Focus();
        WorkoutErrorHandler.SetError(txtBox, $"{txtBox.Tag} must contain a number.");
      }
      else if (number < 0)
      {
        e.Cancel = true;
        //txtBox.Focus();
        WorkoutErrorHandler.SetError(txtBox, $"{txtBox.Tag} must be a positive number.");
      }
      else
      {
        e.Cancel = false;
        WorkoutErrorHandler.SetError(txtBox, string.Empty);
      }
    }
    #endregion

    private void WorkoutTypes_Validated(object sender, CancelEventArgs e)
    {
      var item = cmbWorkoutTypes.SelectedItem;
      if (string.IsNullOrEmpty(item.ToString()))
      {
        e.Cancel = true;
        WorkoutErrorHandler.SetError(cmbWorkoutTypes, "Please select a workout type.");
      }
      else
      {
        e.Cancel = false;
        WorkoutErrorHandler.SetError(cmbWorkoutTypes, string.Empty);
      }
    }

    private void LoadDashboard()
    {
      Dashboard dashboard = new Dashboard();
      Hide();
      dashboard.Activate();
      dashboard.ShowDialog();
    }
  }
}
