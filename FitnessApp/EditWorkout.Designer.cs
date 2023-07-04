
namespace FitnessApp
{
  partial class EditWorkout
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
      this.lblEditWorkoutHeader = new System.Windows.Forms.Label();
      this.pnlEditWorkout = new System.Windows.Forms.Panel();
      this.btnEdit = new System.Windows.Forms.Button();
      this.dtWorkoutDate = new System.Windows.Forms.DateTimePicker();
      this.lblWorkoutDate = new System.Windows.Forms.Label();
      this.pnlFields = new System.Windows.Forms.Panel();
      this.lblWorkoutTypeValue = new System.Windows.Forms.Label();
      this.lblWorkoutType = new System.Windows.Forms.Label();
      this.EditWorkoutErrorHandler = new System.Windows.Forms.ErrorProvider(this.components);
      this.pb2 = new System.Windows.Forms.PictureBox();
      this.pb1 = new System.Windows.Forms.PictureBox();
      this.pnlEditWorkout.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditWorkoutErrorHandler)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
      this.SuspendLayout();
      // 
      // lblEditWorkoutHeader
      // 
      this.lblEditWorkoutHeader.AutoSize = true;
      this.lblEditWorkoutHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEditWorkoutHeader.Location = new System.Drawing.Point(340, 61);
      this.lblEditWorkoutHeader.Name = "lblEditWorkoutHeader";
      this.lblEditWorkoutHeader.Size = new System.Drawing.Size(189, 32);
      this.lblEditWorkoutHeader.TabIndex = 0;
      this.lblEditWorkoutHeader.Text = "Edit Workout";
      // 
      // pnlEditWorkout
      // 
      this.pnlEditWorkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))), ((int)(((byte)(230)))));
      this.pnlEditWorkout.Controls.Add(this.btnEdit);
      this.pnlEditWorkout.Controls.Add(this.dtWorkoutDate);
      this.pnlEditWorkout.Controls.Add(this.lblWorkoutDate);
      this.pnlEditWorkout.Controls.Add(this.pnlFields);
      this.pnlEditWorkout.Controls.Add(this.lblWorkoutTypeValue);
      this.pnlEditWorkout.Controls.Add(this.lblWorkoutType);
      this.pnlEditWorkout.Location = new System.Drawing.Point(156, 104);
      this.pnlEditWorkout.Name = "pnlEditWorkout";
      this.pnlEditWorkout.Size = new System.Drawing.Size(662, 410);
      this.pnlEditWorkout.TabIndex = 3;
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
      // dtWorkoutDate
      // 
      this.dtWorkoutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtWorkoutDate.Location = new System.Drawing.Point(335, 133);
      this.dtWorkoutDate.Name = "dtWorkoutDate";
      this.dtWorkoutDate.Size = new System.Drawing.Size(167, 22);
      this.dtWorkoutDate.TabIndex = 4;
      // 
      // lblWorkoutDate
      // 
      this.lblWorkoutDate.AutoSize = true;
      this.lblWorkoutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWorkoutDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.lblWorkoutDate.Location = new System.Drawing.Point(55, 130);
      this.lblWorkoutDate.Name = "lblWorkoutDate";
      this.lblWorkoutDate.Size = new System.Drawing.Size(57, 25);
      this.lblWorkoutDate.TabIndex = 3;
      this.lblWorkoutDate.Text = "Date";
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
      // lblWorkoutTypeValue
      // 
      this.lblWorkoutTypeValue.AutoSize = true;
      this.lblWorkoutTypeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWorkoutTypeValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.lblWorkoutTypeValue.Location = new System.Drawing.Point(334, 66);
      this.lblWorkoutTypeValue.Name = "lblWorkoutTypeValue";
      this.lblWorkoutTypeValue.Size = new System.Drawing.Size(148, 25);
      this.lblWorkoutTypeValue.TabIndex = 1;
      this.lblWorkoutTypeValue.Text = "Workout Type";
      // 
      // lblWorkoutType
      // 
      this.lblWorkoutType.AutoSize = true;
      this.lblWorkoutType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWorkoutType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.lblWorkoutType.Location = new System.Drawing.Point(55, 66);
      this.lblWorkoutType.Name = "lblWorkoutType";
      this.lblWorkoutType.Size = new System.Drawing.Size(148, 25);
      this.lblWorkoutType.TabIndex = 0;
      this.lblWorkoutType.Text = "Workout Type";
      // 
      // EditWorkoutErrorHandler
      // 
      this.EditWorkoutErrorHandler.ContainerControl = this;
      // 
      // pb2
      // 
      this.pb2.Image = global::FitnessApp.Properties.Resources.dumbbell_32;
      this.pb2.Location = new System.Drawing.Point(618, 61);
      this.pb2.Name = "pb2";
      this.pb2.Size = new System.Drawing.Size(40, 37);
      this.pb2.TabIndex = 2;
      this.pb2.TabStop = false;
      // 
      // pb1
      // 
      this.pb1.Image = global::FitnessApp.Properties.Resources.running_32;
      this.pb1.Location = new System.Drawing.Point(554, 61);
      this.pb1.Name = "pb1";
      this.pb1.Size = new System.Drawing.Size(39, 37);
      this.pb1.TabIndex = 1;
      this.pb1.TabStop = false;
      // 
      // EditWorkout
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlDark;
      this.BackgroundImage = global::FitnessApp.Properties.Resources.edit_workout_form_modified;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(963, 555);
      this.Controls.Add(this.pnlEditWorkout);
      this.Controls.Add(this.pb2);
      this.Controls.Add(this.pb1);
      this.Controls.Add(this.lblEditWorkoutHeader);
      this.Name = "EditWorkout";
      this.Text = "Edit Workout";
      this.pnlEditWorkout.ResumeLayout(false);
      this.pnlEditWorkout.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.EditWorkoutErrorHandler)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblEditWorkoutHeader;
    private System.Windows.Forms.PictureBox pb1;
    private System.Windows.Forms.PictureBox pb2;
    private System.Windows.Forms.Panel pnlEditWorkout;
    private System.Windows.Forms.Panel pnlFields;
    private System.Windows.Forms.Label lblWorkoutTypeValue;
    private System.Windows.Forms.Label lblWorkoutType;
    private System.Windows.Forms.DateTimePicker dtWorkoutDate;
    private System.Windows.Forms.Label lblWorkoutDate;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.ErrorProvider EditWorkoutErrorHandler;
  }
}