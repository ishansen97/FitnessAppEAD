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
      string userName = UserContext.CurrentProfile.UserName;
      if (_workouts.ContainsKey(userName))
      {
        // get workout list.
        var workoutList = (List<Workout>)_workouts[userName];
        var newWorkoutId = workoutList.Count + 1;
        workout.Id = newWorkoutId;
        workoutList.Add(workout);
        _workouts[userName] = workoutList;
      }
      else
      {
        workout.Id = 1;
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

    public static Workout GetWorkoutById(int id)
    {
      var userName = UserContext.CurrentProfile.UserName;
      if (_workouts.ContainsKey(userName))
      {
        var workouts = (List<Workout>)_workouts[userName];
        return workouts.First(wk => wk.Id == id);
      }

      return null;
    }

    public static void DeleteWorkout(int workoutId)
    {
      string userName = UserContext.CurrentProfile.UserName;
      if (_workouts.ContainsKey(userName))
      {
        var workouts = (List<Workout>)_workouts[userName];
        workouts.RemoveAll(wk => wk.Id == workoutId);
        _workouts[userName] = workouts;
      }
    }

    public static List<Workout> GetWeeklyWorkouts(DateTime startDate, DateTime endDate, bool isSorted = true)
    {
      string userName = UserContext.CurrentProfile.UserName;
      var weeklyWorkouts = new List<Workout>();
      if (_workouts.ContainsKey(userName))
      {
        var workouts = (List<Workout>)_workouts[userName];
        var searchedWorkouts = workouts.Where(wk => wk.Created >= startDate && wk.Created <= endDate);
        if (isSorted)
        {
          weeklyWorkouts = searchedWorkouts.OrderBy(wk => wk.Created).ToList();
        }
        else
        {
          weeklyWorkouts = searchedWorkouts.ToList();
        }
      }
      return weeklyWorkouts;
    }
  }
}
