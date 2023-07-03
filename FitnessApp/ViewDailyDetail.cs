﻿using System;
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
      var dateText = DateHelper.GetMonthAndDate(_dailyDetail.Created);
      lblDailyDetailsHeader.Text = $"Summary for {dateText}";
      var workouts = _dailyDetail.Workouts;
      int panelHeight = 0;
      int index = 0;

      if (!workouts.Any())
      {
        LoadMessageForNoWorkouts();
      }
      else
      {
        WorkoutsTab.Controls.Clear();
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
    }

    private void LoadCheatMeals()
    {
      var dateText = DateHelper.GetMonthAndDate(_dailyDetail.Created);
      lblDailyDetailsHeader.Text = $"Summary for {dateText}";
      var cheatMeals = _dailyDetail.CheatMeals;

      if (!cheatMeals.Any())
      {
        LoadMessageForNoCheatMeals();
      }
      else
      {
        CheatMealTab.Controls.Clear();
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

    private void LoadMessageForNoWorkouts()
    {
      Label messageLabel = new Label();
      messageLabel.Text = "No workouts";
      messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, 
                            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 
                            ((byte)(0)));
      messageLabel.ForeColor = SystemColors.ActiveBorder;

      int tabWidth = WorkoutsTab.Width;
      int labelX = (tabWidth - messageLabel.Width) / 2;
      messageLabel.Location = new Point(labelX, 15);
      WorkoutsTab.Controls.Add(messageLabel);
    }

    private void LoadMessageForNoCheatMeals()
    {
      Label messageLabel = new Label();
      messageLabel.Text = "No cheat meals";
      messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, 
                            System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 
                            ((byte)(0)));
      messageLabel.ForeColor = SystemColors.ActiveBorder;

      int tabWidth = CheatMealTab.Width;
      int labelX = (tabWidth - messageLabel.Width) / 2;
      messageLabel.Location = new Point(labelX, 15);
      messageLabel.Width = 140;
      CheatMealTab.Controls.Add(messageLabel);
    }
  }
}
