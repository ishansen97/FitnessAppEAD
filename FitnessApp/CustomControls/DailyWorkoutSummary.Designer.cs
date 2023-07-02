
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
      this.SuspendLayout();
      // 
      // lblExerciseTypeLabel
      // 
      this.lblExerciseTypeLabel.AutoSize = true;
      this.lblExerciseTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblExerciseTypeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
      this.lblExerciseType.ForeColor = System.Drawing.SystemColors.ActiveCaption;
      this.lblExerciseType.Location = new System.Drawing.Point(323, 20);
      this.lblExerciseType.Name = "lblExerciseType";
      this.lblExerciseType.Size = new System.Drawing.Size(114, 29);
      this.lblExerciseType.TabIndex = 1;
      this.lblExerciseType.Text = "Exercise";
      // 
      // pnlWorkoutFields
      // 
      this.pnlWorkoutFields.Location = new System.Drawing.Point(20, 70);
      this.pnlWorkoutFields.Name = "pnlWorkoutFields";
      this.pnlWorkoutFields.Size = new System.Drawing.Size(416, 116);
      this.pnlWorkoutFields.TabIndex = 2;
      // 
      // DailyWorkoutSummary
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.WhiteSmoke;
      this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.Controls.Add(this.pnlWorkoutFields);
      this.Controls.Add(this.lblExerciseType);
      this.Controls.Add(this.lblExerciseTypeLabel);
      this.Name = "DailyWorkoutSummary";
      this.Size = new System.Drawing.Size(618, 215);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblExerciseTypeLabel;
    private System.Windows.Forms.Label lblExerciseType;
    private System.Windows.Forms.Panel pnlWorkoutFields;
  }
}
