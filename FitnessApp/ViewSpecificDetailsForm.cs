using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessApp.Business.Handlers;
using FitnessApp.Helpers;
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
      }
      else
      {
        lblActivityType.Text = "Cheat Meal";
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

      var detailHelper = new DetailHelper(_detail, pnlFieldsPanel.Size);
      lblActivity.Text = detailHelper.GetHeader();
      lblDateInfo.Text = _detail.Created.ToString("yyyy MMMM dd");

      // load fields to the panel.
      pnlFieldsPanel.Controls.Add(detailHelper.GetFields());
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
