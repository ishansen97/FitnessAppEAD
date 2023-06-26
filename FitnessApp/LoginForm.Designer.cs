
namespace FitnessApp
{
  partial class LoginForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
      this.lblHeader = new System.Windows.Forms.Label();
      this.lblPassword = new System.Windows.Forms.Label();
      this.lblUserName = new System.Windows.Forms.Label();
      this.txtUserName = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.btnLogin = new System.Windows.Forms.Button();
      this.lblNewUser = new System.Windows.Forms.Label();
      this.lnkRegister = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // lblHeader
      // 
      this.lblHeader.AutoSize = true;
      this.lblHeader.BackColor = System.Drawing.Color.Transparent;
      this.lblHeader.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblHeader.ForeColor = System.Drawing.SystemColors.InactiveCaption;
      this.lblHeader.Location = new System.Drawing.Point(304, 84);
      this.lblHeader.Name = "lblHeader";
      this.lblHeader.Size = new System.Drawing.Size(348, 38);
      this.lblHeader.TabIndex = 0;
      this.lblHeader.Text = "Welcome To FitTracker";
      // 
      // lblPassword
      // 
      this.lblPassword.AutoSize = true;
      this.lblPassword.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPassword.Location = new System.Drawing.Point(138, 332);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(136, 32);
      this.lblPassword.TabIndex = 1;
      this.lblPassword.Text = "Password";
      // 
      // lblUserName
      // 
      this.lblUserName.AutoSize = true;
      this.lblUserName.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUserName.Location = new System.Drawing.Point(139, 243);
      this.lblUserName.Name = "lblUserName";
      this.lblUserName.Size = new System.Drawing.Size(155, 32);
      this.lblUserName.TabIndex = 2;
      this.lblUserName.Text = "User Name";
      // 
      // txtUserName
      // 
      this.txtUserName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUserName.Location = new System.Drawing.Point(418, 245);
      this.txtUserName.Name = "txtUserName";
      this.txtUserName.Size = new System.Drawing.Size(186, 34);
      this.txtUserName.TabIndex = 3;
      // 
      // txtPassword
      // 
      this.txtPassword.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPassword.Location = new System.Drawing.Point(418, 332);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(186, 34);
      this.txtPassword.TabIndex = 4;
      // 
      // btnLogin
      // 
      this.btnLogin.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLogin.Location = new System.Drawing.Point(418, 415);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(100, 39);
      this.btnLogin.TabIndex = 5;
      this.btnLogin.Text = "Login";
      this.btnLogin.UseVisualStyleBackColor = true;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // lblNewUser
      // 
      this.lblNewUser.AutoSize = true;
      this.lblNewUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNewUser.Location = new System.Drawing.Point(343, 479);
      this.lblNewUser.Name = "lblNewUser";
      this.lblNewUser.Size = new System.Drawing.Size(112, 24);
      this.lblNewUser.TabIndex = 6;
      this.lblNewUser.Text = "New User?";
      // 
      // lnkRegister
      // 
      this.lnkRegister.AutoSize = true;
      this.lnkRegister.Location = new System.Drawing.Point(479, 479);
      this.lnkRegister.Name = "lnkRegister";
      this.lnkRegister.Size = new System.Drawing.Size(70, 24);
      this.lnkRegister.TabIndex = 7;
      this.lnkRegister.TabStop = true;
      this.lnkRegister.Text = "Register";
      this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked);
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(991, 633);
      this.Controls.Add(this.lnkRegister);
      this.Controls.Add(this.lblNewUser);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.txtUserName);
      this.Controls.Add(this.lblUserName);
      this.Controls.Add(this.lblPassword);
      this.Controls.Add(this.lblHeader);
      this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "LoginForm";
      this.Text = "FitTracker";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblHeader;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.Label lblUserName;
    private System.Windows.Forms.TextBox txtUserName;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Label lblNewUser;
    private System.Windows.Forms.LinkLabel lnkRegister;
  }
}