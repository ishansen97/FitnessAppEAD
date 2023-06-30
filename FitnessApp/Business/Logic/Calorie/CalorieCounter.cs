using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Context;
using FitnessApp.Models;
using FitnessApp.Models.Enums;

namespace FitnessApp.Business.Logic.Calorie
{
  public static class CalorieCounter
  {
    private const double CalorieWeightFactor = 0.6;

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
      calorieExpenditure = exerciseCalorie * unit * CalorieWeightFactor * weight;
      return calorieExpenditure;
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
