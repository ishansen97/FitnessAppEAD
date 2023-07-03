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
  public partial class DailyWorkoutSummary : UserControl
  {
    private Workout _workout;

    public DailyWorkoutSummary()
    {
      InitializeComponent();
    }

    public DailyWorkoutSummary(Workout workout)
    {
      InitializeComponent();
      _workout = workout;
      LoadWorkout();
    }

    private void LoadWorkout()
    {
      // load exercise type.
      lblExerciseType.Text = _workout.Exercise.ToString();
      var detailHelper = new DetailHelper(_workout);
      // load workout fields.
      int panelHeight = 0;
      int index = 0;
      foreach (var field in _workout.Fields)
      {
        var formattedValue = detailHelper.GetFieldValueForText(field.Key, field.Value);
        var fieldPanel = new ContentFields(field.Key, formattedValue, lblExerciseType.ForeColor);
        if (index == 0)
        {
          panelHeight = 0;
        }
        else
        {
          panelHeight += fieldPanel.Height;
        }

        fieldPanel.Location = new Point(0, panelHeight);
        pnlWorkoutFields.Controls.Add(fieldPanel);
        index++;
      }
    }
  }
}
