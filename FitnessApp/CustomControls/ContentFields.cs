﻿using System;
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
    private Color _txtColor;

    public ContentFields()
    {
      InitializeComponent();
    }

    public ContentFields(string key, string value, Color txtColor)
    {
      InitializeComponent();
      _key = key;
      _value = value;
      _txtColor = txtColor;
      LoadControl();
    }

    private void LoadControl()
    {
      lblField.Text = _key;
      lblField.ForeColor = _txtColor;

      lblValue.Text = _value;
      lblValue.ForeColor = _txtColor;
    }
  }
}
