using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Models.Enums;

namespace FitnessApp.Models
{
    public class Workout
    {
      public int WorkoutId { get; set; }

      public ExerciseType Exercise { get; set; }

      public User User { get; set; }

      public DateTime Created { get; set; }

      public Dictionary<string, double> Fields { get; set; }
    }
}
