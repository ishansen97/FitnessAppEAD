using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.Models.Abstractions;
using FitnessApp.Models.Enums;

namespace FitnessApp.Models
{
    public class CheatMeal : Detail
    {
      public MealType MealType { get; set; }

      public int Gram { get; set; }
    }
}
