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
using FitnessApp.Context;
using FitnessApp.CustomControls;
using FitnessApp.Extensions;
using FitnessApp.Helpers;
using FitnessApp.Models;

namespace FitnessApp
{
  public partial class Dashboard : Form
  {
    private bool _isProfileLoaded;
    private UserProfile _userProfile;
    private WorkoutService _workoutService;
    private CheatMealService _cheatMealService;
    private PredictionService _predictionService;
    private WeeklyViewService _weeklyViewService;

    public Dashboard()
    {
      InitializeComponent();
      //string newHeader = 
      ChangeHeader();
      InitializeServices();
      InitializeControlDate();
    }

    private void InitializeControlDate()
    {
      lnkWorkoutDaysCount.Text = $"{_workoutService.GetWorkouts().Count}";
      lnkCheatMealDays.Text = $"{_cheatMealService.GetCheatMeals().Count}";
      dtPredictionDate.MinDate = DateTime.Today;
    }

    private void InitializeServices()
    {
      _workoutService = new WorkoutService();
      _cheatMealService = new CheatMealService();
      _predictionService = new PredictionService();
      _weeklyViewService = new WeeklyViewService();
    }

    private void ChangeHeader()
    {
      string newText = Text.Replace("<user>", UserContext.CurrentProfile.UserName);
      Text = newText;
    }

    private void OnTabChanged(object sender, TabControlEventArgs e)
    {
      var index = e.TabPageIndex;
      if (e.TabPage == ProfileTab)
      {
        if (!_isProfileLoaded)
        {
          _userProfile = UserContext.CurrentProfile;
          var user = _userProfile.User;
          txtFirstName.Text = user.FirstName;
          txtLastName.Text = user.LastName;
          txtUserName.Text = _userProfile.UserName;
          txtAge.Text = user.Age.ToString(CultureInfo.InvariantCulture);
          txtHeight.Text = user.Height.ToString(CultureInfo.InvariantCulture);
          txtWeight.Text = user.Weight.ToString(CultureInfo.InvariantCulture);
          _isProfileLoaded = true;

          // username is read-only (application specific)
          txtUserName.ReadOnly = true;
        }
      }
      else if (e.TabPage == WeeklyView)
      {
        lblWeek.Text = DateHelper.CreateWeekText(DateTime.Today);
        lblWeek.Tag = DateTime.Today;
        LoadWeeklyDetails(DateTime.Today);
      }
    }

    private void lnkAddWorkout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      WorkoutForm workoutForm = new WorkoutForm();
      Hide();
      workoutForm.Activate();
      workoutForm.ShowDialog();
    }

