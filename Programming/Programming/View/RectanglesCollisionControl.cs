using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;
using Rectangle = Programming.Model.Classes.Rectangle;
using Point2D = Programming.Model.Classes.Point2D;
using Programming.Model.Classes;

namespace Programming.View.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Цвет фигур, которые не пересекаются.
        /// </summary>
        private readonly Color _normalColorPanel = System.Drawing.Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Цвет пересечения прямоугольников.
        /// </summary>
        private readonly Color _collisionColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Цвет некорретного исхода.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Цвет корретного исхода.
        /// </summary>
        private readonly Color _normalColor = Color.White;

        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Случайные значения.
        /// </summary>
        private Random _random;

        /// <summary>
        /// Коллекция элементов.
        /// </summary>
        private List<Rectangle> _rectangles;

        /// <summary>
        /// Коллекция отображаемых прямоугольников.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Создает экземпляр класса <see cref="RectanglesCollisionControl"/>.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();
            _random = new Random();
            _rectangles = new List<Rectangle>();
        }

        /// <summary>
        /// Функция заполнения значений прямоугольника.
        /// </summary>
        /// <returns>Возвращает прямоугольник со своими значениями.</returns>
        private Rectangle AddRectangles()
        {
            var colors = Enum.GetValues(typeof(Colors));
            _currentRectangle = new Rectangle();
            _currentRectangle.Width = _random.Next(1, 100);
            _currentRectangle.Length = _random.Next(1, 100);
            _currentRectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            _currentRectangle.Center = new Point2D(_random.Next(1, RectanglesPanel.Width), _random.Next(1, RectanglesPanel.Height));
            _rectangles.Add(_currentRectangle);
            RectanglesSelectedListBox.Items.Add($"{_currentRectangle.Id}:" +
                $"X= {_currentRectangle.Center.X}" +
                $"Y= {_currentRectangle.Center.Y}" +
                $"W= {_currentRectangle.Width}" +
                $"H= {_currentRectangle.Length}");
            return _currentRectangle;
        }

        private void AddPanelRectangles(Rectangle rectangle)
        {
            var rectaglePanel = new Panel
            {
                Location = new Point(rectangle.Center.X, rectangle.Center.Y),
                Height = rectangle.Length,
                Width = rectangle.Width,
                BackColor = _normalColorPanel
            };

            RectanglesPanel.Controls.Add(rectaglePanel);
            _rectanglePanels.Add(rectaglePanel);
        }

        /// <summary>
        /// Очищает информацию с текстовых полей и со списка.
        /// </summary>
        private void ClearRectangleInfo()
        {
            IdSelectedTextBox.Clear();
            XSelectedTextBox.Clear();
            YSelectedTextBox.Clear();
            WidthSelectedTextBox.Clear();
            HeightSelectedTextBox.Clear();
            XSelectedTextBox.BackColor = _normalColor;
            YSelectedTextBox.BackColor = _normalColor;
            WidthSelectedTextBox.BackColor = _normalColor;
            HeightSelectedTextBox.BackColor = _normalColor;
        }

        /// <summary>
        /// Из данных прямоугольника преобразует форматированный текст.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        /// <returns>Возвращает форматированный текст.</returns>
        private string FormattedText(Rectangle rectangle)
        {
            return $"{rectangle.Id}:" +
                $"X= {rectangle.Center.X}" +
                $"Y= {rectangle.Center.Y}" +
                $"W= {rectangle.Width}" +
                $"H= {rectangle.Length}";
        }

        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int index = RectanglesSelectedListBox.FindString(rectangle.Id.ToString());

            if (index == -1) return;

            FormattedText(rectangle);
            FindCollisions();
        }

        /// <summary>
        /// Находит пересекающиеся прямоугольники и перекрашивает их.
        /// </summary>
        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                RectanglesPanel.Controls[i].BackColor = _normalColorPanel;
            }

            for (int i = 0; i < _rectanglePanels.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectanglePanels.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        RectanglesPanel.Controls[i].BackColor = _collisionColor;
                        RectanglesPanel.Controls[j].BackColor = _collisionColor;
                    }
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var rectangle = AddRectangles();
            FormattedText(rectangle);
            AddPanelRectangles(rectangle);
            RectanglesSelectedListBox.SelectedIndex = _rectangles.Count - 1;
            FindCollisions();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (RectanglesSelectedListBox.SelectedIndex == -1) return;

            int index = RectanglesSelectedListBox.SelectedIndex;
            _currentRectangle = _rectangles[index];
            FormattedText(_currentRectangle);
            _rectanglePanels.RemoveAt(index);
            _rectangles.RemoveAt(index);
            RectanglesPanel.Controls.RemoveAt(index);
            RectanglesSelectedListBox.Items.RemoveAt(index);
            XSelectedTextBox.BackColor = _normalColor;
            YSelectedTextBox.BackColor = _normalColor;
            WidthSelectedTextBox.BackColor = _normalColor;
            HeightSelectedTextBox.BackColor = _normalColor;
            ClearRectangleInfo();
            RectanglesSelectedListBox.SelectedIndex = _rectangles.Count - 1;
            FindCollisions();
        }

        private void RectanglesSelectedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesSelectedListBox.SelectedItem == null) return;

            int index = RectanglesSelectedListBox.SelectedIndex; ;
            _currentRectangle = _rectangles[index];
            IdSelectedTextBox.Text = _currentRectangle.Id.ToString();
            XSelectedTextBox.Text = _currentRectangle.Center.X.ToString();
            YSelectedTextBox.Text = _currentRectangle.Center.Y.ToString();
            WidthSelectedTextBox.Text = _currentRectangle.Width.ToString();
            HeightSelectedTextBox.Text = _currentRectangle.Length.ToString();
        }

        private void XSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesSelectedListBox.SelectedIndex == -1) return;
            try
            {
                string currentXRectangles = XSelectedTextBox.Text;
                int XRectangleValue = int.Parse(currentXRectangles);
                _currentRectangle.Center.X = XRectangleValue;
                RectanglesPanel.Controls[RectanglesSelectedListBox.SelectedIndex].Location =
                    new Point(_currentRectangle.Center.X,
                    _currentRectangle.Center.Y);
                UpdateRectangleInfo(_currentRectangle);
                FindCollisions();
            }
            catch
            {
                XSelectedTextBox.BackColor = _errorColor;
                return;
            }
            XSelectedTextBox.BackColor = _normalColor;
        }

        private void YSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesSelectedListBox.SelectedIndex == -1) return;
            try
            {
                string currentYRectangles = YSelectedTextBox.Text;
                int YRectangleValue = int.Parse(currentYRectangles);
                _currentRectangle.Center.Y = YRectangleValue;
                RectanglesPanel.Controls[RectanglesSelectedListBox.SelectedIndex].Location =
                    new Point(_currentRectangle.Center.X,
                    _currentRectangle.Center.Y);
                UpdateRectangleInfo(_currentRectangle);
                FindCollisions();
            }
            catch
            {
                YSelectedTextBox.BackColor = _errorColor;
                return;
            }
            YSelectedTextBox.BackColor = _normalColor;
        }

        private void WidthSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesSelectedListBox.SelectedIndex == -1) return;
            try
            {
                string currentWidthRectangle = WidthSelectedTextBox.Text;
                int widthRectangleValue = int.Parse(currentWidthRectangle);
                _currentRectangle.Width = widthRectangleValue;
                RectanglesPanel.Controls[RectanglesSelectedListBox.SelectedIndex].Width = widthRectangleValue;
                UpdateRectangleInfo(_currentRectangle);
                FindCollisions();
            }
            catch
            {
                WidthSelectedTextBox.BackColor = _errorColor;
                return;
            }
            WidthSelectedTextBox.BackColor = _normalColor;
        }

        private void HeightSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesSelectedListBox.SelectedIndex == -1) return;
            try
            {
                string currentHeightRectangle = HeightSelectedTextBox.Text;
                int heightRectangleValue = int.Parse(currentHeightRectangle);
                _currentRectangle.Length = heightRectangleValue;
                RectanglesPanel.Controls[RectanglesSelectedListBox.SelectedIndex].Height = heightRectangleValue;
                UpdateRectangleInfo(_currentRectangle);
                FindCollisions();
            }
            catch
            {
                HeightSelectedTextBox.BackColor = _errorColor;
                return;
            }
            HeightSelectedTextBox.BackColor = _normalColor;
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.Image = global::Programming.Properties.Resources.rectangle_add_24x24;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.Image = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
        }        

        private void DeleteButton_MouseEnter(object sender, EventArgs e)
        {
            DeleteButton.Image = global::Programming.Properties.Resources.rectangle_remove_24x24;
        }
    }
}
