using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessApp.Business.Handlers;
using FitnessApp.Context;
using FitnessApp.CustomControls;
using FitnessApp.Helpers;
using FitnessApp.Models;
using DateTime = System.DateTime;

namespace FitnessApp
{
  public partial class EditWorkout : Form
  {
    private WorkoutService _workoutService;
    private Workout _workout;
    private Dictionary<string, double> _workoutFields;

    public EditWorkout()
    {
      InitializeComponent();
    }

    public EditWorkout(Workout workout)
    {
      InitializeComponent();
      _workoutService = new WorkoutService();
      _workout = workout;
      _workoutFields = new Dictionary<string, double>();
      dtWorkoutDate.MaxDate = DateTime.Today;
      LoadDetails();
    }

    private void LoadDetails()
    {
      lblWorkoutTypeValue.Text = _workout.Exercise.ToString();
      LoadWorkoutFields();
      PositionDateField();
      dtWorkoutDate.Value = _workout.Created;
    }

    private void LoadWorkoutFields()
    {
      var detailHelper = new DetailHelper(_workout);
      // load workout fields.
      int panelHeight = 0;
      int index = 0;
      foreach (var field in _workout.Fields)
      {
        var formattedValue = detailHelper.GetFieldValueForText(field.Key, field.Value);
        var fieldPanel = new EditableContentFields(field.Key, formattedValue);
        if (index == 0)
        {
          panelHeight = 0;
        }
        else
        {
          panelHeight += fieldPanel.Height;
        }

        fieldPanel.Location = new Point(0, panelHeight);
        pnlFields.Controls.Add(fieldPanel);
        index++;
      }
    }

    private void PositionDateField()
    {
      int fieldY = pnlFields.Location.Y + pnlFields.Size.Height + 10;
      lblWorkoutDate.Location = new Point(lblWorkoutDate.Location.X, fieldY);
      dtWorkoutDate.Location = new Point(lblWorkoutTypeValue.Location.X, fieldY);
    }

    private bool ValidateWorkoutFields()
    {
      var contorls = pnlFields.Controls;
      foreach (var fields in _workout.Fields)
      {
        var actualFieldsControls = contorls.Find(fields.Key, true);
        var textControl = actualFieldsControls.FirstOrDefault(ct => ct.GetType() == typeof(TextBox));

        if (textControl is TextBox txtBox)
        {
          if (!WorkoutFieldsHelper.ValidateTextField(txtBox, fields.Key))
          {
            EditWorkoutErrorHandler.SetError(txtBox, "Input format is not correct.");
            return false;
          }
          _workoutFields.Add(fields.Key, double.Parse(txtBox.Text));
        }
        else
        {
          MessageBox.Show("Something wrong with the fields.", "Error");
          return false;
        }
      }

      return true;
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (ValidateWorkoutFields())
      {
        _workout.Fields = _workoutFields;
        _workout.Created = dtWorkoutDate.Value;
        _workoutService.EditWorkout(_workout.Id, _workout);
        var dialogResult = MessageBox.Show("The workout updated successfully.", "Success!");
        if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Cancel)
        {
          Hide();
        }
      }
    }
  }
}
