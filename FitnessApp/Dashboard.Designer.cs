
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
      this.Home = new System.Windows.Forms.TabControl();
      this.HomeTab = new System.Windows.Forms.TabPage();
      this.lblHome = new System.Windows.Forms.Label();
      this.ProfileTab = new System.Windows.Forms.TabPage();
      this.btnSave = new System.Windows.Forms.Button();
      this.txtWeight = new System.Windows.Forms.TextBox();
      this.txtHeight = new System.Windows.Forms.TextBox();
      this.txtAge = new System.Windows.Forms.TextBox();
      this.txtLastName = new System.Windows.Forms.TextBox();
      this.txtFirstName = new System.Windows.Forms.TextBox();
      this.lblWeight = new System.Windows.Forms.Label();
      this.lblHeight = new System.Windows.Forms.Label();
      this.lblAge = new System.Windows.Forms.Label();
      this.lblLastName = new System.Windows.Forms.Label();
      this.lblEditProfileHeader = new System.Windows.Forms.Label();
      this.lblProfile = new System.Windows.Forms.Label();
      this.PredictionsTab = new System.Windows.Forms.TabPage();
      this.ReportsTab = new System.Windows.Forms.TabPage();
      this.Home.SuspendLayout();
      this.HomeTab.SuspendLayout();
      this.ProfileTab.SuspendLayout();
      this.SuspendLayout();
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
      this.Home.Size = new System.Drawing.Size(804, 481);
      this.Home.TabIndex = 0;
      // 
      // HomeTab
      // 
      this.HomeTab.BackColor = System.Drawing.Color.White;
      this.HomeTab.Controls.Add(this.lblHome);
      this.HomeTab.Location = new System.Drawing.Point(4, 32);
      this.HomeTab.Name = "HomeTab";
      this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
      this.HomeTab.Size = new System.Drawing.Size(796, 445);
      this.HomeTab.TabIndex = 0;
      this.HomeTab.Text = "Home";
      // 
      // lblHome
      // 
      this.lblHome.AutoSize = true;
      this.lblHome.Location = new System.Drawing.Point(91, 63);
      this.lblHome.Name = "lblHome";
      this.lblHome.Size = new System.Drawing.Size(109, 20);
      this.lblHome.TabIndex = 0;
      this.lblHome.Text = "This is Home";
      // 
      // ProfileTab
      // 
      this.ProfileTab.BackColor = System.Drawing.Color.LightGray;
      this.ProfileTab.Controls.Add(this.btnSave);
      this.ProfileTab.Controls.Add(this.txtWeight);
      this.ProfileTab.Controls.Add(this.txtHeight);
      this.ProfileTab.Controls.Add(this.txtAge);
      this.ProfileTab.Controls.Add(this.txtLastName);
      this.ProfileTab.Controls.Add(this.txtFirstName);
      this.ProfileTab.Controls.Add(this.lblWeight);
      this.ProfileTab.Controls.Add(this.lblHeight);
      this.ProfileTab.Controls.Add(this.lblAge);
      this.ProfileTab.Controls.Add(this.lblLastName);
      this.ProfileTab.Controls.Add(this.lblEditProfileHeader);
      this.ProfileTab.Controls.Add(this.lblProfile);
      this.ProfileTab.Location = new System.Drawing.Point(4, 32);
      this.ProfileTab.Name = "ProfileTab";
      this.ProfileTab.Padding = new System.Windows.Forms.Padding(3);
      this.ProfileTab.Size = new System.Drawing.Size(796, 445);
      this.ProfileTab.TabIndex = 1;
      this.ProfileTab.Text = "Profile";
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(347, 388);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(92, 38);
      this.btnSave.TabIndex = 11;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      // 
      // txtWeight
      // 
      this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtWeight.Location = new System.Drawing.Point(313, 322);
      this.txtWeight.Name = "txtWeight";
      this.txtWeight.Size = new System.Drawing.Size(167, 30);
      this.txtWeight.TabIndex = 10;
      // 
      // txtHeight
      // 
      this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtHeight.Location = new System.Drawing.Point(313, 260);
      this.txtHeight.Name = "txtHeight";
      this.txtHeight.Size = new System.Drawing.Size(167, 30);
      this.txtHeight.TabIndex = 9;
      // 
      // txtAge
      // 
      this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtAge.Location = new System.Drawing.Point(313, 205);
      this.txtAge.Name = "txtAge";
      this.txtAge.Size = new System.Drawing.Size(167, 30);
      this.txtAge.TabIndex = 8;
      // 
      // txtLastName
      // 
      this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtLastName.Location = new System.Drawing.Point(313, 152);
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
      // lblWeight
      // 
      this.lblWeight.AutoSize = true;
      this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWeight.Location = new System.Drawing.Point(100, 332);
      this.lblWeight.Name = "lblWeight";
      this.lblWeight.Size = new System.Drawing.Size(67, 20);
      this.lblWeight.TabIndex = 5;
      this.lblWeight.Text = "Weight";
      // 
      // lblHeight
      // 
      this.lblHeight.AutoSize = true;
      this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblHeight.Location = new System.Drawing.Point(100, 270);
      this.lblHeight.Name = "lblHeight";
      this.lblHeight.Size = new System.Drawing.Size(64, 20);
      this.lblHeight.TabIndex = 4;
      this.lblHeight.Text = "Height";
      // 
      // lblAge
      // 
      this.lblAge.AutoSize = true;
      this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAge.Location = new System.Drawing.Point(100, 212);
      this.lblAge.Name = "lblAge";
      this.lblAge.Size = new System.Drawing.Size(41, 20);
      this.lblAge.TabIndex = 3;
      this.lblAge.Text = "Age";
      // 
      // lblLastName
      // 
      this.lblLastName.AutoSize = true;
      this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLastName.Location = new System.Drawing.Point(100, 152);
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
      // PredictionsTab
      // 
      this.PredictionsTab.BackColor = System.Drawing.Color.White;
      this.PredictionsTab.Location = new System.Drawing.Point(4, 32);
      this.PredictionsTab.Name = "PredictionsTab";
      this.PredictionsTab.Padding = new System.Windows.Forms.Padding(3);
      this.PredictionsTab.Size = new System.Drawing.Size(796, 445);
      this.PredictionsTab.TabIndex = 2;
      this.PredictionsTab.Text = "Predictions";
      // 
      // ReportsTab
      // 
      this.ReportsTab.BackColor = System.Drawing.Color.White;
      this.ReportsTab.Location = new System.Drawing.Point(4, 32);
      this.ReportsTab.Name = "ReportsTab";
      this.ReportsTab.Padding = new System.Windows.Forms.Padding(3);
      this.ReportsTab.Size = new System.Drawing.Size(796, 445);
      this.ReportsTab.TabIndex = 3;
      this.ReportsTab.Text = "Reports";
      // 
      // Dashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(963, 588);
      this.Controls.Add(this.Home);
      this.Name = "Dashboard";
      this.Text = "Hello <user>";
      this.Home.ResumeLayout(false);
      this.HomeTab.ResumeLayout(false);
      this.HomeTab.PerformLayout();
      this.ProfileTab.ResumeLayout(false);
      this.ProfileTab.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl Home;
    private System.Windows.Forms.TabPage HomeTab;
    private System.Windows.Forms.TabPage ProfileTab;
    private System.Windows.Forms.TabPage PredictionsTab;
    private System.Windows.Forms.TabPage ReportsTab;
    private System.Windows.Forms.Label lblHome;
    private System.Windows.Forms.Label lblProfile;
    private System.Windows.Forms.Label lblWeight;
    private System.Windows.Forms.Label lblHeight;
    private System.Windows.Forms.Label lblAge;
    private System.Windows.Forms.Label lblLastName;
    private System.Windows.Forms.Label lblEditProfileHeader;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.TextBox txtWeight;
    private System.Windows.Forms.TextBox txtHeight;
    private System.Windows.Forms.TextBox txtAge;
    private System.Windows.Forms.TextBox txtLastName;
    private System.Windows.Forms.TextBox txtFirstName;
  }
}