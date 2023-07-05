
namespace FitnessApp
{
  partial class Register
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
      this.pnlRegister = new System.Windows.Forms.Panel();
      this.lblKg = new System.Windows.Forms.Label();
      this.lblCm = new System.Windows.Forms.Label();
      this.btnRegister = new System.Windows.Forms.Button();
      this.txtLastName = new System.Windows.Forms.TextBox();
      this.txtUserName = new System.Windows.Forms.TextBox();
      this.txtWeight = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.txtConfirmPassword = new System.Windows.Forms.TextBox();
      this.txtHeight = new System.Windows.Forms.TextBox();
      this.txtAge = new System.Windows.Forms.TextBox();
      this.txtFirstName = new System.Windows.Forms.TextBox();
      this.lblPassword = new System.Windows.Forms.Label();
      this.lblConfirmPassword = new System.Windows.Forms.Label();
      this.lblLastName = new System.Windows.Forms.Label();
      this.lblUserName = new System.Windows.Forms.Label();
      this.lblAge = new System.Windows.Forms.Label();
      this.lblHeight = new System.Windows.Forms.Label();
      this.lblWeight = new System.Windows.Forms.Label();
      this.lblFirstName = new System.Windows.Forms.Label();
      this.lblRegisterHeader = new System.Windows.Forms.Label();
      this.RegisterErrorHandler = new System.Windows.Forms.ErrorProvider(this.components);
      this.pnlRegister.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.RegisterErrorHandler)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlRegister
      // 
      this.pnlRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))), ((int)(((byte)(230)))));
      this.pnlRegister.Controls.Add(this.lblKg);
      this.pnlRegister.Controls.Add(this.lblCm);
      this.pnlRegister.Controls.Add(this.btnRegister);
      this.pnlRegister.Controls.Add(this.txtLastName);
      this.pnlRegister.Controls.Add(this.txtUserName);
      this.pnlRegister.Controls.Add(this.txtWeight);
      this.pnlRegister.Controls.Add(this.txtPassword);
      this.pnlRegister.Controls.Add(this.txtConfirmPassword);
      this.pnlRegister.Controls.Add(this.txtHeight);
      this.pnlRegister.Controls.Add(this.txtAge);
      this.pnlRegister.Controls.Add(this.txtFirstName);
      this.pnlRegister.Controls.Add(this.lblPassword);
      this.pnlRegister.Controls.Add(this.lblConfirmPassword);
      this.pnlRegister.Controls.Add(this.lblLastName);
      this.pnlRegister.Controls.Add(this.lblUserName);
      this.pnlRegister.Controls.Add(this.lblAge);
      this.pnlRegister.Controls.Add(this.lblHeight);
      this.pnlRegister.Controls.Add(this.lblWeight);
      this.pnlRegister.Controls.Add(this.lblFirstName);
      this.pnlRegister.Controls.Add(this.lblRegisterHeader);
      this.pnlRegister.Location = new System.Drawing.Point(72, 32);
      this.pnlRegister.Name = "pnlRegister";
      this.pnlRegister.Size = new System.Drawing.Size(610, 575);
      this.pnlRegister.TabIndex = 0;
      // 
      // lblKg
      // 
      this.lblKg.AutoSize = true;
      this.lblKg.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblKg.ForeColor = System.Drawing.Color.Blue;
      this.lblKg.Location = new System.Drawing.Point(385, 359);
      this.lblKg.Name = "lblKg";
      this.lblKg.Size = new System.Drawing.Size(31, 24);
      this.lblKg.TabIndex = 19;
      this.lblKg.Text = "kg";
      // 
      // lblCm
      // 
      this.lblCm.AutoSize = true;
      this.lblCm.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCm.ForeColor = System.Drawing.Color.Blue;
      this.lblCm.Location = new System.Drawing.Point(384, 303);
      this.lblCm.Name = "lblCm";
      this.lblCm.Size = new System.Drawing.Size(36, 24);
      this.lblCm.TabIndex = 18;
      this.lblCm.Text = "cm";
      // 
      // btnRegister
      // 
      this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRegister.Location = new System.Drawing.Point(244, 525);
      this.btnRegister.Name = "btnRegister";
      this.btnRegister.Size = new System.Drawing.Size(106, 31);
      this.btnRegister.TabIndex = 17;
      this.btnRegister.Text = "Register";
      this.btnRegister.UseVisualStyleBackColor = true;
      this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
      // 
      // txtLastName
      // 
      this.txtLastName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtLastName.Location = new System.Drawing.Point(244, 145);
      this.txtLastName.Name = "txtLastName";
      this.txtLastName.Size = new System.Drawing.Size(118, 30);
      this.txtLastName.TabIndex = 16;
      this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtField_Validating);
      // 
      // txtUserName
      // 
      this.txtUserName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUserName.Location = new System.Drawing.Point(244, 195);
      this.txtUserName.Name = "txtUserName";
      this.txtUserName.Size = new System.Drawing.Size(118, 30);
      this.txtUserName.TabIndex = 15;
      this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtField_Validating);
      // 
      // txtWeight
      // 
      this.txtWeight.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtWeight.Location = new System.Drawing.Point(244, 353);
      this.txtWeight.Name = "txtWeight";
      this.txtWeight.Size = new System.Drawing.Size(118, 30);
      this.txtWeight.TabIndex = 14;
      this.txtWeight.Validating += new System.ComponentModel.CancelEventHandler(this.txtDouble_Validating);
      // 
      // txtPassword
      // 
      this.txtPassword.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPassword.Location = new System.Drawing.Point(244, 408);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(118, 30);
      this.txtPassword.TabIndex = 13;
      this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtField_Validating);
      // 
      // txtConfirmPassword
      // 
      this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtConfirmPassword.Location = new System.Drawing.Point(244, 471);
      this.txtConfirmPassword.Name = "txtConfirmPassword";
      this.txtConfirmPassword.Size = new System.Drawing.Size(118, 30);
      this.txtConfirmPassword.TabIndex = 12;
      this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtField_Validating);
      // 
      // txtHeight
      // 
      this.txtHeight.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtHeight.Location = new System.Drawing.Point(244, 300);
      this.txtHeight.Name = "txtHeight";
      this.txtHeight.Size = new System.Drawing.Size(118, 30);
      this.txtHeight.TabIndex = 11;
      this.txtHeight.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumber_Validating);
      // 
      // txtAge
      // 
      this.txtAge.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtAge.Location = new System.Drawing.Point(244, 244);
      this.txtAge.Name = "txtAge";
      this.txtAge.Size = new System.Drawing.Size(118, 30);
      this.txtAge.TabIndex = 10;
      this.txtAge.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumber_Validating);
      // 
      // txtFirstName
      // 
      this.txtFirstName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtFirstName.Location = new System.Drawing.Point(244, 95);
      this.txtFirstName.Name = "txtFirstName";
      this.txtFirstName.Size = new System.Drawing.Size(118, 30);
      this.txtFirstName.TabIndex = 9;
      this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtField_Validating);
      // 
      // lblPassword
      // 
      this.lblPassword.AutoSize = true;
      this.lblPassword.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPassword.ForeColor = System.Drawing.Color.Blue;
      this.lblPassword.Location = new System.Drawing.Point(52, 414);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(90, 24);
      this.lblPassword.TabIndex = 8;
      this.lblPassword.Text = "Password";
      // 
      // lblConfirmPassword
      // 
      this.lblConfirmPassword.AutoSize = true;
      this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblConfirmPassword.ForeColor = System.Drawing.Color.Blue;
      this.lblConfirmPassword.Location = new System.Drawing.Point(48, 474);
      this.lblConfirmPassword.Name = "lblConfirmPassword";
      this.lblConfirmPassword.Size = new System.Drawing.Size(164, 24);
      this.lblConfirmPassword.TabIndex = 7;
      this.lblConfirmPassword.Text = "Confirm Password";
      // 
      // lblLastName
      // 
      this.lblLastName.AutoSize = true;
      this.lblLastName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLastName.ForeColor = System.Drawing.Color.Blue;
      this.lblLastName.Location = new System.Drawing.Point(52, 148);
      this.lblLastName.Name = "lblLastName";
      this.lblLastName.Size = new System.Drawing.Size(100, 24);
      this.lblLastName.TabIndex = 6;
      this.lblLastName.Text = "Last Name";
      // 
      // lblUserName
      // 
      this.lblUserName.AutoSize = true;
      this.lblUserName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUserName.ForeColor = System.Drawing.Color.Blue;
      this.lblUserName.Location = new System.Drawing.Point(52, 198);
      this.lblUserName.Name = "lblUserName";
      this.lblUserName.Size = new System.Drawing.Size(104, 24);
      this.lblUserName.TabIndex = 5;
      this.lblUserName.Text = "User Name";
      // 
      // lblAge
      // 
      this.lblAge.AutoSize = true;
      this.lblAge.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAge.ForeColor = System.Drawing.Color.Blue;
      this.lblAge.Location = new System.Drawing.Point(52, 247);
      this.lblAge.Name = "lblAge";
      this.lblAge.Size = new System.Drawing.Size(44, 24);
      this.lblAge.TabIndex = 4;
      this.lblAge.Text = "Age";
      // 
      // lblHeight
      // 
      this.lblHeight.AutoSize = true;
      this.lblHeight.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblHeight.ForeColor = System.Drawing.Color.Blue;
      this.lblHeight.Location = new System.Drawing.Point(52, 302);
      this.lblHeight.Name = "lblHeight";
      this.lblHeight.Size = new System.Drawing.Size(68, 24);
      this.lblHeight.TabIndex = 3;
      this.lblHeight.Text = "Height";
      // 
      // lblWeight
      // 
      this.lblWeight.AutoSize = true;
      this.lblWeight.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWeight.ForeColor = System.Drawing.Color.Blue;
      this.lblWeight.Location = new System.Drawing.Point(52, 362);
      this.lblWeight.Name = "lblWeight";
      this.lblWeight.Size = new System.Drawing.Size(72, 24);
      this.lblWeight.TabIndex = 2;
      this.lblWeight.Text = "Weight";
      // 
      // lblFirstName
      // 
      this.lblFirstName.AutoSize = true;
      this.lblFirstName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFirstName.ForeColor = System.Drawing.Color.Blue;
      this.lblFirstName.Location = new System.Drawing.Point(52, 101);
      this.lblFirstName.Name = "lblFirstName";
      this.lblFirstName.Size = new System.Drawing.Size(102, 24);
      this.lblFirstName.TabIndex = 1;
      this.lblFirstName.Text = "First Name";
      // 
      // lblRegisterHeader
      // 
      this.lblRegisterHeader.AutoSize = true;
      this.lblRegisterHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblRegisterHeader.Location = new System.Drawing.Point(77, 21);
      this.lblRegisterHeader.Name = "lblRegisterHeader";
      this.lblRegisterHeader.Size = new System.Drawing.Size(421, 29);
      this.lblRegisterHeader.TabIndex = 0;
      this.lblRegisterHeader.Text = "Register Now to start your Journey!";
      // 
      // RegisterErrorHandler
      // 
      this.RegisterErrorHandler.ContainerControl = this;
      // 
      // Register
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::FitnessApp.Properties.Resources.register;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1085, 641);
      this.Controls.Add(this.pnlRegister);
      this.Name = "Register";
      this.Text = "Register";
      this.pnlRegister.ResumeLayout(false);
      this.pnlRegister.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.RegisterErrorHandler)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlRegister;
    private System.Windows.Forms.Label lblLastName;
    private System.Windows.Forms.Label lblUserName;
    private System.Windows.Forms.Label lblAge;
    private System.Windows.Forms.Label lblHeight;
    private System.Windows.Forms.Label lblWeight;
    private System.Windows.Forms.Label lblFirstName;
    private System.Windows.Forms.Label lblRegisterHeader;
    private System.Windows.Forms.TextBox txtLastName;
    private System.Windows.Forms.TextBox txtUserName;
    private System.Windows.Forms.TextBox txtWeight;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.TextBox txtConfirmPassword;
    private System.Windows.Forms.TextBox txtHeight;
    private System.Windows.Forms.TextBox txtAge;
    private System.Windows.Forms.TextBox txtFirstName;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.Label lblConfirmPassword;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.ErrorProvider RegisterErrorHandler;
    private System.Windows.Forms.Label lblKg;
    private System.Windows.Forms.Label lblCm;
  }
}