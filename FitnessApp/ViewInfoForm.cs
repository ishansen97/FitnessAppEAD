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
using FitnessApp.CustomControls;
using FitnessApp.Extensions;
using FitnessApp.Helpers;

namespace FitnessApp
{
  public partial class ViewInfoForm : Form
  {
    private WorkoutService _workoutService;
    private CheatMealService _cheatMealService;
    private bool _isWorkout;
    public delegate void OnCloseEvent(int num);

    public ViewInfoForm()
    {
      InitializeComponent();
    }

    public ViewInfoForm(bool isWorkout)
    {
      InitializeComponent();
      _isWorkout = isWorkout;
      _workoutService = new WorkoutService();
      _cheatMealService = new CheatMealService();
      SetCheckBoxStatus();
      LoadDetailPanels();
    }

    private void SetCheckBoxStatus()
    {
      rdbWorkouts.Checked = _isWorkout;
      rdbCheatMeals.Checked = !_isWorkout;
    }

    private void LoadDetailPanels()
    {
      //pnlMain.Controls.Clear();
      //pnlMain.Controls.RemoveControls(new Control[] {pnlSelections}, false);
      if (_isWorkout)
      {
        // get the workouts.
        var userWorkouts = _workoutService.GetWorkouts();
        if (!userWorkouts.Any())
        {
          // display message.
          lblNoContentMessage.Text = "No workouts were found.";
          lblNoContentMessage.Visible = true;
        }
        else
        {
          Size panelSize = pnlMain.Size;
          int margin = pnlSelections.Height;
          int index = 1;
          foreach (var userWorkout in userWorkouts)
          {
            var detailHelper = new DetailHelper(userWorkout);
            var detailPanel = new DetailPanel(index, detailHelper, panelSize, margin, _isWorkout);
            detailPanel.CloseMainForm += DetailPanelOnCloseMainForm;
            pnlMain.Controls.Add(detailPanel);
            index++;
          }
        }
      }
      else
      {
        // get the cheat meals.
        var cheatMeals = _cheatMealService.GetCheatMeals();
        if (!cheatMeals.Any())
        {
          lblNoContentMessage.Text = "No cheat meals were found.";
          lblNoContentMessage.Visible = true;
        }
        else
        {
          Size panelSize = pnlMain.Size;
          int margin = pnlSelections.Height;
          int index = 1;
          foreach (var cheatMeal in cheatMeals)
          {
            var detailHelper = new DetailHelper(cheatMeal);
            var detailPanel = new DetailPanel(index, detailHelper, panelSize, margin, _isWorkout);
            detailPanel.CloseMainForm += DetailPanelOnCloseMainForm;
            pnlMain.Controls.Add(detailPanel);
            index++;
          }
        }
      }
    }

    private void DetailPanelOnCloseMainForm(object sender, EventArgs e)
    {
      Hide();
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
      var dashboard = new Dashboard();
      Hide();
      dashboard.Activate();
      dashboard.ShowDialog();
    }

    private void LoadNewViewForm()
    {
      ViewInfoForm form = new ViewInfoForm(_isWorkout);
      Hide();
      form.Activate();
      form.ShowDialog();
    }

    #region Radio button checked changes
    private void rdbWorkout_Clicked(object sender, MouseEventArgs e)
    {
      RadioButton rdb = sender as RadioButton;
      _isWorkout = rdb.Checked;
      //LoadDetailPanels();
      LoadNewViewForm();
    }

    private void rdbCheatMeals_Clicked(object sender, MouseEventArgs e)
    {
      RadioButton rdb = sender as RadioButton;
      _isWorkout = !rdb.Checked;
      //LoadDetailPanels();
      LoadNewViewForm();
    }
    #endregion
  }
}
