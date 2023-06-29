using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessApp.Business.Handlers;
using FitnessApp.Helpers;

namespace FitnessApp.CustomControls
{
  public class DetailPanel : Panel
  {
    private readonly WorkoutService _workoutService;
    private readonly CheatMealService _cheatMealService;
    private readonly bool _isWorkout;
    private readonly Size _size;
    private readonly int _margin;
    private readonly int _index;
    private DetailHelper _detailHelper;

    public event EventHandler CloseMainForm;

    public DetailPanel(int index, DetailHelper detailHelper, Size size, int margin, bool isWorkout)
    {
      _index = index;
      _isWorkout = isWorkout;
      _size = size;
      _margin = margin;
      _workoutService = new WorkoutService();
      _cheatMealService = new CheatMealService();
      _detailHelper = detailHelper;
      CreatePanel();
    }

    private void CreatePanel()
    {
      Location = new Point(0, _margin * _index);
      Size = new Size(_size.Width, 70);
      BackColor = Color.AliceBlue;
      CreateHeadLabel();
      CreateButtons();
    }

    private void CreateButtons()
    {
      CreateDetailsButton();
      CreateEditButton();
      CreateDeleteButton();
    }

    private void CreateDetailsButton()
    {
      double newX = _size.Width * 0.7;
      Button button = new Button();
      button.BackgroundImage = Properties.Resources.details_small;
      button.BackgroundImageLayout = ImageLayout.Stretch;
      button.Text = string.Empty;
      button.Size = new Size(30, 30);
      button.Location = new Point((int)newX, 20);
      button.Name = $"btnDetails{_index}";
      button.Click += ViewButtonOnClick;
      Controls.Add(button);
    }

    private void CreateEditButton()
    {
      double newX = _size.Width * 0.8;
      Button button = new Button();
      button.BackgroundImage = Properties.Resources.edit_small;
      button.BackgroundImageLayout = ImageLayout.Stretch;
      button.ForeColor = Color.Blue;
      button.Text = string.Empty;
      button.Size = new Size(30, 30);
      button.Location = new Point((int)newX, 20);
      button.Name = $"btnEdit{_index}";
      button.Click += EditButtonOnClick;
      Controls.Add(button);
    }

    private void CreateDeleteButton()
    {
      double newX = _size.Width * 0.9;
      Button button = new Button();
      button.BackgroundImage = Properties.Resources.delete_small;
      button.BackgroundImageLayout = ImageLayout.Stretch;
      button.ForeColor = Color.Red;
      button.Text = string.Empty;
      button.Size = new Size(30, 30);
      button.Location = new Point((int)newX, 20);
      button.Name = $"btnDelete{_index}";
      button.Click += DeleteButtonOnClick;
      Controls.Add(button);
    }


    private void CreateHeadLabel()
    {
      Label label = new Label();
      label.Text = _detailHelper.GetHeader();
      label.Location = new Point(10, 10);
      label.Font = new Font("Arial", 12.0F, System.Drawing.FontStyle.Regular,
        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      Controls.Add(label);
    }

    #region Button Event Handlers
    private void ViewButtonOnClick(object sender, EventArgs e)
    {
      Button viewButton = sender as Button;
      MessageBox.Show($"{viewButton.Name}, {_isWorkout}, {_detailHelper.Detail.Id}");
    }

    private void EditButtonOnClick(object sender, EventArgs e)
    {
      Button editButton = sender as Button;
      MessageBox.Show($"{editButton.Name}, {_isWorkout}, {_detailHelper.Detail.Id}");
    }

    private void DeleteButtonOnClick(object sender, EventArgs e)
    {
      Button deleteButton = sender as Button;
      string text = _isWorkout ? "workout" : "cheat meal";
      var result = MessageBox.Show($"Are you sure you want to delete this {text}?", "delete", MessageBoxButtons.OKCancel);

      if (result == DialogResult.OK)
      {
        int id = _detailHelper.Detail.Id;
        if (_isWorkout)
        {
          _workoutService.DeleteWorkout(id);
        }
        else
        {
          _cheatMealService.DeleteCheatMeal(id);
        }
        // close main form
        CloseMainForm?.Invoke(this, e);
        // open new viewForm
        ViewInfoForm form = new ViewInfoForm(_isWorkout);
        form.Activate();
        form.ShowDialog();
      }
    }
    #endregion
  }
}
