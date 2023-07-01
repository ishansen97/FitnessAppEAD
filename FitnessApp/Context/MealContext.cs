using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Models.Enums;

namespace FitnessApp.Context
{
    public static class MealContext
    {
      private static Dictionary<MealType, double> _mealCalorieUnitMeasurements;

      public static void InitializeMealContext()
      {
        _mealCalorieUnitMeasurements = new Dictionary<MealType, double>
        {
          [MealType.Pizza] = 2.7,
          [MealType.Pasta] = 1.31,
          [MealType.Bacon] = 5,
          [MealType.Burger] = 2.95,
          [MealType.Taco] = 2.25
        };
      }

      public static double GetMealCalorie(MealType mealType)
      {
        return _mealCalorieUnitMeasurements[mealType];
      }
    }
}
