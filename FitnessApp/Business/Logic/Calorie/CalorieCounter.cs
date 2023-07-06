using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Business.Logic.Constants;
using FitnessApp.Context;
using FitnessApp.Models;
using FitnessApp.Models.Enums;

namespace FitnessApp.Business.Logic.Calorie
{
  public static class CalorieCounter
  {
    public static double GetTotalWorkoutCalorieExpenditure(List<Workout> workouts)
    {
      double totalCalories = workouts.Sum(GetCalorieExpenditureForExercise);
      return totalCalories;
    }

    public static double GetTotalCheatMealCalorieIntake(List<CheatMeal> cheatMeals)
    {
      double totalCalorieIntake = cheatMeals.Sum(GetCalorieIntakeForCheatMeals);
      return totalCalorieIntake;
    }

    public static double GetCalorieExpenditurePerDay(List<Workout> workouts, List<CheatMeal> cheatMeals, double calorieDiff)
    {
      DateTime minDate = new DateTime();
      var workoutsOrderedByDate = workouts.Select(wk => wk.Created).OrderBy(dt => dt).ToList();
      var cheatMealsOrderedByDate = cheatMeals.Select(cm => cm.Created).OrderBy(dt => dt).ToList();
      var minWorkoutDate = DateTime.Today;
      var maxWorkoutDate = DateTime.Today;
      var minCheatMealDate = DateTime.Today;
      var maxCheatMealDate = DateTime.Today;
      if (workoutsOrderedByDate.Any())
      {
        minWorkoutDate = workoutsOrderedByDate.First();
        maxWorkoutDate = workoutsOrderedByDate.Last();
      }

      if (cheatMealsOrderedByDate.Any())
      {
        minCheatMealDate = cheatMealsOrderedByDate.First();
        maxCheatMealDate = cheatMealsOrderedByDate.Last();
      }

      var dateTimes = new List<DateTime> { minWorkoutDate, maxWorkoutDate, minCheatMealDate, maxCheatMealDate };
      minDate = dateTimes.OrderBy(dt => dt).First();

      var dateGap = (DateTime.Today - minDate).TotalDays;

      if (dateGap > 0)
      {
        return Math.Round((calorieDiff / dateGap), 1);
      }

      return 0;
    }

    public static double CalculateTotalCalorieExpenditure(int dateDiff, double expPerDay)
    {
      var user = UserContext.CurrentProfile.User;
      var calorieBurnFactor = GetCalorieBurnFactor(user.Weight);
      var totalCalorieExpenditure = calorieBurnFactor * dateDiff * expPerDay;

      return totalCalorieExpenditure;
    }

    private static double GetCalorieBurnFactor(double weight)
    {
      double calorieBurnFactor = 1;
      if (weight >= 200)
      {
        calorieBurnFactor = 2.5;
      }
      else if (weight >= 150 && weight < 200)
      {
        calorieBurnFactor = 2;
      }
      else if (weight >= 100 && weight < 150)
      {
        calorieBurnFactor = 1.5;
      }
      else if (weight >= 50 && weight < 100)
      {
        calorieBurnFactor = 1;
      }
      else
      {
        calorieBurnFactor = 0.5;
      }

      return calorieBurnFactor;
    }

    public static double GetCalorieExpenditureForExercise(Workout workout)
    {
      var user = UserContext.CurrentProfile.User;
      double weight = 0.0f;
      double unit = 0, calorieExpenditure = 0;
      switch (workout.Exercise)
      {
        case ExerciseType.Walking:
        case ExerciseType.Running:
        case ExerciseType.Cycling:
          unit = GetWorkoutUnit(workout.Fields, "Distance");
          weight = user.Weight;
          break;
        case ExerciseType.Pushups:
        case ExerciseType.Pullups:
        case ExerciseType.Crunches:
        case ExerciseType.Squats:
          unit = GetWorkoutUnit(workout.Fields, "Reps");
          weight = user.Weight;
          break;
        case ExerciseType.Plank:
          unit = GetWorkoutUnit(workout.Fields, "Time");
          weight = user.Weight;
          break;
        case ExerciseType.DeadLifts:
        case ExerciseType.BicepCurls:
        case ExerciseType.BenchPress:
        case ExerciseType.LegPress:
          unit = GetWorkoutUnit(workout.Fields, "Reps");
          weight = GetWorkoutWeight(workout.Fields);
          break;
      }

      // calculate the calorie expenditure.
      var exerciseCalorie = ExerciseContext.GetExerciseCalorie(workout.Exercise);
      calorieExpenditure = exerciseCalorie * unit * PredictionConstants.CalorieWeightFactor * weight;
      return calorieExpenditure;
    }

    public static double GetCalorieIntakeForCheatMeals(CheatMeal cheatMeal)
    {
      var mealCaloriePerUnit = MealContext.GetMealCalorie(cheatMeal.MealType);
      var calorieIntake = mealCaloriePerUnit * cheatMeal.MealAmount;
      return calorieIntake;
    }

    private static double GetWorkoutWeight(Dictionary<string, double> fields)
    {
      double weight = 0.0f;
      if (fields.ContainsKey("Weight"))
      {
        weight = fields["Weight"];
      }

      return weight;
    }

    private static double GetWorkoutUnit(Dictionary<string, double> fields, string key)
    {
      double unit = 0;
      if (fields.ContainsKey(key))
      {
        unit = fields[key];
      }

      return unit;
    }
  }
}
