using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
