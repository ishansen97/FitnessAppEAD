using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessApp.Models;
using FitnessApp.Models.Enums;

namespace FitnessApp.Helpers
{
    public static class FormControlHelper
    {
      public static Control[] GetExerciseTypeControls(ExerciseType exerciseType)
      {
        Control[] controls = null;

        switch (exerciseType)
        {
          case ExerciseType.Walking:
          case ExerciseType.Running:
          case ExerciseType.Cycling:
            controls = CreateDistanceControls();
            break;
          case ExerciseType.Plank:
            controls = CreateTimeControls();
            break;
          case ExerciseType.BenchPress:
          case ExerciseType.BicepCurls:
          case ExerciseType.DeadLifts:
          case ExerciseType.LegPress:
            controls = CreateCompositeControls();
            break;
          case ExerciseType.Pushups:
          case ExerciseType.Pullups:
          case ExerciseType.Crunches:
          case ExerciseType.Squats:
            controls = CreateRepControls(0);
            break;
        }

        return controls;
      }

      private static Control[] CreateCompositeControls()
      {
        // create weight label.
        Label weightLabel = new Label();
        weightLabel.Location = new Point(24, 0);
        weightLabel.Text = "Weight (kg)".ToString(CultureInfo.InvariantCulture);
        weightLabel.ForeColor = Color.Blue;
        weightLabel.Font = new Font("Arial", 12.0F, System.Drawing.FontStyle.Regular,
          System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        weightLabel.Name = "lblWeight";

        // create weight textBox
        TextBox weightTextBox = new TextBox();
        weightTextBox.Font = new Font("Arial", 12.0F, System.Drawing.FontStyle.Regular,
          System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        weightTextBox.Location = new Point(200, 0);
        weightTextBox.Size = new Size(139, 30);
        weightTextBox.Name = "txtWeight";
        weightTextBox.Tag = "Weight";

        Control[] repControls = CreateRepControls(50);

        return new Control[] { weightLabel, weightTextBox, repControls[0], repControls[1] };
      }

      private static Control[] CreateRepControls(int yAxis)
      {
        // create reps label.
        Label repsLabel = new Label();
        repsLabel.Location = new Point(24, yAxis);
        repsLabel.Text = "Reps".ToString(CultureInfo.InvariantCulture);
        repsLabel.ForeColor = Color.Blue;
        repsLabel.Font = new Font("Arial", 12.0F, System.Drawing.FontStyle.Regular,
          System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        repsLabel.Name = "lblReps";

        // create reps textBox
        TextBox repsTextBox = new TextBox();
        repsTextBox.Font = new Font("Arial", 12.0F, System.Drawing.FontStyle.Regular,
          System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        repsTextBox.Location = new Point(200, yAxis);
        repsTextBox.Size = new Size(139, 30);
        repsTextBox.Name = "txtReps";
        repsTextBox.Tag = "Rep Count";

        return new Control[] { repsLabel, repsTextBox };
      }

      private static Control[] CreateDistanceControls()
      {
        // create label.
        Label label = new Label();
        label.Location = new Point(24, 0);
        label.Text = "Distance (km)".ToString(CultureInfo.InvariantCulture);
        label.ForeColor = Color.Blue;
        label.Font = new Font("Arial", 12.0F, System.Drawing.FontStyle.Regular,
          System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        label.Name = "lblDistance";

        // create textBox
        TextBox textBox = new TextBox();
        textBox.Font = new Font("Arial", 12.0F, System.Drawing.FontStyle.Regular,
          System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        textBox.Location = new Point(200, 0);
        textBox.Size = new Size(139, 30);
        textBox.Name = "txtDistance";
        textBox.Tag = "Distance";

        return new Control[] {label, textBox};
      }

      private static Control[] CreateTimeControls()
      {
        // create label.
        Label label = new Label();
        label.Location = new Point(24, 0);
        label.Text = "Time (minutes)".ToString(CultureInfo.InvariantCulture);
        label.ForeColor = Color.Blue;
        label.Font = new Font("Arial", 12.0F, System.Drawing.FontStyle.Regular,
          System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        label.Name = "lblTime";

        // create textBox
        TextBox textBox = new TextBox();
        textBox.Font = new Font("Arial", 12.0F, System.Drawing.FontStyle.Regular,
          System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        textBox.Location = new Point(200, 0);
        textBox.Size = new Size(139, 30);
        textBox.Name = "txtTime";
        textBox.Tag = "Time";

        return new Control[] {label, textBox};
      }
    }
}
