using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Helpers
{
  public static class DateHelper
  {
    public static string CreateWeekText(DateTime dt)
    {
      var dayOfWeek = dt.DayOfWeek;
      int daysAfterStartOfWeek = -((int)dayOfWeek % 7);
      int daysBeforeEndOfWeek = daysAfterStartOfWeek + 6;

      var startOfWeekDate = dt.AddDays(daysAfterStartOfWeek);
      var endOfWeekDate = dt.AddDays(daysBeforeEndOfWeek);

      var startOfWeekFormatted = startOfWeekDate.ToString("yyyy MMMM dd");
      var endOfWeekFormatted = endOfWeekDate.ToString("yyyy MMMM dd");

      var startOfWeekSplitted = startOfWeekFormatted.Split(' ');
      var endOfWeekSplitted = endOfWeekFormatted.Split(' ');

      var startOfWeekMonthDate = string.Concat(startOfWeekSplitted[1], " ", startOfWeekSplitted[2]);
      var endOfWeekMonthDate = string.Concat(endOfWeekSplitted[1], " ", endOfWeekSplitted[2]);

      return string.Concat(startOfWeekMonthDate, " - ", endOfWeekMonthDate);
    }
  }
}
