using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Context;
using FitnessApp.Models;

namespace FitnessApp.Business.Handlers
{
    public class WorkoutService
    {
      public void CreateWorkout(Workout workout)
      {
        WorkoutContext.CreateWorkout(workout);
      }

      public List<Workout> GetWorkouts()
      {
        return WorkoutContext.GetWorkouts();
      }

      public void DeleteWorkout(int workoutId)
      {
        WorkoutContext.DeleteWorkout(workoutId);
      }
    }
}
