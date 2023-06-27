using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Models
{
    public class Workout
    {
      public int WorkoutId { get; set; }

      public List<Exercise> Exercises { get; set; }

      public User User { get; set; }
    }
}
