
namespace FitnessApp
{
  partial class ViewDailyDetail
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
      this.lblDailyDetailsHeader = new System.Windows.Forms.Label();
      this.DetailTabs = new System.Windows.Forms.TabControl();
      this.WorkoutsTab = new System.Windows.Forms.TabPage();
      this.CheatMealTab = new System.Windows.Forms.TabPage();
      this.DetailTabs.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblDailyDetailsHeader
      // 
      this.lblDailyDetailsHeader.AutoSize = true;
      this.lblDailyDetailsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDailyDetailsHeader.Location = new System.Drawing.Point(393, 46);
      this.lblDailyDetailsHeader.Name = "lblDailyDetailsHeader";
      this.lblDailyDetailsHeader.Size = new System.Drawing.Size(267, 36);
      this.lblDailyDetailsHeader.TabIndex = 0;
      this.lblDailyDetailsHeader.Text = "Summary for Date";
      // 
      // DetailTabs
      // 
      this.DetailTabs.Controls.Add(this.WorkoutsTab);
      this.DetailTabs.Controls.Add(this.CheatMealTab);
      this.DetailTabs.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DetailTabs.Location = new System.Drawing.Point(147, 94);
      this.DetailTabs.Name = "DetailTabs";
      this.DetailTabs.SelectedIndex = 0;
      this.DetailTabs.Size = new System.Drawing.Size(803, 456);
      this.DetailTabs.TabIndex = 1;
      this.DetailTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.OnTab_Selected);
      // 
      // WorkoutsTab
      // 
      this.WorkoutsTab.AutoScroll = true;
      this.WorkoutsTab.BackColor = System.Drawing.Color.White;
      this.WorkoutsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.WorkoutsTab.Location = new System.Drawing.Point(4, 28);
      this.WorkoutsTab.Name = "WorkoutsTab";
      this.WorkoutsTab.Padding = new System.Windows.Forms.Padding(3);
      this.WorkoutsTab.Size = new System.Drawing.Size(795, 424);
      this.WorkoutsTab.TabIndex = 0;
      this.WorkoutsTab.Text = "Workouts";
      // 
      // CheatMealTab
      // 
      this.CheatMealTab.AutoScroll = true;
      this.CheatMealTab.BackColor = System.Drawing.Color.White;
      this.CheatMealTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CheatMealTab.Location = new System.Drawing.Point(4, 28);
      this.CheatMealTab.Name = "CheatMealTab";
      this.CheatMealTab.Padding = new System.Windows.Forms.Padding(3);
      this.CheatMealTab.Size = new System.Drawing.Size(795, 424);
      this.CheatMealTab.TabIndex = 1;
      this.CheatMealTab.Text = "Cheat Meals";
      // 
      // ViewDailyDetail
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1061, 618);
      this.Controls.Add(this.DetailTabs);
      this.Controls.Add(this.lblDailyDetailsHeader);
      this.Name = "ViewDailyDetail";
      this.Text = "ViewDailyDetail";
      this.DetailTabs.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblDailyDetailsHeader;
    private System.Windows.Forms.TabControl DetailTabs;
    private System.Windows.Forms.TabPage WorkoutsTab;
    private System.Windows.Forms.TabPage CheatMealTab;
  }
}