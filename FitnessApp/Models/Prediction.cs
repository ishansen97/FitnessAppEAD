using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Models.Enums;

namespace FitnessApp.Models
{
    public class Prediction
    {
      public UserProfile UserProfile { get; set; }

      public PredictionState State { get; set; }

      public double PredictedWeight { get; set; }

      public double BodyFatPercentage { get; set; }

      public DateTime PredictedDate { get; set; }

      public double BMI { get; set; }

      public double PredictedBMI { get; set; }

      public PredictedWeightStatus WeightStatus { get; set; }

      public string Message { get; set; }
    }
}
