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
          var profile = UserContext.CurrentProfile;
          var user = profile.User;
          txtFirstName.Text = user.FirstName;
          txtLastName.Text = user.LastName;
          txtUserName.Text = profile.UserName;
          txtAge.Text = user.Age.ToString(CultureInfo.InvariantCulture);
          txtHeight.Text = user.Height.ToString(CultureInfo.InvariantCulture);
          txtWeight.Text = user.Weight.ToString(CultureInfo.InvariantCulture);
          _isProfileLoaded = true;
        }
      }
      else if (e.TabPage == WeeklyView)
      {
        lblWeek.Text = DateHelper.CreateWeekText(DateTime.Today);
        lblWeek.Tag = DateTime.Today;
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

        // display predicted weight
        lblPredictedWeightValue.Text = $"{prediction.PredictedWeight.ToString(CultureInfo.InvariantCulture)} kg";

        // display prediction status.
        lblPredictedStatusValue.Text = prediction.State.ToString();
        lblPredictedStatusValue.ForeColor = EnumHelper.GetTextColorForPredictionStatus(prediction.State);

        // display prediction message.
        lblPredictionMessageValue.Text = prediction.Message;
        lblPredictionMessageValue.ForeColor = EnumHelper.GetTextColorForPredictionStatus(prediction.State);
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
  }
}
