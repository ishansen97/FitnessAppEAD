using System;
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
  public partial class Register : Form
  {
    public Register()
    {
      InitializeComponent();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
      if (ValidateChildren(ValidationConstraints.Enabled))
      {
        string firstName = txtFirstName.Text.Trim();
        string lastName = txtLastName.Text.Trim();
        int age = int.Parse(txtAge.Text.Trim());
        int height = int.Parse(txtHeight.Text.Trim());
        float weight = float.Parse(txtWeight.Text.Trim());
        string password = txtPassword.Text.Trim();
      }
    }
  }
}
