using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Models.Abstractions
{
  /// <summary>
  /// This class will generalize workouts and meals.
  /// </summary>
  public class Detail
  {
    public int Id { get; set; }

    public DateTime Created { get; set; }
  }
}
