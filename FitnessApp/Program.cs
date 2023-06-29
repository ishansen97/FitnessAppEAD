using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessApp.Context;

namespace FitnessApp
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      // initialize the app data.
      InitializeApp();

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new LoginForm());
    }

    private static void InitializeApp()
    {
      UserContext.InitializeUserContext();
      WorkoutContext.InitializeWorkoutContext();
      CheatMealContext.InitializeCheatMealContext();
    }
  }
}
