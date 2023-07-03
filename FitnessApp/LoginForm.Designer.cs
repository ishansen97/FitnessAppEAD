
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
      this.lblHeader = new System.Windows.Forms.Label();
      this.lblPassword = new System.Windows.Forms.Label();
      this.lblUserName = new System.Windows.Forms.Label();
      this.txtUserName = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.btnLogin = new System.Windows.Forms.Button();
      this.LoginErrorHandler = new System.Windows.Forms.ErrorProvider(this.components);
      this.pnlLoginForm = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.LoginErrorHandler)).BeginInit();
      this.pnlLoginForm.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblHeader
      // 
      this.lblHeader.AutoSize = true;
      this.lblHeader.BackColor = System.Drawing.Color.Transparent;
      this.lblHeader.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblHeader.ForeColor = System.Drawing.SystemColors.InactiveCaption;
      this.lblHeader.Location = new System.Drawing.Point(244, 29);
      this.lblHeader.Name = "lblHeader";
      this.lblHeader.Size = new System.Drawing.Size(348, 38);
      this.lblHeader.TabIndex = 0;
      this.lblHeader.Text = "Welcome To FitTracker";
      // 
      // lblPassword
      // 
      this.lblPassword.AutoSize = true;
      this.lblPassword.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPassword.Location = new System.Drawing.Point(78, 277);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(136, 32);
      this.lblPassword.TabIndex = 1;
      this.lblPassword.Text = "Password";
      // 
      // lblUserName
      // 
      this.lblUserName.AutoSize = true;
      this.lblUserName.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUserName.Location = new System.Drawing.Point(79, 188);
      this.lblUserName.Name = "lblUserName";
      this.lblUserName.Size = new System.Drawing.Size(155, 32);
      this.lblUserName.TabIndex = 2;
      this.lblUserName.Text = "User Name";
      // 
      // txtUserName
      // 
      this.txtUserName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUserName.Location = new System.Drawing.Point(358, 190);
      this.txtUserName.Name = "txtUserName";
      this.txtUserName.Size = new System.Drawing.Size(186, 34);
      this.txtUserName.TabIndex = 3;
      this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validate);
      // 
      // txtPassword
      // 
      this.txtPassword.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPassword.Location = new System.Drawing.Point(358, 277);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(186, 34);
      this.txtPassword.TabIndex = 4;
      this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
      // 
      // btnLogin
      // 
      this.btnLogin.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLogin.Location = new System.Drawing.Point(358, 360);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(100, 39);
      this.btnLogin.TabIndex = 5;
      this.btnLogin.Text = "Login";
      this.btnLogin.UseVisualStyleBackColor = true;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // LoginErrorHandler
      // 
      this.LoginErrorHandler.ContainerControl = this;
      // 
      // pnlLoginForm
      // 
      this.pnlLoginForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))), ((int)(((byte)(230)))));
      this.pnlLoginForm.Controls.Add(this.btnLogin);
      this.pnlLoginForm.Controls.Add(this.txtPassword);
      this.pnlLoginForm.Controls.Add(this.txtUserName);
      this.pnlLoginForm.Controls.Add(this.lblUserName);
      this.pnlLoginForm.Controls.Add(this.lblPassword);
      this.pnlLoginForm.Controls.Add(this.lblHeader);
      this.pnlLoginForm.Location = new System.Drawing.Point(60, 55);
      this.pnlLoginForm.Name = "pnlLoginForm";
      this.pnlLoginForm.Size = new System.Drawing.Size(860, 482);
      this.pnlLoginForm.TabIndex = 6;
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(991, 652);
      this.Controls.Add(this.pnlLoginForm);
      this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "LoginForm";
      this.Text = "FitTracker";
      ((System.ComponentModel.ISupportInitialize)(this.LoginErrorHandler)).EndInit();
      this.pnlLoginForm.ResumeLayout(false);
      this.pnlLoginForm.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblHeader;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.Label lblUserName;
    private System.Windows.Forms.TextBox txtUserName;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.ErrorProvider LoginErrorHandler;
    private System.Windows.Forms.Panel pnlLoginForm;
  }
}