
namespace FitnessApp
{
  partial class WorkoutForm
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
      this.pnlWorkoutControls = new System.Windows.Forms.Panel();
      this.btnAddWorkout = new System.Windows.Forms.Button();
      this.cmbWorkoutTypes = new System.Windows.Forms.ComboBox();
      this.lblWorkoutType = new System.Windows.Forms.Label();
      this.lblWorkoutHead = new System.Windows.Forms.Label();
      this.pnlWorkoutDate = new System.Windows.Forms.Panel();
      this.dtWorkoutPicker = new System.Windows.Forms.DateTimePicker();
      this.lblWorkoutDate = new System.Windows.Forms.Label();
      this.WorkoutErrorHandler = new System.Windows.Forms.ErrorProvider(this.components);
      this.pnlWorkout.SuspendLayout();
      this.pnlWorkoutDate.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.WorkoutErrorHandler)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlWorkout
      // 
      this.pnlWorkout.BackColor = System.Drawing.SystemColors.Control;
      this.pnlWorkout.Controls.Add(this.pnlWorkoutControls);
      this.pnlWorkout.Controls.Add(this.btnAddWorkout);
      this.pnlWorkout.Controls.Add(this.cmbWorkoutTypes);
      this.pnlWorkout.Controls.Add(this.lblWorkoutType);
      this.pnlWorkout.Controls.Add(this.lblWorkoutHead);
      this.pnlWorkout.Controls.Add(this.pnlWorkoutDate);
      this.pnlWorkout.Location = new System.Drawing.Point(119, 32);
      this.pnlWorkout.Name = "pnlWorkout";
      this.pnlWorkout.Size = new System.Drawing.Size(728, 511);
      this.pnlWorkout.TabIndex = 0;
      // 
      // pnlWorkoutControls
      // 
      this.pnlWorkoutControls.AutoSize = true;
      this.pnlWorkoutControls.BackColor = System.Drawing.SystemColors.Control;
      this.pnlWorkoutControls.Location = new System.Drawing.Point(3, 182);
      this.pnlWorkoutControls.Name = "pnlWorkoutControls";
      this.pnlWorkoutControls.Size = new System.Drawing.Size(455, 127);
      this.pnlWorkoutControls.TabIndex = 4;
      // 
      // btnAddWorkout
      // 
      this.btnAddWorkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddWorkout.Location = new System.Drawing.Point(264, 404);
      this.btnAddWorkout.Name = "btnAddWorkout";
      this.btnAddWorkout.Size = new System.Drawing.Size(121, 36);
      this.btnAddWorkout.TabIndex = 3;
      this.btnAddWorkout.Text = "Save";
      this.btnAddWorkout.UseVisualStyleBackColor = true;
      this.btnAddWorkout.Click += new System.EventHandler(this.btnAddWorkout_Click);
      // 
      // cmbWorkoutTypes
      // 
      this.cmbWorkoutTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cmbWorkoutTypes.FormattingEnabled = true;
      this.cmbWorkoutTypes.Location = new System.Drawing.Point(267, 122);
      this.cmbWorkoutTypes.Name = "cmbWorkoutTypes";
      this.cmbWorkoutTypes.Size = new System.Drawing.Size(136, 33);
      this.cmbWorkoutTypes.TabIndex = 2;
      this.cmbWorkoutTypes.SelectedIndexChanged += new System.EventHandler(this.OnSelectedWorkoutType_Changed);
      this.cmbWorkoutTypes.Validating += new System.ComponentModel.CancelEventHandler(this.WorkoutTypes_Validated);
      // 
      // lblWorkoutType
      // 
      this.lblWorkoutType.AutoSize = true;
      this.lblWorkoutType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWorkoutType.ForeColor = System.Drawing.Color.Blue;
      this.lblWorkoutType.Location = new System.Drawing.Point(29, 123);
      this.lblWorkoutType.Name = "lblWorkoutType";
      this.lblWorkoutType.Size = new System.Drawing.Size(133, 23);
      this.lblWorkoutType.TabIndex = 1;
      this.lblWorkoutType.Text = "Workout Type";
      // 
      // lblWorkoutHead
      // 
      this.lblWorkoutHead.AutoSize = true;
      this.lblWorkoutHead.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWorkoutHead.Location = new System.Drawing.Point(231, 27);
      this.lblWorkoutHead.Name = "lblWorkoutHead";
      this.lblWorkoutHead.Size = new System.Drawing.Size(205, 38);
      this.lblWorkoutHead.TabIndex = 0;
      this.lblWorkoutHead.Text = "Add Workout";
      // 
      // pnlWorkoutDate
      // 
      this.pnlWorkoutDate.BackColor = System.Drawing.SystemColors.Control;
      this.pnlWorkoutDate.Controls.Add(this.dtWorkoutPicker);
      this.pnlWorkoutDate.Controls.Add(this.lblWorkoutDate);
      this.pnlWorkoutDate.Location = new System.Drawing.Point(3, 315);
      this.pnlWorkoutDate.Name = "pnlWorkoutDate";
      this.pnlWorkoutDate.Size = new System.Drawing.Size(463, 36);
      this.pnlWorkoutDate.TabIndex = 7;
      this.pnlWorkoutDate.Visible = false;
      // 
      // dtWorkoutPicker
      // 
      this.dtWorkoutPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtWorkoutPicker.Location = new System.Drawing.Point(260, 5);
      this.dtWorkoutPicker.Name = "dtWorkoutPicker";
      this.dtWorkoutPicker.Size = new System.Drawing.Size(200, 22);
      this.dtWorkoutPicker.TabIndex = 6;
      this.dtWorkoutPicker.Value = new System.DateTime(2023, 7, 3, 0, 0, 0, 0);
      // 
      // lblWorkoutDate
      // 
      this.lblWorkoutDate.AutoSize = true;
      this.lblWorkoutDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWorkoutDate.ForeColor = System.Drawing.Color.Blue;
      this.lblWorkoutDate.Location = new System.Drawing.Point(29, 2);
      this.lblWorkoutDate.Name = "lblWorkoutDate";
      this.lblWorkoutDate.Size = new System.Drawing.Size(52, 23);
      this.lblWorkoutDate.TabIndex = 5;
      this.lblWorkoutDate.Text = "Date";
      // 
      // WorkoutErrorHandler
      // 
      this.WorkoutErrorHandler.ContainerControl = this;
      // 
      // WorkoutForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(975, 658);
      this.Controls.Add(this.pnlWorkout);
      this.Name = "WorkoutForm";
      this.Text = "Add Workout";
      this.pnlWorkout.ResumeLayout(false);
      this.pnlWorkout.PerformLayout();
      this.pnlWorkoutDate.ResumeLayout(false);
      this.pnlWorkoutDate.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.WorkoutErrorHandler)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlWorkout;
    private System.Windows.Forms.Label lblWorkoutHead;
    private System.Windows.Forms.ComboBox cmbWorkoutTypes;
    private System.Windows.Forms.Label lblWorkoutType;
    private System.Windows.Forms.Button btnAddWorkout;
    private System.Windows.Forms.Panel pnlWorkoutControls;
    private System.Windows.Forms.DateTimePicker dtWorkoutPicker;
    private System.Windows.Forms.Label lblWorkoutDate;
    private System.Windows.Forms.Panel pnlWorkoutDate;
    private System.Windows.Forms.ErrorProvider WorkoutErrorHandler;
  }
}