using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessApp.Context;

namespace FitnessApp
{
  public partial class LoginForm : Form
  {
    public LoginForm()
    {
      InitializeComponent();
    }

    private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Register registerForm = new Register();
      registerForm.Activate();
      registerForm.ShowDialog();
      Hide();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      if (ValidateChildren(ValidationConstraints.Enabled))
      {
        string userName = txtUserName.Text.Trim();
        string password = txtPassword.Text.Trim();
        if (UserContext.Login(userName, password))
        {
          Hide();
          Dashboard dashboard = new Dashboard();
          dashboard.Activate();
          dashboard.ShowDialog();
        }
        else
        {
          MessageBox.Show("Your username and password are incorrect.", "Invalid credentials");
        }
      }
    }

    private void txtUserName_Validate(object sender, CancelEventArgs e)
    {
      if (string.IsNullOrWhiteSpace(txtUserName.Text))
      {
        e.Cancel = true;
        txtUserName.Focus();
        LoginErrorHandler.SetError(txtUserName, "User Name must be not empty.");
      }
      else
      {
        e.Cancel = false;
        LoginErrorHandler.SetError(txtUserName, string.Empty);
      }
    }

    private void txtPassword_Validating(object sender, CancelEventArgs e)
    {
      if (string.IsNullOrWhiteSpace(txtPassword.Text))
      {
        e.Cancel = true;
        txtUserName.Focus();
        LoginErrorHandler.SetError(txtPassword, "Password must be not empty.");
      }
      else
      {
        e.Cancel = false;
        LoginErrorHandler.SetError(txtPassword, string.Empty);
      }
    }
  }
}
