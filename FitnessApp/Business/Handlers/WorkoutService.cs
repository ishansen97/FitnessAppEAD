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

      public Workout GetWorkoutById(int id)
      {
        return WorkoutContext.GetWorkoutById(id);
      }
 
      public void DeleteWorkout(int workoutId)
      {
        WorkoutContext.DeleteWorkout(workoutId);
      }

      public List<Workout> GetWeeklyWorkouts(DateTime startDate, DateTime endDate)
      {
        return WorkoutContext.GetWeeklyWorkouts(startDate, endDate);
      }

      public void EditWorkout(int workoutId, Workout newWorkout)
      {
        WorkoutContext.EditWorkout(workoutId, newWorkout);
      }
    }
}
