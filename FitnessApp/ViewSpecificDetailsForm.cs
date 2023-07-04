using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessApp.Business.Handlers;
using FitnessApp.Helpers;
using FitnessApp.Models;
using FitnessApp.Models.Abstractions;

namespace FitnessApp
{
  public partial class ViewSpecificDetailsForm : Form
  {
    private WorkoutService _workoutService;
    private CheatMealService _cheatMealService;
    private Detail _detail;
    private int _contentId;
    private bool _isWorkout;

    public ViewSpecificDetailsForm()
    {
      InitializeComponent();
    }

    public ViewSpecificDetailsForm(int contentId, bool isWorkout)
    {
      InitializeComponent();
      _contentId = contentId;
      _isWorkout = isWorkout;
      _workoutService = new WorkoutService();
      _cheatMealService = new CheatMealService();
      LoadFormDetails();
    }

    private void LoadFormDetails()
    {
      InitializeHeaderLabel();
      InitializeActivityTypeLabel();
      LoadDetail();
      LoadCalorieDetails();
    }

    private void InitializeHeaderLabel()
    {
      string newText = lblViewDetailsHeader.Text.Replace("<Type>", _isWorkout ? "Workout" : "Cheat Meal");
      lblViewDetailsHeader.Text = newText;
    }
    private void InitializeActivityTypeLabel()
    {
      if (_isWorkout)
      {
        lblActivityType.Text = "Workout Type";
        lblViewDetailsHeader.ForeColor = Color.Green;
      }
      else
      {
        lblActivityType.Text = "Cheat Meal";
        lblViewDetailsHeader.ForeColor = Color.Red;
      }
    }

    private void LoadDetail()
    {
      if (_isWorkout)
      {
        _detail = _workoutService.GetWorkoutById(_contentId);
      }
      else
      {
        _detail = _cheatMealService.GetCheatMealById(_contentId);
      }

      var detailHelper = new DetailHelper(_detail, pnlFields.Size);
      lblActivity.Text = detailHelper.GetHeader();
      lblDateInfo.Text = _detail.Created.ToString("yyyy MMMM dd");

      // load fields to the panel.
      pnlFields.Controls.Add(detailHelper.GetFields());
    }

    private void LoadCalorieDetails()
    {
      double calorieValue = 0;
      if (_isWorkout)
      {
        calorieValue = _workoutService.GetCalorieExpenditureForExercise((Workout)_detail);
        lblCalorieValue.ForeColor = Color.Green;
        lblCalories.Text = "Calories Spent";
      }
      else
      {
        calorieValue = _cheatMealService.GetCalorieIntakeForCheatMeal((CheatMeal)_detail);
        lblCalorieValue.ForeColor = Color.Red;
        lblCalories.Text = "Calorie Intake";
      }
      lblCalorieValue.Text = $"{calorieValue} cal".ToString(CultureInfo.InvariantCulture);
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      ViewInfoForm infoForm = new ViewInfoForm(_isWorkout);
      Hide();
      infoForm.Activate();
      infoForm.ShowDialog();
    }
  }
}
