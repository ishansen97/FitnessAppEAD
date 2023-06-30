﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessApp.Business.Handlers;
using FitnessApp.Helpers;
using FitnessApp.Models;
using FitnessApp.Models.Enums;

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
      cmbCheatMealTypes.Items.AddRange(EnumHelper.LoadItems<MealType>());
    }

    private void btnAddCheatMeal_Click(object sender, EventArgs e)
    {
      if (ValidateChildren(ValidationConstraints.Enabled))
      {
        CreateCheatMeal();
        LoadDashboard();
      }
    }

    private void CreateCheatMeal()
    {
      MealType cheatMealType = (MealType)cmbCheatMealTypes.SelectedItem;
      double grams = double.Parse(txtAmount.Text);
      DateTime date = dtCheatMealPicker.Value;

      CheatMeal cheatMeal = new CheatMeal
      {
        MealType = cheatMealType,
        Gram = grams,
        Created = date
      };

      _cheatMealService.CreateCheatMeal(cheatMeal);
    }

    private void LoadDashboard()
    {
      Dashboard dashboard = new Dashboard();
      Hide();
      dashboard.Activate();
      dashboard.ShowDialog();
    }

    #region Field Validations
    private void cmbCheatMealTypes_Validating(object sender, CancelEventArgs e)
    {
      ComboBox cmb = sender as ComboBox;
      if (string.IsNullOrEmpty(cmb.SelectedItem.ToString()))
      {
        e.Cancel = true;
        cmb.Focus();
        CheatMealErrorHandler.SetError(cmb, "Please select a meal type.");
      }
      else
      {
        e.Cancel = false;
        CheatMealErrorHandler.SetError(cmb, string.Empty);
      }
    }

    private void txtAmount_Validating(object sender, CancelEventArgs e)
    {
      TextBox txtBox = sender as TextBox;
      if (string.IsNullOrWhiteSpace(txtBox.Text))
      {
        e.Cancel = true;
        txtBox.Focus();
        CheatMealErrorHandler.SetError(txtBox, "Please provide the meal amount.");
      }
      else
      {
        e.Cancel = false;
        CheatMealErrorHandler.SetError(txtBox, string.Empty);
      }
    }
    #endregion
  }
}