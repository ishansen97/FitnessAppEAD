
namespace FitnessApp.CustomControls
{
  partial class DailyWorkoutSummary
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.lblExerciseTypeLabel = new System.Windows.Forms.Label();
      this.lblExerciseType = new System.Windows.Forms.Label();
      this.pnlWorkoutFields = new System.Windows.Forms.Panel();
      this.lblCalorieValue = new System.Windows.Forms.Label();
      this.lblCalories = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblExerciseTypeLabel
      // 
      this.lblExerciseTypeLabel.AutoSize = true;
      this.lblExerciseTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblExerciseTypeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.lblExerciseTypeLabel.Location = new System.Drawing.Point(16, 20);
      this.lblExerciseTypeLabel.Name = "lblExerciseTypeLabel";
      this.lblExerciseTypeLabel.Size = new System.Drawing.Size(180, 29);
      this.lblExerciseTypeLabel.TabIndex = 0;
      this.lblExerciseTypeLabel.Text = "Exercise Type";
      // 
      // lblExerciseType
      // 
      this.lblExerciseType.AutoSize = true;
      this.lblExerciseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblExerciseType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.lblExerciseType.Location = new System.Drawing.Point(323, 20);
      this.lblExerciseType.Name = "lblExerciseType";
      this.lblExerciseType.Size = new System.Drawing.Size(114, 29);
      this.lblExerciseType.TabIndex = 1;
      this.lblExerciseType.Text = "Exercise";
      // 
      // pnlWorkoutFields
      // 
      this.pnlWorkoutFields.Location = new System.Drawing.Point(20, 140);
      this.pnlWorkoutFields.Name = "pnlWorkoutFields";
      this.pnlWorkoutFields.Size = new System.Drawing.Size(416, 101);
      this.pnlWorkoutFields.TabIndex = 2;
      // 
      // lblCalorieValue
      // 
      this.lblCalorieValue.AutoSize = true;
      this.lblCalorieValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCalorieValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.lblCalorieValue.Location = new System.Drawing.Point(323, 78);
      this.lblCalorieValue.Name = "lblCalorieValue";
      this.lblCalorieValue.Size = new System.Drawing.Size(98, 29);
      this.lblCalorieValue.TabIndex = 4;
      this.lblCalorieValue.Text = "Calorie";
      // 
      // lblCalories
      // 
      this.lblCalories.AutoSize = true;
      this.lblCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCalories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.lblCalories.Location = new System.Drawing.Point(16, 78);
      this.lblCalories.Name = "lblCalories";
      this.lblCalories.Size = new System.Drawing.Size(173, 29);
      this.lblCalories.TabIndex = 3;
      this.lblCalories.Text = "Calorie Spent";
      // 
      // DailyWorkoutSummary
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(214)))), ((int)(((byte)(212)))), ((int)(((byte)(230)))));
      this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.Controls.Add(this.lblCalorieValue);
      this.Controls.Add(this.lblCalories);
      this.Controls.Add(this.pnlWorkoutFields);
      this.Controls.Add(this.lblExerciseType);
      this.Controls.Add(this.lblExerciseTypeLabel);
      this.Name = "DailyWorkoutSummary";
      this.Size = new System.Drawing.Size(496, 259);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblExerciseTypeLabel;
    private System.Windows.Forms.Label lblExerciseType;
    private System.Windows.Forms.Panel pnlWorkoutFields;
    private System.Windows.Forms.Label lblCalorieValue;
    private System.Windows.Forms.Label lblCalories;
  }
}
