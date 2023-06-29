using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessApp.Business.Handlers;

namespace FitnessApp
{
  public partial class CheatMealForm : Form
  {
    private CheatMealService _cheatMealService;

    public CheatMealForm()
    {
      InitializeComponent();
      _cheatMealService = new CheatMealService();
      dtCheatMealPicker.MaxDate = DateTime.Now;
    }
  }
}
