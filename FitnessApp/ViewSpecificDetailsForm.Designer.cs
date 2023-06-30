
namespace FitnessApp
{
  partial class ViewSpecificDetailsForm
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lblViewDetailsHeader = new System.Windows.Forms.Label();
      this.pnlDetailView = new System.Windows.Forms.Panel();
      this.lblActivityType = new System.Windows.Forms.Label();
      this.lblDate = new System.Windows.Forms.Label();
      this.lblActivity = new System.Windows.Forms.Label();
      this.lblDateInfo = new System.Windows.Forms.Label();
      this.pnlFieldsPanel = new System.Windows.Forms.Panel();
      this.pnlDetailView.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblViewDetailsHeader
      // 
      this.lblViewDetailsHeader.AutoSize = true;
      this.lblViewDetailsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblViewDetailsHeader.Location = new System.Drawing.Point(322, 51);
      this.lblViewDetailsHeader.Name = "lblViewDetailsHeader";
      this.lblViewDetailsHeader.Size = new System.Drawing.Size(289, 44);
      this.lblViewDetailsHeader.TabIndex = 0;
      this.lblViewDetailsHeader.Text = "<Type> Details";
      // 
      // pnlDetailView
      // 
      this.pnlDetailView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.pnlDetailView.Controls.Add(this.pnlFieldsPanel);
      this.pnlDetailView.Controls.Add(this.lblDateInfo);
      this.pnlDetailView.Controls.Add(this.lblActivity);
      this.pnlDetailView.Controls.Add(this.lblDate);
      this.pnlDetailView.Controls.Add(this.lblActivityType);
      this.pnlDetailView.Location = new System.Drawing.Point(143, 98);
      this.pnlDetailView.Name = "pnlDetailView";
      this.pnlDetailView.Size = new System.Drawing.Size(697, 414);
      this.pnlDetailView.TabIndex = 1;
      // 
      // lblActivityType
      // 
      this.lblActivityType.AutoSize = true;
      this.lblActivityType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblActivityType.Location = new System.Drawing.Point(35, 33);
      this.lblActivityType.Name = "lblActivityType";
      this.lblActivityType.Size = new System.Drawing.Size(175, 29);
      this.lblActivityType.TabIndex = 0;
      this.lblActivityType.Text = "Workout Type";
      // 
      // lblDate
      // 
      this.lblDate.AutoSize = true;
      this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDate.Location = new System.Drawing.Point(35, 100);
      this.lblDate.Name = "lblDate";
      this.lblDate.Size = new System.Drawing.Size(67, 29);
      this.lblDate.TabIndex = 1;
      this.lblDate.Text = "Date";
      // 
      // lblActivity
      // 
      this.lblActivity.AutoSize = true;
      this.lblActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblActivity.Location = new System.Drawing.Point(350, 33);
      this.lblActivity.Name = "lblActivity";
      this.lblActivity.Size = new System.Drawing.Size(65, 29);
      this.lblActivity.TabIndex = 3;
      this.lblActivity.Text = "Test";
      // 
      // lblDateInfo
      // 
      this.lblDateInfo.AutoSize = true;
      this.lblDateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDateInfo.Location = new System.Drawing.Point(350, 100);
      this.lblDateInfo.Name = "lblDateInfo";
      this.lblDateInfo.Size = new System.Drawing.Size(67, 29);
      this.lblDateInfo.TabIndex = 4;
      this.lblDateInfo.Text = "Date";
      // 
      // pnlFieldsPanel
      // 
      this.pnlFieldsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.pnlFieldsPanel.Location = new System.Drawing.Point(37, 168);
      this.pnlFieldsPanel.Name = "pnlFieldsPanel";
      this.pnlFieldsPanel.Size = new System.Drawing.Size(454, 175);
      this.pnlFieldsPanel.TabIndex = 5;
      // 
      // ViewSpecificDetailsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(994, 583);
      this.Controls.Add(this.pnlDetailView);
      this.Controls.Add(this.lblViewDetailsHeader);
      this.Name = "ViewSpecificDetailsForm";
      this.Text = "View Details";
      this.pnlDetailView.ResumeLayout(false);
      this.pnlDetailView.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblViewDetailsHeader;
    private System.Windows.Forms.Panel pnlDetailView;
    private System.Windows.Forms.Label lblDateInfo;
    private System.Windows.Forms.Label lblActivity;
    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.Label lblActivityType;
    private System.Windows.Forms.Panel pnlFieldsPanel;
  }
}