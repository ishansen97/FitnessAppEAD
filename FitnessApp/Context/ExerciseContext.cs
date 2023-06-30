using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Models.Enums;

namespace FitnessApp.Context
{
    public static class ExerciseContext
    {
      private static Dictionary<ExerciseType, double> _exerciseCalorieUnitMeasurements;

      public static void InitializeExerciseContext()
      {
        // note that these are random numbers.
        _exerciseCalorieUnitMeasurements = new Dictionary<ExerciseType, double>
        {
          [ExerciseType.Walking] = 25, // per km
          [ExerciseType.Running] = 45, // per km
          [ExerciseType.Cycling] = 40, // per km
          [ExerciseType.Pushups] = 1, // per rep
          [ExerciseType.Pullups] = 2, // per rep
          [ExerciseType.Crunches] = 1, // per rep
          [ExerciseType.Plank] = 8, // per minute
          [ExerciseType.Squats] = 1, // per rep
          [ExerciseType.DeadLifts] = 10, // per rep (need to consider equipment weight)
          [ExerciseType.BicepCurls] = 3, // per rep (need to consider equipment weight)
          [ExerciseType.BenchPress] = 8, // per rep (need to consider equipment weight)
          [ExerciseType.LegPress] = 10 // per rep (need to consider equipment weight)
        };
      }

      public static double GetExerciseCalorie(ExerciseType exerciseType)
      {
        return _exerciseCalorieUnitMeasurements[exerciseType];
      }
    }
}
