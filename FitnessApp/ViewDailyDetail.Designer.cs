
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
      this.SummaryTab = new System.Windows.Forms.TabPage();
      this.lblWorkoutCalories = new System.Windows.Forms.Label();
      this.lblWorkoutCalorieValue = new System.Windows.Forms.Label();
      this.lblCheatMealCalorieValue = new System.Windows.Forms.Label();
      this.lblCheatMealCalories = new System.Windows.Forms.Label();
      this.lblCalorieStatusValue = new System.Windows.Forms.Label();
      this.lblCalorieStatusLabel = new System.Windows.Forms.Label();
      this.lblCalorieStatusMeasure = new System.Windows.Forms.Label();
      this.DetailTabs.SuspendLayout();
      this.SummaryTab.SuspendLayout();
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
      this.DetailTabs.Controls.Add(this.SummaryTab);
      this.DetailTabs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
      this.WorkoutsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))), ((int)(((byte)(230)))));
      this.WorkoutsTab.BackgroundImage = global::FitnessApp.Properties.Resources.workout_form_resized;
      this.WorkoutsTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.WorkoutsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.WorkoutsTab.Location = new System.Drawing.Point(4, 32);
      this.WorkoutsTab.Name = "WorkoutsTab";
      this.WorkoutsTab.Padding = new System.Windows.Forms.Padding(3);
      this.WorkoutsTab.Size = new System.Drawing.Size(795, 420);
      this.WorkoutsTab.TabIndex = 0;
      this.WorkoutsTab.Text = "Workouts";
      // 
      // CheatMealTab
      // 
      this.CheatMealTab.AutoScroll = true;
      this.CheatMealTab.BackColor = System.Drawing.Color.White;
      this.CheatMealTab.BackgroundImage = global::FitnessApp.Properties.Resources.edit_cheatmeals_resized;
      this.CheatMealTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.CheatMealTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CheatMealTab.Location = new System.Drawing.Point(4, 32);
      this.CheatMealTab.Name = "CheatMealTab";
      this.CheatMealTab.Padding = new System.Windows.Forms.Padding(3);
      this.CheatMealTab.Size = new System.Drawing.Size(795, 420);
      this.CheatMealTab.TabIndex = 1;
      this.CheatMealTab.Text = "Cheat Meals";
      // 
      // SummaryTab
      // 
      this.SummaryTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))), ((int)(((byte)(230)))));
      this.SummaryTab.Controls.Add(this.lblCalorieStatusMeasure);
      this.SummaryTab.Controls.Add(this.lblCalorieStatusValue);
      this.SummaryTab.Controls.Add(this.lblCalorieStatusLabel);
      this.SummaryTab.Controls.Add(this.lblCheatMealCalorieValue);
      this.SummaryTab.Controls.Add(this.lblCheatMealCalories);
      this.SummaryTab.Controls.Add(this.lblWorkoutCalorieValue);
      this.SummaryTab.Controls.Add(this.lblWorkoutCalories);
      this.SummaryTab.Location = new System.Drawing.Point(4, 32);
      this.SummaryTab.Name = "SummaryTab";
      this.SummaryTab.Padding = new System.Windows.Forms.Padding(3);
      this.SummaryTab.Size = new System.Drawing.Size(795, 420);
      this.SummaryTab.TabIndex = 2;
      this.SummaryTab.Text = "Summary";
      // 
      // lblWorkoutCalories
      // 
      this.lblWorkoutCalories.AutoSize = true;
      this.lblWorkoutCalories.ForeColor = System.Drawing.Color.Blue;
      this.lblWorkoutCalories.Location = new System.Drawing.Point(87, 77);
      this.lblWorkoutCalories.Name = "lblWorkoutCalories";
      this.lblWorkoutCalories.Size = new System.Drawing.Size(178, 23);
      this.lblWorkoutCalories.TabIndex = 0;
      this.lblWorkoutCalories.Text = "Workout Calories";
      // 
      // lblWorkoutCalorieValue
      // 
      this.lblWorkoutCalorieValue.AutoSize = true;
      this.lblWorkoutCalorieValue.ForeColor = System.Drawing.Color.Green;
      this.lblWorkoutCalorieValue.Location = new System.Drawing.Point(390, 77);
      this.lblWorkoutCalorieValue.Name = "lblWorkoutCalorieValue";
      this.lblWorkoutCalorieValue.Size = new System.Drawing.Size(69, 23);
      this.lblWorkoutCalorieValue.TabIndex = 1;
      this.lblWorkoutCalorieValue.Text = "label2";
      // 
      // lblCheatMealCalorieValue
      // 
      this.lblCheatMealCalorieValue.AutoSize = true;
      this.lblCheatMealCalorieValue.ForeColor = System.Drawing.Color.Red;
      this.lblCheatMealCalorieValue.Location = new System.Drawing.Point(390, 162);
      this.lblCheatMealCalorieValue.Name = "lblCheatMealCalorieValue";
      this.lblCheatMealCalorieValue.Size = new System.Drawing.Size(69, 23);
      this.lblCheatMealCalorieValue.TabIndex = 3;
      this.lblCheatMealCalorieValue.Text = "label3";
      // 
      // lblCheatMealCalories
      // 
      this.lblCheatMealCalories.AutoSize = true;
      this.lblCheatMealCalories.ForeColor = System.Drawing.Color.Blue;
      this.lblCheatMealCalories.Location = new System.Drawing.Point(87, 162);
      this.lblCheatMealCalories.Name = "lblCheatMealCalories";
      this.lblCheatMealCalories.Size = new System.Drawing.Size(205, 23);
      this.lblCheatMealCalories.TabIndex = 2;
      this.lblCheatMealCalories.Text = "Cheat Meal Calories";
      // 
      // lblCalorieStatusValue
      // 
      this.lblCalorieStatusValue.AutoSize = true;
      this.lblCalorieStatusValue.Location = new System.Drawing.Point(390, 250);
      this.lblCalorieStatusValue.Name = "lblCalorieStatusValue";
      this.lblCalorieStatusValue.Size = new System.Drawing.Size(69, 23);
      this.lblCalorieStatusValue.TabIndex = 5;
      this.lblCalorieStatusValue.Text = "label5";
      // 
      // lblCalorieStatusLabel
      // 
      this.lblCalorieStatusLabel.AutoSize = true;
      this.lblCalorieStatusLabel.ForeColor = System.Drawing.Color.Blue;
      this.lblCalorieStatusLabel.Location = new System.Drawing.Point(87, 250);
      this.lblCalorieStatusLabel.Name = "lblCalorieStatusLabel";
      this.lblCalorieStatusLabel.Size = new System.Drawing.Size(240, 23);
      this.lblCalorieStatusLabel.TabIndex = 4;
      this.lblCalorieStatusLabel.Text = "Calorie Surplus/Deficit?";
      // 
      // lblCalorieStatusMeasure
      // 
      this.lblCalorieStatusMeasure.AutoSize = true;
      this.lblCalorieStatusMeasure.Location = new System.Drawing.Point(528, 250);
      this.lblCalorieStatusMeasure.Name = "lblCalorieStatusMeasure";
      this.lblCalorieStatusMeasure.Size = new System.Drawing.Size(24, 23);
      this.lblCalorieStatusMeasure.TabIndex = 6;
      this.lblCalorieStatusMeasure.Text = "()";
      // 
      // ViewDailyDetail
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::FitnessApp.Properties.Resources.summary;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1061, 618);
      this.Controls.Add(this.DetailTabs);
      this.Controls.Add(this.lblDailyDetailsHeader);
      this.DoubleBuffered = true;
      this.Name = "ViewDailyDetail";
      this.Text = "ViewDailyDetail";
      this.DetailTabs.ResumeLayout(false);
      this.SummaryTab.ResumeLayout(false);
      this.SummaryTab.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblDailyDetailsHeader;
    private System.Windows.Forms.TabControl DetailTabs;
    private System.Windows.Forms.TabPage WorkoutsTab;
    private System.Windows.Forms.TabPage CheatMealTab;
    private System.Windows.Forms.TabPage SummaryTab;
    private System.Windows.Forms.Label lblCalorieStatusValue;
    private System.Windows.Forms.Label lblCalorieStatusLabel;
    private System.Windows.Forms.Label lblCheatMealCalorieValue;
    private System.Windows.Forms.Label lblCheatMealCalories;
    private System.Windows.Forms.Label lblWorkoutCalorieValue;
    private System.Windows.Forms.Label lblWorkoutCalories;
    private System.Windows.Forms.Label lblCalorieStatusMeasure;
  }
}