using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Models;

namespace FitnessApp.Context
{
  public static class WorkoutContext
  {
    private static Hashtable _workouts;

    public static void InitializeWorkoutContext()
    {
      _workouts = new Hashtable();
    }

    public static void CreateWorkout(Workout workout)
    {
      var userName = UserContext.CurrentProfile.UserName;
      if (_workouts.ContainsKey(userName))
      {
        // get workout list.
        var workoutList = (List<Workout>)_workouts[userName];
        workoutList.Add(workout);
        _workouts[userName] = workoutList;
      }
      else
      {
        List<Workout> workouts = new List<Workout> { workout };
        _workouts.Add(userName, workouts);
      }
    }

    public static List<Workout> GetWorkouts()
    {
      var userName = UserContext.CurrentProfile.UserName;
      if (_workouts.ContainsKey(userName))
      {
        return (List<Workout>)_workouts[userName];
      }

      return new List<Workout>();
    }
  }
}
