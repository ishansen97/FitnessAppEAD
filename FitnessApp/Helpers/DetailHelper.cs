using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Models;
using FitnessApp.Models.Abstractions;

namespace FitnessApp.Helpers
{
    public class DetailHelper
    {
      private Detail _detail;

      public Detail Detail
      {
        get
        {
          return _detail;
        }
      }

      public DetailHelper(Detail detail)
      {
        _detail = detail;
      }

      public string GetHeader()
      {
        string header = string.Empty;
        if (_detail.GetType() == typeof(Workout))
        {
          var workout = (Workout)_detail;
          header = workout.Exercise.ToString();
        }

        return header;
      }
    }
}
