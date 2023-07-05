using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessApp.Business.Handlers;
using FitnessApp.Business.Logic.Constants;
using FitnessApp.Models;

namespace FitnessApp
{
  public partial class Register : Form
  {
    private UserService _userService;

    public Register()
    {
      InitializeComponent();
      _userService = new UserService();
      InitializePasswordChars();
    }

    private void InitializePasswordChars()
    {
      txtPassword.PasswordChar = (char)0x2022;
      txtConfirmPassword.PasswordChar = (char)0x2022;
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
      if (ValidateChildren(ValidationConstraints.Enabled) && AdditionalValidations())
      {
        // user
        User newUser = new User
        {
          FirstName = txtFirstName.Text,
          LastName = txtLastName.Text,
          Age = int.Parse(txtAge.Text),
          Height = int.Parse(txtHeight.Text),
          Weight = double.Parse(txtWeight.Text)
        };

        UserProfile newUserProfile = new UserProfile
        {
          User = newUser,
          UserName = txtUserName.Text,
          Password = txtPassword.Text
        };
        
        _userService.CreateUser(newUserProfile);
        var dialogResult = MessageBox.Show("User created successfully.", "Success!");
        if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Cancel)
        {
          var dashBoard = new Dashboard();
          Hide();
          dashBoard.Activate();
          dashBoard.ShowDialog();
        }
      }
    }

    #region Field Validations

    private bool AdditionalValidations()
    {
      if (IsUsernameValid())
      {
        return ValidatePasswords();
      }
      var message = $"The username {txtUserName.Text} already exists.";
      MessageBox.Show(message, "Error");
      return false;
    }

    private bool ValidatePasswords()
    {
      var password = txtPassword.Text.Trim();
      var confirmPassword = txtPassword.Text.Trim();

      if (password.Length < ApplicationConstants.PasswordCharMinLength ||
          confirmPassword.Length < ApplicationConstants.PasswordCharMinLength)
      {
        var length = ApplicationConstants.PasswordCharMinLength;
        RegisterErrorHandler.SetError(txtPassword, $"Password must contain atleast {length} characters.");
        return false;
      }

      if (password != confirmPassword)
      {
        RegisterErrorHandler.SetError(txtPassword, "Passwords do not match.");
        return false;
      }

      return true;
    }

    private bool IsUsernameValid()
    {
      string username = txtUserName.Text.Trim();
      return !(_userService.IsUsernameExist(username));
    }

    private void txtField_Validating(object sender, CancelEventArgs e)
    {
      TextBox txtBox = sender as TextBox;
      if (string.IsNullOrWhiteSpace(txtBox.Text))
      {
        e.Cancel = true;
        txtBox.Focus();
        RegisterErrorHandler.SetError(txtBox, "Value must not be empty.");
      }
      else
      {
        e.Cancel = false;
        RegisterErrorHandler.SetError(txtBox, string.Empty);
      }
    }

    private void txtNumber_Validating(object sender, CancelEventArgs e)
    {
      TextBox txtBox = sender as TextBox;
      if (string.IsNullOrWhiteSpace(txtBox.Text))
      {
        e.Cancel = true;
        txtBox.Focus();
        RegisterErrorHandler.SetError(txtBox, "Value must not be empty.");
      }
      else if (!int.TryParse(txtBox.Text, out var value))
      {
        e.Cancel = true;
        txtBox.Focus();
        RegisterErrorHandler.SetError(txtBox, "Value must be a number.");
      }
      else if (value < 0)
      {
        e.Cancel = true;
        txtBox.Focus();
        RegisterErrorHandler.SetError(txtBox, "Value must be a positive number.");
      }
      else
      {
        e.Cancel = false;
        RegisterErrorHandler.SetError(txtBox, string.Empty);
      }
    }

    private void txtDouble_Validating(object sender, CancelEventArgs e)
    {
      TextBox txtBox = sender as TextBox;
      if (string.IsNullOrWhiteSpace(txtBox.Text))
      {
        e.Cancel = true;
        txtBox.Focus();
        RegisterErrorHandler.SetError(txtBox, "Value must not be empty.");
      }
      else if (!double.TryParse(txtBox.Text, out var value))
      {
        e.Cancel = true;
        txtBox.Focus();
        RegisterErrorHandler.SetError(txtBox, "Value must be a number.");
      }
      else if (value < 0)
      {
        e.Cancel = true;
        txtBox.Focus();
        RegisterErrorHandler.SetError(txtBox, "Value must be a positive number.");
      }
      else
      {
        e.Cancel = false;
        RegisterErrorHandler.SetError(txtBox, string.Empty);
      }
    }
    #endregion
  }
}
