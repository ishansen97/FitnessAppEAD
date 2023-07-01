using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Models.Enums;

namespace FitnessApp.Helpers
{
  public static class EnumHelper
  {
    public static object[] LoadItems<T>()
    {
      var array = Enum.GetValues(typeof(T));
      object[] objArr = new object[array.Length];
      array.CopyTo(objArr, 0);

      return objArr;
    }

    public static Color GetTextColorForPredictionStatus(PredictionState state)
    {
      switch (state)
      {
        case PredictionState.Good:
          return Color.Green;
        case PredictionState.Bad:
          return Color.Red;
      }

      return Color.Black;
    }
  }
}
