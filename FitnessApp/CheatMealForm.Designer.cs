
namespace FitnessApp
{
  partial class CheatMealForm
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
      this.pnlWorkout = new System.Windows.Forms.Panel();
      this.dtCheatMealPicker = new System.Windows.Forms.DateTimePicker();
      this.lblCheatMealDate = new System.Windows.Forms.Label();
      this.txtAmount = new System.Windows.Forms.TextBox();
      this.lblAmount = new System.Windows.Forms.Label();
      this.btnAddCheatMeal = new System.Windows.Forms.Button();
      this.cmbCheatMealTypes = new System.Windows.Forms.ComboBox();
      this.lblCheatMealType = new System.Windows.Forms.Label();
      this.lblCheatMealHead = new System.Windows.Forms.Label();
      this.CheatMealErrorHandler = new System.Windows.Forms.ErrorProvider(this.components);
      this.pnlWorkout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.CheatMealErrorHandler)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlWorkout
      // 
      this.pnlWorkout.BackColor = System.Drawing.SystemColors.Control;
      this.pnlWorkout.Controls.Add(this.dtCheatMealPicker);
      this.pnlWorkout.Controls.Add(this.lblCheatMealDate);
      this.pnlWorkout.Controls.Add(this.txtAmount);
      this.pnlWorkout.Controls.Add(this.lblAmount);
      this.pnlWorkout.Controls.Add(this.btnAddCheatMeal);
      this.pnlWorkout.Controls.Add(this.cmbCheatMealTypes);
      this.pnlWorkout.Controls.Add(this.lblCheatMealType);
      this.pnlWorkout.Controls.Add(this.lblCheatMealHead);
      this.pnlWorkout.Location = new System.Drawing.Point(149, 41);
      this.pnlWorkout.Name = "pnlWorkout";
      this.pnlWorkout.Size = new System.Drawing.Size(728, 511);
      this.pnlWorkout.TabIndex = 1;
      // 
      // dtCheatMealPicker
      // 
      this.dtCheatMealPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtCheatMealPicker.Location = new System.Drawing.Point(267, 254);
      this.dtCheatMealPicker.Name = "dtCheatMealPicker";
      this.dtCheatMealPicker.Size = new System.Drawing.Size(157, 22);
      this.dtCheatMealPicker.TabIndex = 11;
      this.dtCheatMealPicker.Value = new System.DateTime(2023, 7, 3, 0, 0, 0, 0);
      // 
      // lblCheatMealDate
      // 
      this.lblCheatMealDate.AutoSize = true;
      this.lblCheatMealDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCheatMealDate.ForeColor = System.Drawing.Color.Blue;
      this.lblCheatMealDate.Location = new System.Drawing.Point(33, 253);
      this.lblCheatMealDate.Name = "lblCheatMealDate";
      this.lblCheatMealDate.Size = new System.Drawing.Size(52, 23);
      this.lblCheatMealDate.TabIndex = 10;
      this.lblCheatMealDate.Text = "Date";
      // 
      // txtAmount
      // 
      this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtAmount.Location = new System.Drawing.Point(267, 187);
      this.txtAmount.Name = "txtAmount";
      this.txtAmount.Size = new System.Drawing.Size(136, 30);
      this.txtAmount.TabIndex = 9;
      this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmount_Validating);
      // 
      // lblAmount
      // 
      this.lblAmount.AutoSize = true;
      this.lblAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAmount.ForeColor = System.Drawing.Color.Blue;
      this.lblAmount.Location = new System.Drawing.Point(29, 191);
      this.lblAmount.Name = "lblAmount";
      this.lblAmount.Size = new System.Drawing.Size(167, 23);
      this.lblAmount.TabIndex = 8;
      this.lblAmount.Text = "Portion (in grams)";
      // 
      // btnAddCheatMeal
      // 
      this.btnAddCheatMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddCheatMeal.Location = new System.Drawing.Point(264, 404);
      this.btnAddCheatMeal.Name = "btnAddCheatMeal";
      this.btnAddCheatMeal.Size = new System.Drawing.Size(121, 36);
      this.btnAddCheatMeal.TabIndex = 3;
      this.btnAddCheatMeal.Text = "Save";
      this.btnAddCheatMeal.UseVisualStyleBackColor = true;
      this.btnAddCheatMeal.Click += new System.EventHandler(this.btnAddCheatMeal_Click);
      // 
      // cmbCheatMealTypes
      // 
      this.cmbCheatMealTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbCheatMealTypes.FormattingEnabled = true;
      this.cmbCheatMealTypes.Location = new System.Drawing.Point(267, 122);
      this.cmbCheatMealTypes.Name = "cmbCheatMealTypes";
      this.cmbCheatMealTypes.Size = new System.Drawing.Size(136, 33);
      this.cmbCheatMealTypes.TabIndex = 2;
      this.cmbCheatMealTypes.Validating += new System.ComponentModel.CancelEventHandler(this.cmbCheatMealTypes_Validating);
      // 
      // lblCheatMealType
      // 
      this.lblCheatMealType.AutoSize = true;
      this.lblCheatMealType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCheatMealType.ForeColor = System.Drawing.Color.Blue;
      this.lblCheatMealType.Location = new System.Drawing.Point(29, 123);
      this.lblCheatMealType.Name = "lblCheatMealType";
      this.lblCheatMealType.Size = new System.Drawing.Size(111, 23);
      this.lblCheatMealType.TabIndex = 1;
      this.lblCheatMealType.Text = "Cheat Meal";
      // 
      // lblCheatMealHead
      // 
      this.lblCheatMealHead.AutoSize = true;
      this.lblCheatMealHead.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCheatMealHead.Location = new System.Drawing.Point(231, 27);
      this.lblCheatMealHead.Name = "lblCheatMealHead";
      this.lblCheatMealHead.Size = new System.Drawing.Size(246, 38);
      this.lblCheatMealHead.TabIndex = 0;
      this.lblCheatMealHead.Text = "Add Cheat Meal";
      // 
      // CheatMealErrorHandler
      // 
      this.CheatMealErrorHandler.ContainerControl = this;
      // 
      // CheatMealForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(1027, 592);
      this.Controls.Add(this.pnlWorkout);
      this.Name = "CheatMealForm";
      this.Text = "Add Cheat Meal";
      this.pnlWorkout.ResumeLayout(false);
      this.pnlWorkout.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.CheatMealErrorHandler)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlWorkout;
    private System.Windows.Forms.TextBox txtAmount;
    private System.Windows.Forms.Label lblAmount;
    private System.Windows.Forms.Button btnAddCheatMeal;
    private System.Windows.Forms.ComboBox cmbCheatMealTypes;
    private System.Windows.Forms.Label lblCheatMealType;
    private System.Windows.Forms.Label lblCheatMealHead;
    private System.Windows.Forms.DateTimePicker dtCheatMealPicker;
    private System.Windows.Forms.Label lblCheatMealDate;
    private System.Windows.Forms.ErrorProvider CheatMealErrorHandler;
  }
}