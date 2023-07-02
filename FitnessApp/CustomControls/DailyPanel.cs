using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessApp.Helpers;
using FitnessApp.Models;

namespace FitnessApp.CustomControls
{
  public partial class DailyPanel : UserControl
  {
    private DailyDetail _dailyDetail;

    public DailyPanel()
    {
      InitializeComponent();
    }

    public DailyPanel(DailyDetail dailyDetail)
    {
      InitializeComponent();
      _dailyDetail = dailyDetail;
      InitializeViewMoreButtonState();
      LoadDetail();
    }

    private void InitializeViewMoreButtonState()
    {
      if (!IsContentAvailable())
      {
        btnViewMore.Visible = false;
      }
    }

    private void LoadDetail()
    {
      lblDate.Text = DateHelper.GetMonthAndDate(_dailyDetail.Created);

      if (!IsContentAvailable())
      {
        lblDailyPanelMessage.Text = "No workouts/cheatmeals";
      }
      else
      {
        // display the message
        int workoutCount = _dailyDetail.Workouts.Count;
        int cheatMealCount = _dailyDetail.CheatMeals.Count;
        lblDailyPanelMessage.Text = $"{workoutCount} Workouts/{cheatMealCount} CheatMeals";
      }
    }

    private void btnViewMore_Click(object sender, EventArgs e)
    {
      ViewDailyDetail dailyDetailForm = new ViewDailyDetail(_dailyDetail);
      dailyDetailForm.Activate();
      dailyDetailForm.ShowDialog();
    }

    private bool IsContentAvailable()
    {
      var workouts = _dailyDetail.Workouts;
      var cheatMeals = _dailyDetail.CheatMeals;
      return (workouts.Any() || cheatMeals.Any());
    }
  }
}
