using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp.Helpers
{
  public static class WorkoutFieldsHelper
  {
    public static bool ValidateTextField(TextBox txtBox, string key)
    {
      if (string.IsNullOrWhiteSpace(txtBox.Text))
      {
        return false;
      }

      bool isValid = true;
      switch (key)
      {
        case "Weight":
        case "Distance":
        case "Reps":
        case "Time":
          if (!int.TryParse(txtBox.Text, out var value))
          {
            isValid = false;
          }
          else if (value < 0)
          {
            isValid = false;
          }
          break;
      }

      return isValid;
    }
  }
}
