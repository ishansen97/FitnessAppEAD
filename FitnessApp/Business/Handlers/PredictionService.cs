using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Business.Logic.Constants;
using FitnessApp.Business.Logic.Predictions;
using FitnessApp.Models;

namespace FitnessApp.Business.Handlers
{
  public class PredictionService
  {
    private WorkoutService _workoutService;
    private CheatMealService _cheatMealService;

    public PredictionService()
    {
      _workoutService = new WorkoutService();
      _cheatMealService = new CheatMealService();
    }

    public bool EligibleToMakePredictions()
    {
      var workouts = _workoutService.GetWorkouts();
      var cheatMeals = _cheatMealService.GetCheatMeals();

      return (workouts.Count >= PredictionConstants.PredictionPrerequisiteLimit ||
              cheatMeals.Count >= PredictionConstants.PredictionPrerequisiteLimit);
    }

    public Prediction MakePrediction(DateTime predictionDate)
    {
      var workouts = _workoutService.GetWorkouts();
      var cheatMeals = _cheatMealService.GetCheatMeals();

      var prediction = PredictionEngine.MakePrediction(workouts, cheatMeals, predictionDate);
      return prediction;
    }
  }
}
