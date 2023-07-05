using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Business.Logic.Calorie;
using FitnessApp.Context;
using FitnessApp.Models;

namespace FitnessApp.Business.Handlers
{
  public class CheatMealService
  {
    public void CreateCheatMeal(CheatMeal cheatMeal)
    {
      CheatMealContext.CreateCheatMeal(cheatMeal);
    }

    public List<CheatMeal> GetCheatMeals()
    {
      return CheatMealContext.GetCheatMeals();
    }

    public CheatMeal GetCheatMealById(int id)
    {
      return CheatMealContext.GetCheatMealById(id);
    }

    public void DeleteCheatMeal(int id)
    {
      CheatMealContext.DeleteCheatMeal(id);
    }

    public List<CheatMeal> GetWeeklyCheatMeals(DateTime startDate, DateTime endDate)
    {
      return CheatMealContext.GetWeeklyCheatMeals(startDate, endDate);
    }

    public void EditCheatMeal(int cheatMealId, CheatMeal newCheatMeal)
    {
      CheatMealContext.EditCheatMeal(cheatMealId, newCheatMeal);
    }

    public double GetCalorieIntakeForCheatMeal(CheatMeal cheatMeal)
    {
      return CalorieCounter.GetCalorieIntakeForCheatMeals(cheatMeal);
    }

    public double GetCalorieExpenditureForCheatMeals(List<CheatMeal> cheatMeals)
    {
      double totalCalories = cheatMeals.Sum(CalorieCounter.GetCalorieIntakeForCheatMeals);
      return totalCalories;
    }
  }
}
