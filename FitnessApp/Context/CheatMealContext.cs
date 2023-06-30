using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Models;

namespace FitnessApp.Context
{
  public static class CheatMealContext
  {
    private static Hashtable _cheatMeals;

    public static void InitializeCheatMealContext()
    {
      _cheatMeals = new Hashtable();
    }

    public static void CreateCheatMeal(CheatMeal cheatMeal)
    {
      string userName = UserContext.CurrentProfile.UserName;
      if (_cheatMeals.ContainsKey(userName))
      {
        var cheatMeals = (List<CheatMeal>)_cheatMeals[userName];
        int newCheatMealId = cheatMeals.Count + 1;
        cheatMeal.Id = newCheatMealId;
        cheatMeals.Add(cheatMeal);
        _cheatMeals[userName] = cheatMeals;
      }
      else
      {
        cheatMeal.Id = 1;
        var cheatMeals = new List<CheatMeal> { cheatMeal };
        _cheatMeals.Add(userName, cheatMeals);
      }
    }

    public static List<CheatMeal> GetCheatMeals()
    {
      string userName = UserContext.CurrentProfile.UserName;
      if (_cheatMeals.ContainsKey(userName))
      {
        return (List<CheatMeal>)_cheatMeals[userName];
      }

      return new List<CheatMeal>();
    }

    public static CheatMeal GetCheatMealById(int id)
    {
      var userName = UserContext.CurrentProfile.UserName;
      if (_cheatMeals.ContainsKey(userName))
      {
        var cheatMeals = (List<CheatMeal>)_cheatMeals[userName];
        return cheatMeals.First(cm => cm.Id == id);
      }

      return null;
    }

    public static void DeleteCheatMeal(int id)
    {
      string userName = UserContext.CurrentProfile.UserName;
      if (_cheatMeals.ContainsKey(userName))
      {
        var cheatMeals = (List<CheatMeal>)_cheatMeals[userName];
        cheatMeals.RemoveAll(cm => cm.Id == id);
        _cheatMeals[userName] = cheatMeals;
      }
    }
  }
}
