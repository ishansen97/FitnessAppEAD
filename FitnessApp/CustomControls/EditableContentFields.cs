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
  public partial class EditableContentFields : UserControl
  {
    private string _key;
    private string _value;

    public EditableContentFields()
    {
      InitializeComponent();
    }

    public EditableContentFields(string key, string value)
    {
      InitializeComponent();
      _key = key;
      _value = value;
      LoadControl();
      Name = key;
    }

    private void LoadControl()
    {
      lblField.Text = _key;
      var splitted = _value.Split(' ');
      if (splitted.Length == 2)
      {
        txtValue.Text = splitted[0];
        lblUnit.Text = splitted[1];
      }
      else
      {
        txtValue.Text = _value;
        lblUnit.Text = string.Empty;
      }

      txtValue.Name = _key;
    }
  }
}
