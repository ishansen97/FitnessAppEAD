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
using FitnessApp.Helpers;
using FitnessApp.Models;

namespace FitnessApp.CustomControls
{
  public partial class DailyCheatMealSummary : UserControl
  {
    private CheatMeal _cheatMeal;
    private CheatMealService _cheatMealService;

    public DailyCheatMealSummary()
    {
      InitializeComponent();
    }

    public DailyCheatMealSummary(CheatMeal cheatMeal)
    {
      InitializeComponent();
      _cheatMeal = cheatMeal;
      _cheatMealService = new CheatMealService();
      LoadCheatMeal();
      LoadCalorieDetails();
    }

    private void LoadCheatMeal()
    {
      // load exercise type.
      lblMealTypeValue.Text = _cheatMeal.MealType.ToString();
      lblAmountValue.Text = $"{_cheatMeal.MealAmount} g";
    }

    private void LoadCalorieDetails()
    {
      var calorieValue = _cheatMealService.GetCalorieIntakeForCheatMeal(_cheatMeal);
      lblCalorieValue.Text = $"{calorieValue} cal".ToString(CultureInfo.InvariantCulture);
    }
  }
}