    private void lnkWorkoutDaysCount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      ViewInfoForm viewForm = new ViewInfoForm(true);
      Hide();
      viewForm.Activate();
      viewForm.ShowDialog();
    }

    private void lnkAddCheatMeal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      CheatMealForm cheatMealForm = new CheatMealForm();
      Hide();
      cheatMealForm.Activate();
      cheatMealForm.ShowDialog();
    }

    private void lnkCheatMealDays_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      ViewInfoForm viewForm = new ViewInfoForm(false);
      Hide();
      viewForm.Activate();
      viewForm.ShowDialog();
    }

    private void btnPredict_Click(object sender, EventArgs e)
    {
      if (_predictionService.EligibleToMakePredictions())
      {
        var predictionDate = dtPredictionDate.Value;
        var prediction = _predictionService.MakePrediction(predictionDate);
        lblPredictionViewLabel.Text = $"Your Prediction for {predictionDate.ToString("yyyy MMMM dd")}";
        lblPredictionViewLabel.ForeColor = Color.Blue;
        lblPredictionViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, 
                                            System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        // display current weight
        lblCurrentWeightValue.Text = prediction.CurrentWeight.ToString(CultureInfo.InvariantCulture);

        // display predicted weight
        lblPredictedWeightValue.Text = $"{prediction.PredictedWeight.ToString(CultureInfo.InvariantCulture)} kg";

        // display prediction status.
        lblPredictedStatusValue.Text = prediction.State.ToString();
        lblPredictedStatusValue.ForeColor = EnumHelper.GetTextColorForPredictionStatus(prediction.State);

        // display prediction message.
        lblPredictionMessageValue.Text = prediction.Message;
        lblPredictionMessageValue.ForeColor = EnumHelper.GetTextColorForPredictionStatus(prediction.State);

        // display predicted weight status
        lblPredictedWeightStatus.Text = prediction.WeightStatus.ToString();
        lblPredictedWeightStatus.ForeColor = EnumHelper.GetPredictedWeightTextColor(prediction.WeightStatus);

        pnlPredictionDetails.Visible = true;
        lblPredictionViewLabel.Visible = false;
      }
      else
      {
        lblPredictionViewLabel.Text = "Please add atleast 3 workouts/cheat meals";
        lblPredictionViewLabel.ForeColor = Color.Red;
        lblPredictionViewLabel.Visible = true;
        pnlPredictionDetails.Visible = false;
      }
    }

    private void pbLeftArrow_Click(object sender, EventArgs e)
    {
      if (!pbRightArrow.Visible)
      {
        pbRightArrow.Visible = true;
      }
      else
      {
        var lblDate = (DateTime)lblWeek.Tag;
        var prevWeekDay = lblDate.AddDays(-7);
        lblWeek.Text = DateHelper.CreateWeekText(prevWeekDay);
        lblWeek.Tag = prevWeekDay;
        LoadWeeklyDetails(prevWeekDay);
      }
    }

    private void pbRightArrow_Click(object sender, EventArgs e)
    {
      var lblDate = (DateTime)lblWeek.Tag;
      var nextWeekDay = lblDate.AddDays(7);
      if (nextWeekDay > DateTime.Today)
      {
        pbRightArrow.Visible = false;
      }
      else
      {
        lblWeek.Text = DateHelper.CreateWeekText(nextWeekDay);
        lblWeek.Tag = nextWeekDay;
        LoadWeeklyDetails(nextWeekDay);
      }
    }

    private bool IsWeeklyDetailsAvailable(DateTime date)
    {
      return _weeklyViewService.WeeklyDetailsAvailable(date);
    }

    private void LoadWeeklyDetails(DateTime date)
    {
      pnlDailyPanelLists.Controls.Clear();
      if (!IsWeeklyDetailsAvailable(date))
      {
        lblWeeklyContentHeader.Visible = true;
      }
      else
      {
        lblWeeklyContentHeader.Visible = false;
        var weeklyDetails = _weeklyViewService.GetWeeklyDetails(date);
        AddWeeklyViewPanel(weeklyDetails);
      }
    }

    private void AddWeeklyViewPanel(List<DailyDetail> data)
    {
      int panelHeight = 0;
      int index = 0;
      foreach (var dailyDetail in data)
      {
        var dailyPanel = new DailyPanel(dailyDetail);
        if (index == 0)
        {
          panelHeight = 0;
        }
        else
        {
          panelHeight += dailyPanel.Height;
        }
        dailyPanel.Location = new Point(0, panelHeight);
        pnlDailyPanelLists.Controls.Add(dailyPanel);
        index++;
      }
    }

    // for editing the profile.
    private void btnSave_Click(object sender, EventArgs e)
    {
      if (ValidateChildren(ValidationConstraints.Enabled))
      {
        _userProfile.User.FirstName = txtFirstName.Text;
        _userProfile.User.LastName = txtLastName.Text;
        _userProfile.User.Age = int.Parse(txtAge.Text);
        _userProfile.User.Height = int.Parse(txtHeight.Text); 
        _userProfile.User.Weight = double.Parse(txtWeight.Text);
        
        // TODO: add the service part for user in CW2.
        MessageBox.Show("User updated successfully.", "Success!");
      }
    }

    private void txtField_Validating(object sender, CancelEventArgs e)
    {
      TextBox txtBox = sender as TextBox;
      if (string.IsNullOrWhiteSpace(txtBox.Text))
      {
        e.Cancel = true;
        txtBox.Focus();
        ProfileErrorHandler.SetError(txtBox, "Value must not be empty.");
      }
      else
      {
        e.Cancel = false;
        ProfileErrorHandler.SetError(txtBox, string.Empty);
      }
    }

    private void numberField_Validating(object sender, CancelEventArgs e)
    {
      TextBox txtBox = sender as TextBox;
      if (string.IsNullOrWhiteSpace(txtBox.Text))
      {
        e.Cancel = true;
        txtBox.Focus();
        ProfileErrorHandler.SetError(txtBox, "Value must not be empty.");
      }
      else if (!int.TryParse(txtBox.Text, out var value))
      {
        e.Cancel = true;
        txtBox.Focus();
        ProfileErrorHandler.SetError(txtBox, "Value must be a number.");
      }
      else if (value < 0)
      {
        e.Cancel = true;
        txtBox.Focus();
        ProfileErrorHandler.SetError(txtBox, "Value must be a positive number.");
      }
      else
      {
        e.Cancel = false;
        ProfileErrorHandler.SetError(txtBox, string.Empty);
      }
    }

    private void doubleField_Validating(object sender, CancelEventArgs e)
    {
      TextBox txtBox = sender as TextBox;
      if (string.IsNullOrWhiteSpace(txtBox.Text))
      {
        e.Cancel = true;
        txtBox.Focus();
        ProfileErrorHandler.SetError(txtBox, "Value must not be empty.");
      }
      else if (!double.TryParse(txtBox.Text, out var value))
      {
        e.Cancel = true;
        txtBox.Focus();
        ProfileErrorHandler.SetError(txtBox, "Value must be a number.");
      }
      else if (value < 0)
      {
        e.Cancel = true;
        txtBox.Focus();
        ProfileErrorHandler.SetError(txtBox, "Value must be a positive number.");
      }
      else
      {
        e.Cancel = false;
        ProfileErrorHandler.SetError(txtBox, string.Empty);
      }
    }
  }
}
