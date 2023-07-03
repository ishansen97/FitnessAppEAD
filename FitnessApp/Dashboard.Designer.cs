
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
      this.components = new System.ComponentModel.Container();
      this.ReportsTab = new System.Windows.Forms.TabPage();
      this.PredictionsTab = new System.Windows.Forms.TabPage();
      this.pnlPredictionMain = new System.Windows.Forms.Panel();
      this.pnlPredictionView = new System.Windows.Forms.Panel();
      this.lblPredictionMessageValue = new System.Windows.Forms.Label();
      this.lblPredictionMessage = new System.Windows.Forms.Label();
      this.lblPredictedWeightStatus = new System.Windows.Forms.Label();
      this.lblPredictedWeightValue = new System.Windows.Forms.Label();
      this.lblPredictedWeight = new System.Windows.Forms.Label();
      this.lblPredictedStatusValue = new System.Windows.Forms.Label();
      this.lblPredictedStatus = new System.Windows.Forms.Label();
      this.lblPredictionViewLabel = new System.Windows.Forms.Label();
      this.btnPredict = new System.Windows.Forms.Button();
      this.dtPredictionDate = new System.Windows.Forms.DateTimePicker();
      this.lblSelectDate = new System.Windows.Forms.Label();
      this.lblPredictionHeader = new System.Windows.Forms.Label();
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
      this.lnkCheatMealDays = new System.Windows.Forms.LinkLabel();
      this.lnkAddCheatMeal = new System.Windows.Forms.LinkLabel();
      this.lblCheatMeals = new System.Windows.Forms.Label();
      this.pnlWorkouts = new System.Windows.Forms.Panel();
      this.lnkWorkoutDaysCount = new System.Windows.Forms.LinkLabel();
      this.lnkAddWorkout = new System.Windows.Forms.LinkLabel();
      this.lblWorkouts = new System.Windows.Forms.Label();
      this.Home = new System.Windows.Forms.TabControl();
      this.WeeklyView = new System.Windows.Forms.TabPage();
      this.pnlWeeklyContent = new System.Windows.Forms.Panel();
      this.pnlDailyPanelLists = new System.Windows.Forms.Panel();
      this.lblWeeklyContentHeader = new System.Windows.Forms.Label();
      this.pnlMonthWeek = new System.Windows.Forms.Panel();
      this.pbLeftArrow = new System.Windows.Forms.PictureBox();
      this.pbRightArrow = new System.Windows.Forms.PictureBox();
      this.lblWeek = new System.Windows.Forms.Label();
      this.pbCalendarIcon = new System.Windows.Forms.PictureBox();
      this.lblWeeklyViewHeader = new System.Windows.Forms.Label();
      this.pnlPredictionDetails = new System.Windows.Forms.Panel();
      this.ProfileErrorHandler = new System.Windows.Forms.ErrorProvider(this.components);
      this.PredictionsTab.SuspendLayout();
      this.pnlPredictionMain.SuspendLayout();
      this.pnlPredictionView.SuspendLayout();
      this.ProfileTab.SuspendLayout();
      this.HomeTab.SuspendLayout();
      this.pnlCheatMeals.SuspendLayout();
      this.pnlWorkouts.SuspendLayout();
      this.Home.SuspendLayout();
      this.WeeklyView.SuspendLayout();
      this.pnlWeeklyContent.SuspendLayout();
      this.pnlMonthWeek.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbLeftArrow)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbRightArrow)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbCalendarIcon)).BeginInit();
      this.pnlPredictionDetails.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ProfileErrorHandler)).BeginInit();
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
      this.PredictionsTab.Controls.Add(this.pnlPredictionMain);
      this.PredictionsTab.Controls.Add(this.lblPredictionHeader);
      this.PredictionsTab.Location = new System.Drawing.Point(4, 32);
      this.PredictionsTab.Name = "PredictionsTab";
      this.PredictionsTab.Padding = new System.Windows.Forms.Padding(3);
      this.PredictionsTab.Size = new System.Drawing.Size(892, 544);
      this.PredictionsTab.TabIndex = 2;
      this.PredictionsTab.Text = "Predictions";
      // 
      // pnlPredictionMain
      // 
      this.pnlPredictionMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.pnlPredictionMain.Controls.Add(this.pnlPredictionView);
      this.pnlPredictionMain.Controls.Add(this.btnPredict);
      this.pnlPredictionMain.Controls.Add(this.dtPredictionDate);
      this.pnlPredictionMain.Controls.Add(this.lblSelectDate);
      this.pnlPredictionMain.Location = new System.Drawing.Point(49, 55);
      this.pnlPredictionMain.Name = "pnlPredictionMain";
      this.pnlPredictionMain.Size = new System.Drawing.Size(794, 467);
      this.pnlPredictionMain.TabIndex = 3;
      // 
      // pnlPredictionView
      // 
      this.pnlPredictionView.Controls.Add(this.pnlPredictionDetails);
      this.pnlPredictionView.Controls.Add(this.lblPredictionViewLabel);
      this.pnlPredictionView.Location = new System.Drawing.Point(26, 57);
      this.pnlPredictionView.Name = "pnlPredictionView";
      this.pnlPredictionView.Size = new System.Drawing.Size(713, 368);
      this.pnlPredictionView.TabIndex = 3;
      // 
      // lblPredictionMessageValue
      // 
      this.lblPredictionMessageValue.AutoSize = true;
      this.lblPredictionMessageValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPredictionMessageValue.Location = new System.Drawing.Point(287, 149);
      this.lblPredictionMessageValue.Name = "lblPredictionMessageValue";
      this.lblPredictionMessageValue.Size = new System.Drawing.Size(74, 25);
      this.lblPredictionMessageValue.TabIndex = 7;
      this.lblPredictionMessageValue.Text = "Status";
      // 
      // lblPredictionMessage
      // 
      this.lblPredictionMessage.AutoSize = true;
      this.lblPredictionMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPredictionMessage.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.lblPredictionMessage.Location = new System.Drawing.Point(16, 149);
      this.lblPredictionMessage.Name = "lblPredictionMessage";
      this.lblPredictionMessage.Size = new System.Drawing.Size(100, 25);
      this.lblPredictionMessage.TabIndex = 6;
      this.lblPredictionMessage.Text = "Message";
      // 
      // lblPredictedWeightStatus
      // 
      this.lblPredictedWeightStatus.AutoSize = true;
      this.lblPredictedWeightStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPredictedWeightStatus.Location = new System.Drawing.Point(411, 22);
      this.lblPredictedWeightStatus.Name = "lblPredictedWeightStatus";
      this.lblPredictedWeightStatus.Size = new System.Drawing.Size(74, 25);
      this.lblPredictedWeightStatus.TabIndex = 5;
      this.lblPredictedWeightStatus.Text = "Status";
      // 
      // lblPredictedWeightValue
      // 
      this.lblPredictedWeightValue.AutoSize = true;
      this.lblPredictedWeightValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPredictedWeightValue.Location = new System.Drawing.Point(287, 22);
      this.lblPredictedWeightValue.Name = "lblPredictedWeightValue";
      this.lblPredictedWeightValue.Size = new System.Drawing.Size(74, 25);
      this.lblPredictedWeightValue.TabIndex = 4;
      this.lblPredictedWeightValue.Text = "Status";
      // 
      // lblPredictedWeight
      // 
      this.lblPredictedWeight.AutoSize = true;
      this.lblPredictedWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPredictedWeight.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.lblPredictedWeight.Location = new System.Drawing.Point(16, 22);
      this.lblPredictedWeight.Name = "lblPredictedWeight";
      this.lblPredictedWeight.Size = new System.Drawing.Size(246, 25);
      this.lblPredictedWeight.TabIndex = 3;
      this.lblPredictedWeight.Text = "Predicted Weight/Status";
      // 
      // lblPredictedStatusValue
      // 
      this.lblPredictedStatusValue.AutoSize = true;
      this.lblPredictedStatusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPredictedStatusValue.Location = new System.Drawing.Point(287, 84);
      this.lblPredictedStatusValue.Name = "lblPredictedStatusValue";
      this.lblPredictedStatusValue.Size = new System.Drawing.Size(74, 25);
      this.lblPredictedStatusValue.TabIndex = 2;
      this.lblPredictedStatusValue.Text = "Status";
      // 
      // lblPredictedStatus
      // 
      this.lblPredictedStatus.AutoSize = true;
      this.lblPredictedStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPredictedStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.lblPredictedStatus.Location = new System.Drawing.Point(16, 84);
      this.lblPredictedStatus.Name = "lblPredictedStatus";
      this.lblPredictedStatus.Size = new System.Drawing.Size(74, 25);
      this.lblPredictedStatus.TabIndex = 1;
      this.lblPredictedStatus.Text = "Status";
      // 
      // lblPredictionViewLabel
      // 
      this.lblPredictionViewLabel.AutoSize = true;
      this.lblPredictionViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPredictionViewLabel.ForeColor = System.Drawing.Color.Red;
      this.lblPredictionViewLabel.Location = new System.Drawing.Point(187, 16);
      this.lblPredictionViewLabel.Name = "lblPredictionViewLabel";
      this.lblPredictionViewLabel.Size = new System.Drawing.Size(329, 20);
      this.lblPredictionViewLabel.TabIndex = 0;
      this.lblPredictionViewLabel.Text = "Please add atleast 3 workouts/cheat meals";
      // 
      // btnPredict
      // 
      this.btnPredict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPredict.Location = new System.Drawing.Point(508, 15);
      this.btnPredict.Name = "btnPredict";
      this.btnPredict.Size = new System.Drawing.Size(104, 34);
      this.btnPredict.TabIndex = 2;
      this.btnPredict.Text = "Predict";
      this.btnPredict.UseVisualStyleBackColor = true;
      this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
      // 
      // dtPredictionDate
      // 
      this.dtPredictionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtPredictionDate.Location = new System.Drawing.Point(217, 19);
      this.dtPredictionDate.Name = "dtPredictionDate";
      this.dtPredictionDate.Size = new System.Drawing.Size(200, 27);
      this.dtPredictionDate.TabIndex = 1;
      // 
      // lblSelectDate
      // 
      this.lblSelectDate.AutoSize = true;
      this.lblSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSelectDate.Location = new System.Drawing.Point(28, 19);
      this.lblSelectDate.Name = "lblSelectDate";
      this.lblSelectDate.Size = new System.Drawing.Size(124, 25);
      this.lblSelectDate.TabIndex = 0;
      this.lblSelectDate.Text = "Select Date";
      // 
      // lblPredictionHeader
      // 
      this.lblPredictionHeader.AutoSize = true;
      this.lblPredictionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPredictionHeader.Location = new System.Drawing.Point(250, 23);
      this.lblPredictionHeader.Name = "lblPredictionHeader";
      this.lblPredictionHeader.Size = new System.Drawing.Size(341, 29);
      this.lblPredictionHeader.TabIndex = 2;
      this.lblPredictionHeader.Text = "Make Your Predictions Here";
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
      this.txtWeight.Validating += new System.ComponentModel.CancelEventHandler(this.doubleField_Validating);
      // 
      // txtHeight
      // 
      this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtHeight.Location = new System.Drawing.Point(313, 317);
      this.txtHeight.Name = "txtHeight";
      this.txtHeight.Size = new System.Drawing.Size(167, 30);
      this.txtHeight.TabIndex = 9;
      this.txtHeight.Validating += new System.ComponentModel.CancelEventHandler(this.numberField_Validating);
      // 
      // txtAge
      // 
      this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtAge.Location = new System.Drawing.Point(313, 262);
      this.txtAge.Name = "txtAge";
      this.txtAge.Size = new System.Drawing.Size(167, 30);
      this.txtAge.TabIndex = 8;
      this.txtAge.Validating += new System.ComponentModel.CancelEventHandler(this.numberField_Validating);
      // 
      // txtLastName
      // 
      this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtLastName.Location = new System.Drawing.Point(313, 147);
      this.txtLastName.Name = "txtLastName";
      this.txtLastName.Size = new System.Drawing.Size(167, 30);
      this.txtLastName.TabIndex = 7;
      this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtField_Validating);
      // 
      // txtFirstName
      // 
      this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtFirstName.Location = new System.Drawing.Point(313, 89);
      this.txtFirstName.Name = "txtFirstName";
      this.txtFirstName.Size = new System.Drawing.Size(167, 30);
      this.txtFirstName.TabIndex = 6;
      this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtField_Validating);
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
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
      this.Home.Controls.Add(this.WeeklyView);
      this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Home.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Home.Location = new System.Drawing.Point(54, 38);
      this.Home.Name = "Home";
      this.Home.SelectedIndex = 0;
      this.Home.Size = new System.Drawing.Size(900, 580);
      this.Home.TabIndex = 0;
      this.Home.Selected += new System.Windows.Forms.TabControlEventHandler(this.OnTabChanged);
      // 
      // WeeklyView
      // 
      this.WeeklyView.BackColor = System.Drawing.Color.White;
      this.WeeklyView.Controls.Add(this.pnlWeeklyContent);
      this.WeeklyView.Controls.Add(this.pnlMonthWeek);
      this.WeeklyView.Controls.Add(this.pbCalendarIcon);
      this.WeeklyView.Controls.Add(this.lblWeeklyViewHeader);
      this.WeeklyView.Location = new System.Drawing.Point(4, 32);
      this.WeeklyView.Name = "WeeklyView";
      this.WeeklyView.Padding = new System.Windows.Forms.Padding(3);
      this.WeeklyView.Size = new System.Drawing.Size(892, 544);
      this.WeeklyView.TabIndex = 4;
      this.WeeklyView.Text = "Weekly View";
      // 
      // pnlWeeklyContent
      // 
      this.pnlWeeklyContent.AutoScroll = true;
      this.pnlWeeklyContent.Controls.Add(this.pnlDailyPanelLists);
      this.pnlWeeklyContent.Controls.Add(this.lblWeeklyContentHeader);
      this.pnlWeeklyContent.Location = new System.Drawing.Point(76, 164);
      this.pnlWeeklyContent.Name = "pnlWeeklyContent";
      this.pnlWeeklyContent.Size = new System.Drawing.Size(745, 362);
      this.pnlWeeklyContent.TabIndex = 4;
      // 
      // pnlDailyPanelLists
      // 
      this.pnlDailyPanelLists.AutoScroll = true;
      this.pnlDailyPanelLists.Location = new System.Drawing.Point(1, 35);
      this.pnlDailyPanelLists.Name = "pnlDailyPanelLists";
      this.pnlDailyPanelLists.Size = new System.Drawing.Size(743, 326);
      this.pnlDailyPanelLists.TabIndex = 4;
      // 
      // lblWeeklyContentHeader
      // 
      this.lblWeeklyContentHeader.AutoSize = true;
      this.lblWeeklyContentHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWeeklyContentHeader.ForeColor = System.Drawing.SystemColors.ActiveBorder;
      this.lblWeeklyContentHeader.Location = new System.Drawing.Point(261, 10);
      this.lblWeeklyContentHeader.Name = "lblWeeklyContentHeader";
      this.lblWeeklyContentHeader.Size = new System.Drawing.Size(225, 25);
      this.lblWeeklyContentHeader.TabIndex = 3;
      this.lblWeeklyContentHeader.Text = "No weekly content found";
      this.lblWeeklyContentHeader.Visible = false;
      // 
      // pnlMonthWeek
      // 
      this.pnlMonthWeek.BackColor = System.Drawing.Color.Silver;
      this.pnlMonthWeek.Controls.Add(this.pbLeftArrow);
      this.pnlMonthWeek.Controls.Add(this.pbRightArrow);
      this.pnlMonthWeek.Controls.Add(this.lblWeek);
      this.pnlMonthWeek.ForeColor = System.Drawing.SystemColors.Control;
      this.pnlMonthWeek.Location = new System.Drawing.Point(227, 78);
      this.pnlMonthWeek.Name = "pnlMonthWeek";
      this.pnlMonthWeek.Size = new System.Drawing.Size(441, 69);
      this.pnlMonthWeek.TabIndex = 2;
      // 
      // pbLeftArrow
      // 
      this.pbLeftArrow.Image = global::FitnessApp.Properties.Resources.left_arrow_24;
      this.pbLeftArrow.Location = new System.Drawing.Point(28, 19);
      this.pbLeftArrow.Name = "pbLeftArrow";
      this.pbLeftArrow.Size = new System.Drawing.Size(29, 30);
      this.pbLeftArrow.TabIndex = 3;
      this.pbLeftArrow.TabStop = false;
      this.pbLeftArrow.Click += new System.EventHandler(this.pbLeftArrow_Click);
      // 
      // pbRightArrow
      // 
      this.pbRightArrow.Image = global::FitnessApp.Properties.Resources.right_arrow_24;
      this.pbRightArrow.Location = new System.Drawing.Point(389, 19);
      this.pbRightArrow.Name = "pbRightArrow";
      this.pbRightArrow.Size = new System.Drawing.Size(27, 30);
      this.pbRightArrow.TabIndex = 4;
      this.pbRightArrow.TabStop = false;
      this.pbRightArrow.Click += new System.EventHandler(this.pbRightArrow_Click);
      // 
      // lblWeek
      // 
      this.lblWeek.AutoSize = true;
      this.lblWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWeek.ForeColor = System.Drawing.SystemColors.Highlight;
      this.lblWeek.Location = new System.Drawing.Point(140, 19);
      this.lblWeek.Name = "lblWeek";
      this.lblWeek.Size = new System.Drawing.Size(63, 24);
      this.lblWeek.TabIndex = 0;
      this.lblWeek.Text = "Week";
      // 
      // pbCalendarIcon
      // 
      this.pbCalendarIcon.Image = global::FitnessApp.Properties.Resources.calendar_32;
      this.pbCalendarIcon.Location = new System.Drawing.Point(616, 27);
      this.pbCalendarIcon.Name = "pbCalendarIcon";
      this.pbCalendarIcon.Size = new System.Drawing.Size(34, 30);
      this.pbCalendarIcon.TabIndex = 1;
      this.pbCalendarIcon.TabStop = false;
      // 
      // lblWeeklyViewHeader
      // 
      this.lblWeeklyViewHeader.AutoSize = true;
      this.lblWeeklyViewHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWeeklyViewHeader.Location = new System.Drawing.Point(242, 28);
      this.lblWeeklyViewHeader.Name = "lblWeeklyViewHeader";
      this.lblWeeklyViewHeader.Size = new System.Drawing.Size(349, 29);
      this.lblWeeklyViewHeader.TabIndex = 0;
      this.lblWeeklyViewHeader.Text = "Get Your Weekly Views Here";
      // 
      // pnlPredictionDetails
      // 
      this.pnlPredictionDetails.Controls.Add(this.lblPredictionMessageValue);
      this.pnlPredictionDetails.Controls.Add(this.lblPredictionMessage);
      this.pnlPredictionDetails.Controls.Add(this.lblPredictedWeightStatus);
      this.pnlPredictionDetails.Controls.Add(this.lblPredictedWeightValue);
      this.pnlPredictionDetails.Controls.Add(this.lblPredictedWeight);
      this.pnlPredictionDetails.Controls.Add(this.lblPredictedStatusValue);
      this.pnlPredictionDetails.Controls.Add(this.lblPredictedStatus);
      this.pnlPredictionDetails.Location = new System.Drawing.Point(8, 45);
      this.pnlPredictionDetails.Name = "pnlPredictionDetails";
      this.pnlPredictionDetails.Size = new System.Drawing.Size(694, 322);
      this.pnlPredictionDetails.TabIndex = 8;
      this.pnlPredictionDetails.Visible = false;
      // 
      // ProfileErrorHandler
      // 
      this.ProfileErrorHandler.ContainerControl = this;
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
      this.PredictionsTab.PerformLayout();
      this.pnlPredictionMain.ResumeLayout(false);
      this.pnlPredictionMain.PerformLayout();
      this.pnlPredictionView.ResumeLayout(false);
      this.pnlPredictionView.PerformLayout();
      this.ProfileTab.ResumeLayout(false);
      this.ProfileTab.PerformLayout();
      this.HomeTab.ResumeLayout(false);
      this.pnlCheatMeals.ResumeLayout(false);
      this.pnlCheatMeals.PerformLayout();
      this.pnlWorkouts.ResumeLayout(false);
      this.pnlWorkouts.PerformLayout();
      this.Home.ResumeLayout(false);
      this.WeeklyView.ResumeLayout(false);
      this.WeeklyView.PerformLayout();
      this.pnlWeeklyContent.ResumeLayout(false);
      this.pnlWeeklyContent.PerformLayout();
      this.pnlMonthWeek.ResumeLayout(false);
      this.pnlMonthWeek.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbLeftArrow)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbRightArrow)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbCalendarIcon)).EndInit();
      this.pnlPredictionDetails.ResumeLayout(false);
      this.pnlPredictionDetails.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ProfileErrorHandler)).EndInit();
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
    private System.Windows.Forms.LinkLabel lnkAddCheatMeal;
    private System.Windows.Forms.LinkLabel lnkAddWorkout;
    private System.Windows.Forms.LinkLabel lnkWorkoutDaysCount;
    private System.Windows.Forms.LinkLabel lnkCheatMealDays;
    private System.Windows.Forms.Panel pnlPredictionMain;
    private System.Windows.Forms.Panel pnlPredictionView;
    private System.Windows.Forms.Label lblPredictionViewLabel;
    private System.Windows.Forms.Button btnPredict;
    private System.Windows.Forms.DateTimePicker dtPredictionDate;
    private System.Windows.Forms.Label lblSelectDate;
    private System.Windows.Forms.Label lblPredictionHeader;
    private System.Windows.Forms.Label lblPredictedWeightValue;
    private System.Windows.Forms.Label lblPredictedWeight;
    private System.Windows.Forms.Label lblPredictedStatusValue;
    private System.Windows.Forms.Label lblPredictedStatus;
    private System.Windows.Forms.Label lblPredictedWeightStatus;
    private System.Windows.Forms.Label lblPredictionMessageValue;
    private System.Windows.Forms.Label lblPredictionMessage;
    private System.Windows.Forms.TabPage WeeklyView;
    private System.Windows.Forms.Label lblWeeklyViewHeader;
    private System.Windows.Forms.PictureBox pbCalendarIcon;
    private System.Windows.Forms.Panel pnlMonthWeek;
    private System.Windows.Forms.Label lblWeek;
    private System.Windows.Forms.PictureBox pbLeftArrow;
    private System.Windows.Forms.PictureBox pbRightArrow;
    private System.Windows.Forms.Label lblWeeklyContentHeader;
    private System.Windows.Forms.Panel pnlWeeklyContent;
    private System.Windows.Forms.Panel pnlDailyPanelLists;
    private System.Windows.Forms.Panel pnlPredictionDetails;
    private System.Windows.Forms.ErrorProvider ProfileErrorHandler;
  }
}