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
using FitnessApp.Context;

namespace FitnessApp
{
  public partial class Dashboard : Form
  {
    private bool _isProfileLoaded;

    public Dashboard()
    {
      InitializeComponent();
      //string newHeader = 
      string newText = Text.Replace("<user>", FitnessContext.CurrentProfile.UserName);
      Text = newText;
    }

    private void OnTabChanged(object sender, TabControlEventArgs e)
    {
      var index = e.TabPageIndex;
      if (e.TabPage == ProfileTab)
      {
        if (!_isProfileLoaded)
        {
          var profile = FitnessContext.CurrentProfile;
          var user = profile.User;
          txtFirstName.Text = user.FirstName;
          txtLastName.Text = user.LastName;
          txtUserName.Text = profile.UserName;
          txtAge.Text = user.Age.ToString(CultureInfo.InvariantCulture);
          txtHeight.Text = user.Height.ToString(CultureInfo.InvariantCulture);
          txtWeight.Text = user.Weight.ToString(CultureInfo.InvariantCulture);
          _isProfileLoaded = true;
        }
      }
    }
  }
}
