using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Models.Abstractions;
using FitnessApp.Models.Enums;

namespace FitnessApp.Models
{
    public class Workout : Detail
    {
      public ExerciseType Exercise { get; set; }

      public User User { get; set; }

      public Dictionary<string, double> Fields { get; set; }
    }
}
