
namespace FitnessApp
{
  partial class EditCheatMeal
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
      this.pb2 = new System.Windows.Forms.PictureBox();
      this.pb1 = new System.Windows.Forms.PictureBox();
      this.lblEditCheatMealHeader = new System.Windows.Forms.Label();
      this.pnlEditCheatMeal = new System.Windows.Forms.Panel();
      this.lblUnit = new System.Windows.Forms.Label();
      this.txtAmount = new System.Windows.Forms.TextBox();
      this.lblAmount = new System.Windows.Forms.Label();
      this.btnEdit = new System.Windows.Forms.Button();
      this.dtCheatMealDate = new System.Windows.Forms.DateTimePicker();
      this.lblCheatMealDate = new System.Windows.Forms.Label();
      this.pnlFields = new System.Windows.Forms.Panel();
      this.lblCheatMealTypeValue = new System.Windows.Forms.Label();
      this.lblCheatMealType = new System.Windows.Forms.Label();
      this.CheatMealErrorHandler = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
      this.pnlEditCheatMeal.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.CheatMealErrorHandler)).BeginInit();
      this.SuspendLayout();
      // 
      // pb2
      // 
      this.pb2.Image = global::FitnessApp.Properties.Resources.dumbbell_32;
      this.pb2.Location = new System.Drawing.Point(638, 92);
      this.pb2.Name = "pb2";
      this.pb2.Size = new System.Drawing.Size(40, 37);
      this.pb2.TabIndex = 5;
      this.pb2.TabStop = false;
      // 
      // pb1
      // 
      this.pb1.Image = global::FitnessApp.Properties.Resources.running_32;
      this.pb1.Location = new System.Drawing.Point(584, 92);
      this.pb1.Name = "pb1";
      this.pb1.Size = new System.Drawing.Size(39, 37);
      this.pb1.TabIndex = 4;
      this.pb1.TabStop = false;
      // 
      // lblEditCheatMealHeader
      // 
      this.lblEditCheatMealHeader.AutoSize = true;
      this.lblEditCheatMealHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEditCheatMealHeader.Location = new System.Drawing.Point(336, 92);
      this.lblEditCheatMealHeader.Name = "lblEditCheatMealHeader";
      this.lblEditCheatMealHeader.Size = new System.Drawing.Size(232, 32);
      this.lblEditCheatMealHeader.TabIndex = 3;
      this.lblEditCheatMealHeader.Text = "Edit Cheat meal";
      // 
      // pnlEditCheatMeal
      // 
      this.pnlEditCheatMeal.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.pnlEditCheatMeal.Controls.Add(this.lblUnit);
      this.pnlEditCheatMeal.Controls.Add(this.txtAmount);
      this.pnlEditCheatMeal.Controls.Add(this.lblAmount);
      this.pnlEditCheatMeal.Controls.Add(this.btnEdit);
      this.pnlEditCheatMeal.Controls.Add(this.dtCheatMealDate);
      this.pnlEditCheatMeal.Controls.Add(this.lblCheatMealDate);
      this.pnlEditCheatMeal.Controls.Add(this.pnlFields);
      this.pnlEditCheatMeal.Controls.Add(this.lblCheatMealTypeValue);
      this.pnlEditCheatMeal.Controls.Add(this.lblCheatMealType);
      this.pnlEditCheatMeal.Location = new System.Drawing.Point(184, 135);
      this.pnlEditCheatMeal.Name = "pnlEditCheatMeal";
      this.pnlEditCheatMeal.Size = new System.Drawing.Size(662, 410);
      this.pnlEditCheatMeal.TabIndex = 6;
      // 
      // lblUnit
      // 
      this.lblUnit.AutoSize = true;
      this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUnit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.lblUnit.Location = new System.Drawing.Point(445, 125);
      this.lblUnit.Name = "lblUnit";
      this.lblUnit.Size = new System.Drawing.Size(24, 25);
      this.lblUnit.TabIndex = 8;
      this.lblUnit.Text = "g";
      // 
      // txtAmount
      // 
      this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtAmount.Location = new System.Drawing.Point(339, 125);
      this.txtAmount.Name = "txtAmount";
      this.txtAmount.Size = new System.Drawing.Size(100, 30);
      this.txtAmount.TabIndex = 7;
      this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.OnAmount_Validating);
      // 
      // lblAmount
      // 
      this.lblAmount.AutoSize = true;
      this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.lblAmount.Location = new System.Drawing.Point(55, 121);
      this.lblAmount.Name = "lblAmount";
      this.lblAmount.Size = new System.Drawing.Size(86, 25);
      this.lblAmount.TabIndex = 6;
      this.lblAmount.Text = "Amount";
      // 
      // btnEdit
      // 
      this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
      this.btnEdit.FlatAppearance.BorderSize = 2;
      this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEdit.Location = new System.Drawing.Point(281, 341);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(92, 33);
      this.btnEdit.TabIndex = 5;
      this.btnEdit.Text = "Edit";
      this.btnEdit.UseVisualStyleBackColor = true;
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // dtCheatMealDate
      // 
      this.dtCheatMealDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtCheatMealDate.Location = new System.Drawing.Point(335, 183);
      this.dtCheatMealDate.Name = "dtCheatMealDate";
      this.dtCheatMealDate.Size = new System.Drawing.Size(167, 22);
      this.dtCheatMealDate.TabIndex = 4;
      // 
      // lblCheatMealDate
      // 
      this.lblCheatMealDate.AutoSize = true;
      this.lblCheatMealDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCheatMealDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.lblCheatMealDate.Location = new System.Drawing.Point(55, 180);
      this.lblCheatMealDate.Name = "lblCheatMealDate";
      this.lblCheatMealDate.Size = new System.Drawing.Size(57, 25);
      this.lblCheatMealDate.TabIndex = 3;
      this.lblCheatMealDate.Text = "Date";
      // 
      // pnlFields
      // 
      this.pnlFields.AutoSize = true;
      this.pnlFields.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.pnlFields.Location = new System.Drawing.Point(49, 112);
      this.pnlFields.Name = "pnlFields";
      this.pnlFields.Size = new System.Drawing.Size(0, 0);
      this.pnlFields.TabIndex = 2;
      // 
      // lblCheatMealTypeValue
      // 
      this.lblCheatMealTypeValue.AutoSize = true;
      this.lblCheatMealTypeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCheatMealTypeValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.lblCheatMealTypeValue.Location = new System.Drawing.Point(334, 66);
      this.lblCheatMealTypeValue.Name = "lblCheatMealTypeValue";
      this.lblCheatMealTypeValue.Size = new System.Drawing.Size(123, 25);
      this.lblCheatMealTypeValue.TabIndex = 1;
      this.lblCheatMealTypeValue.Text = "Cheat Meal";
      // 
      // lblCheatMealType
      // 
      this.lblCheatMealType.AutoSize = true;
      this.lblCheatMealType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCheatMealType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.lblCheatMealType.Location = new System.Drawing.Point(55, 66);
      this.lblCheatMealType.Name = "lblCheatMealType";
      this.lblCheatMealType.Size = new System.Drawing.Size(178, 25);
      this.lblCheatMealType.TabIndex = 0;
      this.lblCheatMealType.Text = "Cheat Meal Type";
      // 
      // CheatMealErrorHandler
      // 
      this.CheatMealErrorHandler.ContainerControl = this;
      // 
      // EditCheatMeal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1037, 623);
      this.Controls.Add(this.pnlEditCheatMeal);
      this.Controls.Add(this.pb2);
      this.Controls.Add(this.pb1);
      this.Controls.Add(this.lblEditCheatMealHeader);
      this.Name = "EditCheatMeal";
      this.Text = "EditCheatMeal";
      ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
      this.pnlEditCheatMeal.ResumeLayout(false);
      this.pnlEditCheatMeal.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.CheatMealErrorHandler)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pb2;
    private System.Windows.Forms.PictureBox pb1;
    private System.Windows.Forms.Label lblEditCheatMealHeader;
    private System.Windows.Forms.Panel pnlEditCheatMeal;
    private System.Windows.Forms.Label lblUnit;
    private System.Windows.Forms.TextBox txtAmount;
    private System.Windows.Forms.Label lblAmount;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.DateTimePicker dtCheatMealDate;
    private System.Windows.Forms.Label lblCheatMealDate;
    private System.Windows.Forms.Panel pnlFields;
    private System.Windows.Forms.Label lblCheatMealTypeValue;
    private System.Windows.Forms.Label lblCheatMealType;
    private System.Windows.Forms.ErrorProvider CheatMealErrorHandler;
  }
}