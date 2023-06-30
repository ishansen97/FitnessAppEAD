
namespace FitnessApp
{
  partial class ViewInfoForm
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
      this.pnlMain = new System.Windows.Forms.Panel();
      this.lblNoContentMessage = new System.Windows.Forms.Label();
      this.pnlSelections = new System.Windows.Forms.Panel();
      this.rdbCheatMeals = new System.Windows.Forms.RadioButton();
      this.rdbWorkouts = new System.Windows.Forms.RadioButton();
      this.lblViewOnly = new System.Windows.Forms.Label();
      this.lblHeader = new System.Windows.Forms.Label();
      this.btnBack = new System.Windows.Forms.Button();
      this.pnlMain.SuspendLayout();
      this.pnlSelections.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlMain
      // 
      this.pnlMain.AutoScroll = true;
      this.pnlMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.pnlMain.Controls.Add(this.lblNoContentMessage);
      this.pnlMain.Controls.Add(this.pnlSelections);
      this.pnlMain.Location = new System.Drawing.Point(80, 99);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new System.Drawing.Size(845, 464);
      this.pnlMain.TabIndex = 0;
      // 
      // lblNoContentMessage
      // 
      this.lblNoContentMessage.AutoSize = true;
      this.lblNoContentMessage.BackColor = System.Drawing.SystemColors.Control;
      this.lblNoContentMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNoContentMessage.Location = new System.Drawing.Point(177, 122);
      this.lblNoContentMessage.Name = "lblNoContentMessage";
      this.lblNoContentMessage.Size = new System.Drawing.Size(418, 55);
      this.lblNoContentMessage.TabIndex = 1;
      this.lblNoContentMessage.Text = "No Content Found";
      this.lblNoContentMessage.Visible = false;
      // 
      // pnlSelections
      // 
      this.pnlSelections.AutoScroll = true;
      this.pnlSelections.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.pnlSelections.Controls.Add(this.rdbCheatMeals);
      this.pnlSelections.Controls.Add(this.rdbWorkouts);
      this.pnlSelections.Controls.Add(this.lblViewOnly);
      this.pnlSelections.Location = new System.Drawing.Point(0, 0);
      this.pnlSelections.Name = "pnlSelections";
      this.pnlSelections.Size = new System.Drawing.Size(845, 80);
      this.pnlSelections.TabIndex = 0;
      // 
      // rdbCheatMeals
      // 
      this.rdbCheatMeals.AutoSize = true;
      this.rdbCheatMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbCheatMeals.Location = new System.Drawing.Point(550, 29);
      this.rdbCheatMeals.Name = "rdbCheatMeals";
      this.rdbCheatMeals.Size = new System.Drawing.Size(179, 33);
      this.rdbCheatMeals.TabIndex = 3;
      this.rdbCheatMeals.TabStop = true;
      this.rdbCheatMeals.Text = "Cheat Meals";
      this.rdbCheatMeals.UseVisualStyleBackColor = true;
      this.rdbCheatMeals.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdbCheatMeals_Clicked);
      // 
      // rdbWorkouts
      // 
      this.rdbWorkouts.AutoSize = true;
      this.rdbWorkouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbWorkouts.Location = new System.Drawing.Point(282, 31);
      this.rdbWorkouts.Name = "rdbWorkouts";
      this.rdbWorkouts.Size = new System.Drawing.Size(143, 33);
      this.rdbWorkouts.TabIndex = 2;
      this.rdbWorkouts.TabStop = true;
      this.rdbWorkouts.Text = "Workouts";
      this.rdbWorkouts.UseVisualStyleBackColor = true;
      this.rdbWorkouts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdbWorkout_Clicked);
      // 
      // lblViewOnly
      // 
      this.lblViewOnly.AutoSize = true;
      this.lblViewOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblViewOnly.Location = new System.Drawing.Point(55, 31);
      this.lblViewOnly.Name = "lblViewOnly";
      this.lblViewOnly.Size = new System.Drawing.Size(121, 29);
      this.lblViewOnly.TabIndex = 1;
      this.lblViewOnly.Text = "View Only";
      // 
      // lblHeader
      // 
      this.lblHeader.AutoSize = true;
      this.lblHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblHeader.Location = new System.Drawing.Point(247, 43);
      this.lblHeader.Name = "lblHeader";
      this.lblHeader.Size = new System.Drawing.Size(428, 38);
      this.lblHeader.TabIndex = 0;
      this.lblHeader.Text = "View Workouts/Cheat Meals";
      // 
      // btnBack
      // 
      this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBack.Location = new System.Drawing.Point(80, 582);
      this.btnBack.Name = "btnBack";
      this.btnBack.Size = new System.Drawing.Size(215, 41);
      this.btnBack.TabIndex = 4;
      this.btnBack.Text = "Back to Dashboard";
      this.btnBack.UseVisualStyleBackColor = true;
      this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
      // 
      // ViewInfoForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.ClientSize = new System.Drawing.Size(1012, 655);
      this.Controls.Add(this.btnBack);
      this.Controls.Add(this.lblHeader);
      this.Controls.Add(this.pnlMain);
      this.Name = "ViewInfoForm";
      this.Text = "View Workout";
      this.pnlMain.ResumeLayout(false);
      this.pnlMain.PerformLayout();
      this.pnlSelections.ResumeLayout(false);
      this.pnlSelections.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel pnlMain;
    private System.Windows.Forms.Panel pnlSelections;
    private System.Windows.Forms.RadioButton rdbCheatMeals;
    private System.Windows.Forms.RadioButton rdbWorkouts;
    private System.Windows.Forms.Label lblViewOnly;
    private System.Windows.Forms.Label lblHeader;
    private System.Windows.Forms.Label lblNoContentMessage;
    private System.Windows.Forms.Button btnBack;
  }
}