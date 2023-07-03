
namespace FitnessApp.CustomControls
{
  partial class EditableContentFields
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lblField = new System.Windows.Forms.Label();
      this.txtValue = new System.Windows.Forms.TextBox();
      this.lblUnit = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblField
      // 
      this.lblField.AutoSize = true;
      this.lblField.BackColor = System.Drawing.SystemColors.Control;
      this.lblField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblField.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.lblField.Location = new System.Drawing.Point(3, 9);
      this.lblField.Name = "lblField";
      this.lblField.Size = new System.Drawing.Size(70, 25);
      this.lblField.TabIndex = 2;
      this.lblField.Text = "label1";
      // 
      // txtValue
      // 
      this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtValue.Location = new System.Drawing.Point(269, 9);
      this.txtValue.Name = "txtValue";
      this.txtValue.Size = new System.Drawing.Size(140, 30);
      this.txtValue.TabIndex = 3;
      // 
      // lblUnit
      // 
      this.lblUnit.AutoSize = true;
      this.lblUnit.BackColor = System.Drawing.SystemColors.Control;
      this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.lblUnit.Location = new System.Drawing.Point(431, 12);
      this.lblUnit.Name = "lblUnit";
      this.lblUnit.Size = new System.Drawing.Size(35, 25);
      this.lblUnit.TabIndex = 4;
      this.lblUnit.Text = "kg";
      // 
      // EditableContentFields
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblUnit);
      this.Controls.Add(this.txtValue);
      this.Controls.Add(this.lblField);
      this.Name = "EditableContentFields";
      this.Size = new System.Drawing.Size(483, 51);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label lblField;
    private System.Windows.Forms.TextBox txtValue;
    private System.Windows.Forms.Label lblUnit;
  }
}
