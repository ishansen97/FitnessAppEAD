using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
