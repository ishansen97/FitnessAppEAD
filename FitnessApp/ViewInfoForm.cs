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
using FitnessApp.Helpers;

namespace FitnessApp
{
  public partial class ViewInfoForm : Form
  {
    private WorkoutService _workoutService;
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
      if (_isWorkout)
      {
        // get the workouts.
        var userWorkouts = _workoutService.GetWorkouts();
        if (!userWorkouts.Any())
        {
          // display message.
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
      }
      /*var customPanel = new DetailPanel(string.Empty, pnlMain.Size, pnlSelections.Height, _isWorkout);
      pnlMain.Controls.Add(customPanel);*/
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
  }
}
