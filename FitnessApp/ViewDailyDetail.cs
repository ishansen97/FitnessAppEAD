using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessApp.CustomControls;
using FitnessApp.Helpers;
using FitnessApp.Models;

namespace FitnessApp
{
  public partial class ViewDailyDetail : Form
  {
    private DailyDetail _dailyDetail;

    public ViewDailyDetail()
    {
      InitializeComponent();
    }

    public ViewDailyDetail(DailyDetail dailyDetail)
    {
      InitializeComponent();
      _dailyDetail = dailyDetail;
      LoadWorkouts();
    }

    private void LoadWorkouts()
    {
      lblDailyDetailsHeader.Text = DateHelper.GetMonthAndDate(_dailyDetail.Created);
      var workouts = _dailyDetail.Workouts;
      int panelHeight = 0;
      int index = 0;
      foreach (var workout in workouts)
      {
        var workoutPanel = new DailyWorkoutSummary(workout);
        if (index == 0)
        {
          panelHeight = 0;
        }
        else
        {
          panelHeight += workoutPanel.Height;
        }

        workoutPanel.Location = new Point(0, panelHeight);
        WorkoutsTab.Controls.Add(workoutPanel);
        index++;
      }
    }

    private void LoadCheatMeals()
    {
      lblDailyDetailsHeader.Text = DateHelper.GetMonthAndDate(_dailyDetail.Created);
      var cheatMeals = _dailyDetail.CheatMeals;
      int panelHeight = 0;
      int index = 0;
      foreach (var cheatMeal in cheatMeals)
      {
        var cheatMealPanel = new DailyCheatMealSummary(cheatMeal);
        if (index == 0)
        {
          panelHeight = 0;
        }
        else
        {
          panelHeight += cheatMealPanel.Height;
        }

        cheatMealPanel.Location = new Point(0, panelHeight);
        CheatMealTab.Controls.Add(cheatMealPanel);
        index++;
      }
    }

    private void OnTab_Selected(object sender, TabControlEventArgs e)
    {
      if (e.TabPage == WorkoutsTab)
      {
        LoadWorkouts();
      }
      else if (e.TabPage == CheatMealTab)
      {
        LoadCheatMeals();
      }
    }
  }
}
