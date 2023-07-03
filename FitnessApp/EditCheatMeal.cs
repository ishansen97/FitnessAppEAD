using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessApp.Business.Handlers;
using FitnessApp.CustomControls;
using FitnessApp.Helpers;
using FitnessApp.Models;

namespace FitnessApp
{
  public partial class EditCheatMeal : Form
  {
    private CheatMealService _cheatMealService;
    private CheatMeal _cheatMeal;

    public EditCheatMeal()
    {
      InitializeComponent();
    }

    public EditCheatMeal(CheatMeal cheatMeal)
    {
      InitializeComponent();
      _cheatMealService = new CheatMealService();
      _cheatMeal = cheatMeal;
      LoadDetails();
      dtCheatMealDate.MaxDate = DateTime.Today;
    }

    private void LoadDetails()
    {
      lblCheatMealTypeValue.Text = _cheatMeal.MealType.ToString();
      txtAmount.Text = _cheatMeal.MealAmount.ToString(CultureInfo.InvariantCulture);
      dtCheatMealDate.Value = _cheatMeal.Created;
    }

    private void OnAmount_Validating(object sender, CancelEventArgs e)
    {
      TextBox txtBox = sender as TextBox;
      if (string.IsNullOrWhiteSpace(txtBox.Text))
      {
        e.Cancel = true;
        txtBox.Focus();
        CheatMealErrorHandler.SetError(lblUnit, "Amount must not be empty.");
      }
      else if (!int.TryParse(txtBox.Text, out var number))
      {
        e.Cancel = true;
        txtBox.Focus();
        CheatMealErrorHandler.SetError(lblUnit, "Amount must not be empty.");
      }
      else
      {
        e.Cancel = false;
        CheatMealErrorHandler.SetError(lblUnit, string.Empty);
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (ValidateChildren(ValidationConstraints.Enabled))
      {
        _cheatMeal.MealAmount = double.Parse(txtAmount.Text);
        _cheatMeal.Created = dtCheatMealDate.Value;
        _cheatMealService.EditCheatMeal(_cheatMeal.Id, _cheatMeal);

        var dialogResult = MessageBox.Show("Cheat Meal details are updated successfully.", "Success");
        if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Cancel)
        {
          Hide();
        }
      }
    }
  }
}
