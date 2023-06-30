
namespace FitnessApp
{
  partial class Dashboard
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
      this.ReportsTab = new System.Windows.Forms.TabPage();
      this.PredictionsTab = new System.Windows.Forms.TabPage();
      this.flwPanel = new System.Windows.Forms.FlowLayoutPanel();
      this.lblWarningMessage = new System.Windows.Forms.Label();
      this.btnPredict = new System.Windows.Forms.Button();
      this.ProfileTab = new System.Windows.Forms.TabPage();
      this.txtUserName = new System.Windows.Forms.TextBox();
      this.txtWeight = new System.Windows.Forms.TextBox();
      this.txtHeight = new System.Windows.Forms.TextBox();
      this.txtAge = new System.Windows.Forms.TextBox();
      this.txtLastName = new System.Windows.Forms.TextBox();
      this.txtFirstName = new System.Windows.Forms.TextBox();
      this.lblUserName = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.lblWeight = new System.Windows.Forms.Label();
      this.lblHeight = new System.Windows.Forms.Label();
      this.lblAge = new System.Windows.Forms.Label();
      this.lblLastName = new System.Windows.Forms.Label();
      this.lblEditProfileHeader = new System.Windows.Forms.Label();
      this.lblProfile = new System.Windows.Forms.Label();
      this.HomeTab = new System.Windows.Forms.TabPage();
      this.pnlCheatMeals = new System.Windows.Forms.Panel();
      this.lnkAddCheatMeal = new System.Windows.Forms.LinkLabel();
      this.lblCheatMeals = new System.Windows.Forms.Label();
      this.pnlWorkouts = new System.Windows.Forms.Panel();
      this.lnkWorkoutDaysCount = new System.Windows.Forms.LinkLabel();
      this.lnkAddWorkout = new System.Windows.Forms.LinkLabel();
      this.lblWorkouts = new System.Windows.Forms.Label();
      this.Home = new System.Windows.Forms.TabControl();
      this.lnkCheatMealDays = new System.Windows.Forms.LinkLabel();
      this.PredictionsTab.SuspendLayout();
      this.flwPanel.SuspendLayout();
      this.ProfileTab.SuspendLayout();
      this.HomeTab.SuspendLayout();
      this.pnlCheatMeals.SuspendLayout();
      this.pnlWorkouts.SuspendLayout();
      this.Home.SuspendLayout();
      this.SuspendLayout();
      // 
      // ReportsTab
      // 
      this.ReportsTab.BackColor = System.Drawing.Color.White;
      this.ReportsTab.Location = new System.Drawing.Point(4, 32);
      this.ReportsTab.Name = "ReportsTab";
      this.ReportsTab.Padding = new System.Windows.Forms.Padding(3);
      this.ReportsTab.Size = new System.Drawing.Size(892, 544);
      this.ReportsTab.TabIndex = 3;
      this.ReportsTab.Text = "Reports";
      // 
      // PredictionsTab
      // 
      this.PredictionsTab.BackColor = System.Drawing.Color.White;
      this.PredictionsTab.Controls.Add(this.flwPanel);
      this.PredictionsTab.Controls.Add(this.btnPredict);
      this.PredictionsTab.Location = new System.Drawing.Point(4, 32);
      this.PredictionsTab.Name = "PredictionsTab";
      this.PredictionsTab.Padding = new System.Windows.Forms.Padding(3);
      this.PredictionsTab.Size = new System.Drawing.Size(892, 544);
      this.PredictionsTab.TabIndex = 2;
      this.PredictionsTab.Text = "Predictions";
      // 
      // flwPanel
      // 
      this.flwPanel.Controls.Add(this.lblWarningMessage);
      this.flwPanel.Location = new System.Drawing.Point(147, 66);
      this.flwPanel.Name = "flwPanel";
      this.flwPanel.Size = new System.Drawing.Size(544, 165);
      this.flwPanel.TabIndex = 1;
      // 
      // lblWarningMessage
      // 
      this.lblWarningMessage.AutoSize = true;
      this.lblWarningMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWarningMessage.ForeColor = System.Drawing.Color.Red;
      this.lblWarningMessage.Location = new System.Drawing.Point(3, 0);
      this.lblWarningMessage.Name = "lblWarningMessage";
      this.lblWarningMessage.Size = new System.Drawing.Size(504, 108);
      this.lblWarningMessage.TabIndex = 0;
      this.lblWarningMessage.Text = "You need to have atleast 5 workouts/cheat meals before making predictions";
      // 
      // btnPredict
      // 
      this.btnPredict.Location = new System.Drawing.Point(331, 264);
      this.btnPredict.Name = "btnPredict";
      this.btnPredict.Size = new System.Drawing.Size(154, 81);
      this.btnPredict.TabIndex = 0;
      this.btnPredict.Text = "Make Predictions";
      this.btnPredict.UseVisualStyleBackColor = true;
      // 
      // ProfileTab
      // 
      this.ProfileTab.BackColor = System.Drawing.Color.LightGray;
      this.ProfileTab.Controls.Add(this.txtUserName);
      this.ProfileTab.Controls.Add(this.txtWeight);
      this.ProfileTab.Controls.Add(this.txtHeight);
      this.ProfileTab.Controls.Add(this.txtAge);
      this.ProfileTab.Controls.Add(this.txtLastName);
      this.ProfileTab.Controls.Add(this.txtFirstName);
      this.ProfileTab.Controls.Add(this.lblUserName);
      this.ProfileTab.Controls.Add(this.btnSave);
      this.ProfileTab.Controls.Add(this.lblWeight);
      this.ProfileTab.Controls.Add(this.lblHeight);
      this.ProfileTab.Controls.Add(this.lblAge);
      this.ProfileTab.Controls.Add(this.lblLastName);
      this.ProfileTab.Controls.Add(this.lblEditProfileHeader);
      this.ProfileTab.Controls.Add(this.lblProfile);
      this.ProfileTab.Location = new System.Drawing.Point(4, 32);
      this.ProfileTab.Name = "ProfileTab";
      this.ProfileTab.Padding = new System.Windows.Forms.Padding(3);
      this.ProfileTab.Size = new System.Drawing.Size(892, 544);
      this.ProfileTab.TabIndex = 1;
      this.ProfileTab.Text = "Profile";
      // 
      // txtUserName
      // 
      this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUserName.Location = new System.Drawing.Point(313, 204);
      this.txtUserName.Name = "txtUserName";
      this.txtUserName.Size = new System.Drawing.Size(167, 30);
      this.txtUserName.TabIndex = 13;
      // 
      // txtWeight
      // 
      this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtWeight.Location = new System.Drawing.Point(313, 379);
      this.txtWeight.Name = "txtWeight";
      this.txtWeight.Size = new System.Drawing.Size(167, 30);
      this.txtWeight.TabIndex = 10;
      // 
      // txtHeight
      // 
      this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtHeight.Location = new System.Drawing.Point(313, 317);
      this.txtHeight.Name = "txtHeight";
      this.txtHeight.Size = new System.Drawing.Size(167, 30);
      this.txtHeight.TabIndex = 9;
      // 
      // txtAge
      // 
      this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtAge.Location = new System.Drawing.Point(313, 262);
      this.txtAge.Name = "txtAge";
      this.txtAge.Size = new System.Drawing.Size(167, 30);
      this.txtAge.TabIndex = 8;
      // 
      // txtLastName
      // 
      this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtLastName.Location = new System.Drawing.Point(313, 147);
      this.txtLastName.Name = "txtLastName";
      this.txtLastName.Size = new System.Drawing.Size(167, 30);
      this.txtLastName.TabIndex = 7;
      // 
      // txtFirstName
      // 
      this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtFirstName.Location = new System.Drawing.Point(313, 89);
      this.txtFirstName.Name = "txtFirstName";
      this.txtFirstName.Size = new System.Drawing.Size(167, 30);
      this.txtFirstName.TabIndex = 6;
      // 
      // lblUserName
      // 
      this.lblUserName.AutoSize = true;
      this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUserName.Location = new System.Drawing.Point(100, 204);
      this.lblUserName.Name = "lblUserName";
      this.lblUserName.Size = new System.Drawing.Size(103, 20);
      this.lblUserName.TabIndex = 12;
      this.lblUserName.Text = "User Name";
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(348, 459);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(92, 38);
      this.btnSave.TabIndex = 11;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      // 
      // lblWeight
      // 
      this.lblWeight.AutoSize = true;
      this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWeight.Location = new System.Drawing.Point(100, 389);
      this.lblWeight.Name = "lblWeight";
      this.lblWeight.Size = new System.Drawing.Size(67, 20);
      this.lblWeight.TabIndex = 5;
      this.lblWeight.Text = "Weight";
      // 
      // lblHeight
      // 
      this.lblHeight.AutoSize = true;
      this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblHeight.Location = new System.Drawing.Point(100, 327);
      this.lblHeight.Name = "lblHeight";
      this.lblHeight.Size = new System.Drawing.Size(64, 20);
      this.lblHeight.TabIndex = 4;
      this.lblHeight.Text = "Height";
      // 
      // lblAge
      // 
      this.lblAge.AutoSize = true;
      this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAge.Location = new System.Drawing.Point(100, 269);
      this.lblAge.Name = "lblAge";
      this.lblAge.Size = new System.Drawing.Size(41, 20);
      this.lblAge.TabIndex = 3;
      this.lblAge.Text = "Age";
      // 
      // lblLastName
      // 
      this.lblLastName.AutoSize = true;
      this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLastName.Location = new System.Drawing.Point(100, 147);
      this.lblLastName.Name = "lblLastName";
      this.lblLastName.Size = new System.Drawing.Size(100, 20);
      this.lblLastName.TabIndex = 2;
      this.lblLastName.Text = "Last Name";
      // 
      // lblEditProfileHeader
      // 
      this.lblEditProfileHeader.AutoSize = true;
      this.lblEditProfileHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEditProfileHeader.Location = new System.Drawing.Point(308, 19);
      this.lblEditProfileHeader.Name = "lblEditProfileHeader";
      this.lblEditProfileHeader.Size = new System.Drawing.Size(172, 25);
      this.lblEditProfileHeader.TabIndex = 1;
      this.lblEditProfileHeader.Text = "Edit Your Details";
      // 
      // lblProfile
      // 
      this.lblProfile.AutoSize = true;
      this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblProfile.Location = new System.Drawing.Point(100, 92);
      this.lblProfile.Name = "lblProfile";
      this.lblProfile.Size = new System.Drawing.Size(102, 20);
      this.lblProfile.TabIndex = 0;
      this.lblProfile.Text = "First Name";
      // 
      // HomeTab
      // 
      this.HomeTab.BackColor = System.Drawing.Color.White;
      this.HomeTab.Controls.Add(this.pnlCheatMeals);
      this.HomeTab.Controls.Add(this.pnlWorkouts);
      this.HomeTab.Location = new System.Drawing.Point(4, 32);
      this.HomeTab.Name = "HomeTab";
      this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
      this.HomeTab.Size = new System.Drawing.Size(892, 544);
      this.HomeTab.TabIndex = 0;
      this.HomeTab.Text = "Home";
      // 
      // pnlCheatMeals
      // 
      this.pnlCheatMeals.BackColor = System.Drawing.Color.Coral;
      this.pnlCheatMeals.Controls.Add(this.lnkCheatMealDays);
      this.pnlCheatMeals.Controls.Add(this.lnkAddCheatMeal);
      this.pnlCheatMeals.Controls.Add(this.lblCheatMeals);
      this.pnlCheatMeals.Location = new System.Drawing.Point(528, 22);
      this.pnlCheatMeals.Name = "pnlCheatMeals";
      this.pnlCheatMeals.Size = new System.Drawing.Size(293, 236);
      this.pnlCheatMeals.TabIndex = 1;
      // 
      // lnkAddCheatMeal
      // 
      this.lnkAddCheatMeal.AutoSize = true;
      this.lnkAddCheatMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lnkAddCheatMeal.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
      this.lnkAddCheatMeal.LinkColor = System.Drawing.Color.White;
      this.lnkAddCheatMeal.Location = new System.Drawing.Point(71, 185);
      this.lnkAddCheatMeal.Name = "lnkAddCheatMeal";
      this.lnkAddCheatMeal.Size = new System.Drawing.Size(154, 25);
      this.lnkAddCheatMeal.TabIndex = 4;
      this.lnkAddCheatMeal.TabStop = true;
      this.lnkAddCheatMeal.Text = "Add Cheat Meal";
      this.lnkAddCheatMeal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddCheatMeal_LinkClicked);
      // 
      // lblCheatMeals
      // 
      this.lblCheatMeals.AutoSize = true;
      this.lblCheatMeals.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCheatMeals.Location = new System.Drawing.Point(27, 11);
      this.lblCheatMeals.Name = "lblCheatMeals";
      this.lblCheatMeals.Size = new System.Drawing.Size(244, 32);
      this.lblCheatMeals.TabIndex = 1;
      this.lblCheatMeals.Text = "Cheat Meal Days";
      // 
      // pnlWorkouts
      // 
      this.pnlWorkouts.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.pnlWorkouts.Controls.Add(this.lnkWorkoutDaysCount);
      this.pnlWorkouts.Controls.Add(this.lnkAddWorkout);
      this.pnlWorkouts.Controls.Add(this.lblWorkouts);
      this.pnlWorkouts.Location = new System.Drawing.Point(27, 22);
      this.pnlWorkouts.Name = "pnlWorkouts";
      this.pnlWorkouts.Size = new System.Drawing.Size(293, 236);
      this.pnlWorkouts.TabIndex = 0;
      // 
      // lnkWorkoutDaysCount
      // 
      this.lnkWorkoutDaysCount.AutoSize = true;
      this.lnkWorkoutDaysCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lnkWorkoutDaysCount.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
      this.lnkWorkoutDaysCount.Location = new System.Drawing.Point(111, 84);
      this.lnkWorkoutDaysCount.Name = "lnkWorkoutDaysCount";
      this.lnkWorkoutDaysCount.Size = new System.Drawing.Size(63, 69);
      this.lnkWorkoutDaysCount.TabIndex = 4;
      this.lnkWorkoutDaysCount.TabStop = true;
      this.lnkWorkoutDaysCount.Text = "1";
      this.lnkWorkoutDaysCount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWorkoutDaysCount_LinkClicked);
      // 
      // lnkAddWorkout
      // 
      this.lnkAddWorkout.AutoSize = true;
      this.lnkAddWorkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lnkAddWorkout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
      this.lnkAddWorkout.LinkColor = System.Drawing.Color.White;
      this.lnkAddWorkout.Location = new System.Drawing.Point(85, 185);
      this.lnkAddWorkout.Name = "lnkAddWorkout";
      this.lnkAddWorkout.Size = new System.Drawing.Size(127, 25);
      this.lnkAddWorkout.TabIndex = 3;
      this.lnkAddWorkout.TabStop = true;
      this.lnkAddWorkout.Text = "Add Workout";
      this.lnkAddWorkout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddWorkout_LinkClicked);
      // 
      // lblWorkouts
      // 
      this.lblWorkouts.AutoSize = true;
      this.lblWorkouts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWorkouts.Location = new System.Drawing.Point(42, 11);
      this.lblWorkouts.Name = "lblWorkouts";
      this.lblWorkouts.Size = new System.Drawing.Size(205, 32);
      this.lblWorkouts.TabIndex = 0;
      this.lblWorkouts.Text = "Workout Days";
      // 
      // Home
      // 
      this.Home.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
      this.Home.Controls.Add(this.HomeTab);
      this.Home.Controls.Add(this.ProfileTab);
      this.Home.Controls.Add(this.PredictionsTab);
      this.Home.Controls.Add(this.ReportsTab);
      this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Home.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Home.Location = new System.Drawing.Point(54, 38);
      this.Home.Name = "Home";
      this.Home.SelectedIndex = 0;
      this.Home.Size = new System.Drawing.Size(900, 580);
      this.Home.TabIndex = 0;
      this.Home.Selected += new System.Windows.Forms.TabControlEventHandler(this.OnTabChanged);
      // 
      // lnkCheatMealDays
      // 
      this.lnkCheatMealDays.AutoSize = true;
      this.lnkCheatMealDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lnkCheatMealDays.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
      this.lnkCheatMealDays.Location = new System.Drawing.Point(117, 84);
      this.lnkCheatMealDays.Name = "lnkCheatMealDays";
      this.lnkCheatMealDays.Size = new System.Drawing.Size(64, 69);
      this.lnkCheatMealDays.TabIndex = 5;
      this.lnkCheatMealDays.TabStop = true;
      this.lnkCheatMealDays.Text = "0";
      this.lnkCheatMealDays.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCheatMealDays_LinkClicked);
      // 
      // Dashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1021, 654);
      this.Controls.Add(this.Home);
      this.Name = "Dashboard";
      this.Text = "Hello <user>";
      this.PredictionsTab.ResumeLayout(false);
      this.flwPanel.ResumeLayout(false);
      this.flwPanel.PerformLayout();
      this.ProfileTab.ResumeLayout(false);
      this.ProfileTab.PerformLayout();
      this.HomeTab.ResumeLayout(false);
      this.pnlCheatMeals.ResumeLayout(false);
      this.pnlCheatMeals.PerformLayout();
      this.pnlWorkouts.ResumeLayout(false);
      this.pnlWorkouts.PerformLayout();
      this.Home.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabPage ReportsTab;
    private System.Windows.Forms.TabPage PredictionsTab;
    private System.Windows.Forms.TabPage ProfileTab;
    private System.Windows.Forms.TextBox txtUserName;
    private System.Windows.Forms.TextBox txtWeight;
    private System.Windows.Forms.TextBox txtHeight;
    private System.Windows.Forms.TextBox txtAge;
    private System.Windows.Forms.TextBox txtLastName;
    private System.Windows.Forms.TextBox txtFirstName;
    private System.Windows.Forms.Label lblUserName;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Label lblWeight;
    private System.Windows.Forms.Label lblHeight;
    private System.Windows.Forms.Label lblAge;
    private System.Windows.Forms.Label lblLastName;
    private System.Windows.Forms.Label lblEditProfileHeader;
    private System.Windows.Forms.Label lblProfile;
    private System.Windows.Forms.TabPage HomeTab;
    private System.Windows.Forms.TabControl Home;
    private System.Windows.Forms.Panel pnlCheatMeals;
    private System.Windows.Forms.Label lblCheatMeals;
    private System.Windows.Forms.Panel pnlWorkouts;
    private System.Windows.Forms.Label lblWorkouts;
    private System.Windows.Forms.Button btnPredict;
    private System.Windows.Forms.FlowLayoutPanel flwPanel;
    private System.Windows.Forms.Label lblWarningMessage;
    private System.Windows.Forms.LinkLabel lnkAddCheatMeal;
    private System.Windows.Forms.LinkLabel lnkAddWorkout;
    private System.Windows.Forms.LinkLabel lnkWorkoutDaysCount;
    private System.Windows.Forms.LinkLabel lnkCheatMealDays;
  }
}