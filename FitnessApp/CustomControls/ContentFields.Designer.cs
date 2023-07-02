
namespace FitnessApp.CustomControls
{
  partial class ContentFields
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
      this.lblValue = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblField
      // 
      this.lblField.AutoSize = true;
      this.lblField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblField.Location = new System.Drawing.Point(3, 0);
      this.lblField.Name = "lblField";
      this.lblField.Size = new System.Drawing.Size(70, 25);
      this.lblField.TabIndex = 0;
      this.lblField.Text = "label1";
      // 
      // lblValue
      // 
      this.lblValue.AutoSize = true;
      this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblValue.Location = new System.Drawing.Point(253, 0);
      this.lblValue.Name = "lblValue";
      this.lblValue.Size = new System.Drawing.Size(68, 25);
      this.lblValue.TabIndex = 1;
      this.lblValue.Text = "Value";
      // 
      // ContentFields
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlDark;
      this.Controls.Add(this.lblValue);
      this.Controls.Add(this.lblField);
      this.Name = "ContentFields";
      this.Size = new System.Drawing.Size(387, 40);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblField;
    private System.Windows.Forms.Label lblValue;
  }
}
