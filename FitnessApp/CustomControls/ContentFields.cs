using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp.CustomControls
{
  public partial class ContentFields : UserControl
  {
    private string _key;
    private string _value;

    public ContentFields()
    {
      InitializeComponent();
    }

    public ContentFields(string key, string value)
    {
      InitializeComponent();
      _key = key;
      _value = value;
      LoadControl();
    }

    private void LoadControl()
    {
      lblField.Text = _key;
      lblValue.Text = _value;
    }
  }
}
