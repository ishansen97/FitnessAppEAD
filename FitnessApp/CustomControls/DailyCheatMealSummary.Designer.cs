
namespace FitnessApp.CustomControls
{
  partial class DailyCheatMealSummary
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
      this.lblMealType = new System.Windows.Forms.Label();
      this.lblMealTypeValue = new System.Windows.Forms.Label();
      this.lblAmountValue = new System.Windows.Forms.Label();
      this.lblAmount = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblMealType
      // 
      this.lblMealType.AutoSize = true;
      this.lblMealType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMealType.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.lblMealType.Location = new System.Drawing.Point(37, 33);
      this.lblMealType.Name = "lblMealType";
      this.lblMealType.Size = new System.Drawing.Size(136, 29);
      this.lblMealType.TabIndex = 0;
      this.lblMealType.Text = "Meal Type";
      // 
      // lblMealTypeValue
      // 
      this.lblMealTypeValue.AutoSize = true;
      this.lblMealTypeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMealTypeValue.ForeColor = System.Drawing.Color.Black;
      this.lblMealTypeValue.Location = new System.Drawing.Point(312, 33);
      this.lblMealTypeValue.Name = "lblMealTypeValue";
      this.lblMealTypeValue.Size = new System.Drawing.Size(70, 29);
      this.lblMealTypeValue.TabIndex = 1;
      this.lblMealTypeValue.Text = "Meal";
      // 
      // lblAmountValue
      // 
      this.lblAmountValue.AutoSize = true;
      this.lblAmountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAmountValue.ForeColor = System.Drawing.Color.Black;
      this.lblAmountValue.Location = new System.Drawing.Point(312, 89);
      this.lblAmountValue.Name = "lblAmountValue";
      this.lblAmountValue.Size = new System.Drawing.Size(75, 29);
      this.lblAmountValue.TabIndex = 3;
      this.lblAmountValue.Text = "value";
      // 
      // lblAmount
      // 
      this.lblAmount.AutoSize = true;
      this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAmount.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.lblAmount.Location = new System.Drawing.Point(37, 89);
      this.lblAmount.Name = "lblAmount";
      this.lblAmount.Size = new System.Drawing.Size(100, 29);
      this.lblAmount.TabIndex = 2;
      this.lblAmount.Text = "Amount";
      // 
      // DailyCheatMealSummary
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lblAmountValue);
      this.Controls.Add(this.lblAmount);
      this.Controls.Add(this.lblMealTypeValue);
      this.Controls.Add(this.lblMealType);
      this.Name = "DailyCheatMealSummary";
      this.Size = new System.Drawing.Size(581, 153);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblMealType;
    private System.Windows.Forms.Label lblMealTypeValue;
    private System.Windows.Forms.Label lblAmountValue;
    private System.Windows.Forms.Label lblAmount;
  }
}
