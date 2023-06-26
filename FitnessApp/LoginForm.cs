﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
      Dashboard dashboard = new Dashboard();
      dashboard.Activate();
      dashboard.Show();
    }
  }
}
