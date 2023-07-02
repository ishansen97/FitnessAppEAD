
namespace FitnessApp.CustomControls
{
  partial class DailyPanel
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
      this.lblDate = new System.Windows.Forms.Label();
      this.btnViewMore = new System.Windows.Forms.Button();
      this.lblDailyPanelMessage = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblDate
      // 
      this.lblDate.AutoSize = true;
      this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDate.Location = new System.Drawing.Point(52, 36);
      this.lblDate.Name = "lblDate";
      this.lblDate.Size = new System.Drawing.Size(123, 32);
      this.lblDate.TabIndex = 0;
      this.lblDate.Text = "June 27";
      // 
      // btnViewMore
      // 
      this.btnViewMore.BackColor = System.Drawing.SystemColors.Menu;
      this.btnViewMore.FlatAppearance.BorderSize = 5;
      this.btnViewMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnViewMore.Location = new System.Drawing.Point(522, 30);
      this.btnViewMore.Name = "btnViewMore";
      this.btnViewMore.Size = new System.Drawing.Size(155, 38);
      this.btnViewMore.TabIndex = 3;
      this.btnViewMore.Text = "View More";
      this.btnViewMore.UseVisualStyleBackColor = false;
      this.btnViewMore.Click += new System.EventHandler(this.btnViewMore_Click);
      // 
      // lblDailyPanelMessage
      // 
      this.lblDailyPanelMessage.AutoSize = true;
      this.lblDailyPanelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDailyPanelMessage.ForeColor = System.Drawing.SystemColors.ActiveBorder;
      this.lblDailyPanelMessage.Location = new System.Drawing.Point(270, 41);
      this.lblDailyPanelMessage.Name = "lblDailyPanelMessage";
      this.lblDailyPanelMessage.Size = new System.Drawing.Size(167, 25);
      this.lblDailyPanelMessage.TabIndex = 4;
      this.lblDailyPanelMessage.Text = "Content Message";
      // 
      // DailyPanel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.Controls.Add(this.lblDailyPanelMessage);
      this.Controls.Add(this.btnViewMore);
      this.Controls.Add(this.lblDate);
      this.Name = "DailyPanel";
      this.Size = new System.Drawing.Size(700, 104);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.Button btnViewMore;
    private System.Windows.Forms.Label lblDailyPanelMessage;
  }
}
