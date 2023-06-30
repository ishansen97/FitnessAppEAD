using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessApp.Models;
using FitnessApp.Models.Abstractions;

namespace FitnessApp.Helpers
{
  public class DetailHelper
  {
    private Detail _detail;

    public Detail Detail
    {
      get
      {
        return _detail;
      }
    }

    public DetailHelper(Detail detail)
    {
      _detail = detail;
    }

    public string GetHeader()
    {
      string header = string.Empty;
      if (_detail.GetType() == typeof(Workout))
      {
        var workout = (Workout)_detail;
        header = workout.Exercise.ToString();
      }
      else if (_detail.GetType() == typeof(CheatMeal))
      {
        var cheatMeal = (CheatMeal)_detail;
        header = cheatMeal.MealType.ToString();
      }

      return header;
    }

    public Panel GetFields()
    {
      Panel panel = new Panel();
      panel.Location = new Point(15, 25);
      panel.BackColor = Color.Blue;
      panel.Size = new Size(100, 40);
      if (_detail.GetType() == typeof(Workout))
      {
        CreateWorkoutFields(panel);
      }
      else if (_detail.GetType() == typeof(CheatMeal))
      {
        CreateCheatMealFields(panel);
      }

      return panel;
    }

    private void CreateCheatMealFields(Panel panel)
    {
      CheatMeal cheatMeal = (CheatMeal)_detail;
      // key label
      CreateFieldValues(panel, 0, "Amount", cheatMeal.Gram);
    }

    private void CreateWorkoutFields(Panel panel)
    {
      Workout workout = (Workout)_detail;
      int index = 0;
      foreach (var fieldsKey in workout.Fields.Keys)
      {
        var keyPair = workout.Fields[fieldsKey];
        CreateFieldValues(panel, index, fieldsKey, workout.Fields[fieldsKey]);
        index++;
      }
    }

    private void CreateFieldValues(Panel panel, int margin, string key, double value)
    {
      int y = 5 * margin;
      Label keyLabel = new Label();
      keyLabel.Text = key;
      keyLabel.Location = new Point(5, y);
      keyLabel.Font = new Font("Arial", 10.0F, System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      keyLabel.ForeColor = Color.Red;

      Label valueLabel = new Label();
      valueLabel.Text = value.ToString(CultureInfo.InvariantCulture);
      valueLabel.Location = new Point(10, y);
      valueLabel.Font = new Font("Arial", 10.0F, System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      valueLabel.ForeColor = Color.Red;

      panel.Controls.Add(keyLabel);
      panel.Controls.Add(valueLabel);
    }
  }
}
