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
  public partial class DailyCheatMealSummary : UserControl
  {
    private CheatMeal _cheatMeal;

    public DailyCheatMealSummary()
    {
      InitializeComponent();
    }

    public DailyCheatMealSummary(CheatMeal cheatMeal)
    {
      InitializeComponent();
      _cheatMeal = cheatMeal;
      LoadCheatMeal();
    }

    private void LoadCheatMeal()
    {
      // load exercise type.
      lblMealTypeValue.Text = _cheatMeal.MealType.ToString();
      lblAmountValue.Text = $"{_cheatMeal.MealAmount} g";
    }
  }
}
