using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Business.Logic.Calorie;
using FitnessApp.Business.Logic.Constants;
using FitnessApp.Context;
using FitnessApp.Models;
using FitnessApp.Models.Enums;

namespace FitnessApp.Business.Logic.Predictions
{
  public static class PredictionEngine
  {
    public static Prediction MakePrediction(List<Workout> workouts, List<CheatMeal> cheatMeals, DateTime predictedDateTime)
    {
      var workoutCalories = CalorieCounter.GetTotalWorkoutCalorieExpenditure(workouts);
      var cheatMealCalories = CalorieCounter.GetTotalCheatMealCalorieIntake(cheatMeals);
      var calorieDifference = workoutCalories - cheatMealCalories;
      var calorieExpenditurePerDay = CalorieCounter.GetCalorieExpenditurePerDay(workouts, cheatMeals, calorieDifference);

      var dateDiff = (int)(predictedDateTime - DateTime.Today).TotalDays;
      var totalCalorieExpenditure = CalorieCounter.CalculateTotalCalorieExpenditure(dateDiff, calorieExpenditurePerDay);

      var prediction = new Prediction()
      {
        UserProfile = UserContext.CurrentProfile,
        State = (calorieDifference > 0) ? PredictionState.Good : PredictionState.Bad,
        Message = GetPredictionMessage(calorieDifference > 0),
        PredictedDate = predictedDateTime,
        CurrentWeight = UserContext.CurrentProfile.User.Weight,
        PredictedWeight = GetPredictedWeight(totalCalorieExpenditure),
        BMI = GetBMI()
      };

      prediction.PredictedBMI = GetPredictedBMI(prediction.PredictedWeight);
      prediction.WeightStatus = GetPredictedWeightStatus(prediction.PredictedBMI);

      return prediction;
    }

    private static double GetPredictedBMI(double predictedWeight)
    {
      var user = UserContext.CurrentProfile.User;
      var heightInMetres = user.Height / 100.0;
      var predictedBMI = predictedWeight / Math.Pow(heightInMetres, 2);

      return predictedBMI;
    }

    private static double GetBMI()
    {
      var user = UserContext.CurrentProfile.User;
      var heightInMetres = user.Height / 100.0;
      var BMI = user.Weight / Math.Pow(heightInMetres, 2);

      return BMI;
    }

    private static double GetPredictedWeight(double totalCalorieExpenditure)
    {
      double kiloCalorieExpenditure = Math.Round(totalCalorieExpenditure * PredictionConstants.KiloPerCalorie, 1);
      var user = UserContext.CurrentProfile.User;
      return user.Weight - kiloCalorieExpenditure;
    }

    private static string GetPredictionMessage(bool isGood)
    {
      var user = UserContext.CurrentProfile.User;
      string message = string.Empty;
      if (isGood)
      {
        message = $"You are losing weight {user.FirstName}. Good job";
      }
      else
      {
        message = $"{user.FirstName} you have gained weight. Please try to be more active";
      }

      return message;
    }

    private static PredictedWeightStatus GetPredictedWeightStatus(double predictedBMI)
    {
      if (predictedBMI < 18.5)
      {
        return PredictedWeightStatus.Underweight;
      }
      if (predictedBMI >= 18.5 && predictedBMI <= 24.9)
      {
        return PredictedWeightStatus.Normal;
      }
      if (predictedBMI >= 25 && predictedBMI <= 29.9)
      {
        return PredictedWeightStatus.Overweight;
      }
      if (predictedBMI >= 30 && predictedBMI <= 34.9)
      {
        return PredictedWeightStatus.Obese;
      }
      if (predictedBMI >= 35)
      {
        return PredictedWeightStatus.ExtremelyObese;
      }

      return PredictedWeightStatus.None;
    }
  }
}
