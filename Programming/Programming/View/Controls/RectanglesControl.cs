using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Enums;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.View.Controls
{
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Цвет корректного исхода.
        /// </summary>
        private readonly Color _correctColor = Color.White;

        /// <summary>
        /// Цвет некорректного исхода.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Количество элементов.
        /// </summary>
        private const int _countElements = 5;

        /// <summary>
        /// Коллекция прямоугольников.
        /// </summary>
        private Rectangle[] _rectangles;

        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Случайные значения.
        /// </summary>
        private Random _random;

        /// <summary>
        /// Создает экземпляр класса <see cref="RectanglesControl"/>.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();
            _random = new Random();
            MakeRectangle();
        }

        /// <summary>
        /// Инициализирует массив прямоугольников.
        /// </summary>
        private void MakeRectangle()
        {
            _rectangles = new Rectangle [_countElements];

            var valuesColor = Enums.GetValues(typeof(Colors));
            _random = new Random();
            _rectangles = new Rectangle[_countElements];
            for (int i = 0; i < _countElements; i++)
            {
                _rectangles[i] = (new Rectangle(_random.Next(1, 100),
                            _random.Next(1, 100),
                            valuesColor.GetValue(_random.Next(0, valuesColor.Length)).ToString(),
                            new Model.Classes.Point2D(_random.Next(1, 50), _random.Next(1, 50))));
                RectangleListBox.Items.Add($"Rectangle {i + 1}");
            }
        }
        /// <summary>
        /// Находит прямоугольник с наибольшей шириной.
        /// </summary>
        /// <param name="rectangles"></param>
        /// <returns>Индекс элемента массива с наибольшей шириной.</returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            double max = 0;
            int index = 0;
            for (int i = 0; i < _countElements; i++)
            {
                if (rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    index = i;
                }
            }
            return index;
        }

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexRectangle = RectangleListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndexRectangle];
            LenghtTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            RectangleListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = int.Parse(LenghtTextBox.Text);
                LenghtTextBox.BackColor = _correctColor;
            }
            catch
            {
                LenghtTextBox.BackColor = _errorColor;
                return;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(WidthTextBox.Text);
                WidthTextBox.BackColor = _correctColor;
            }
            catch
            {
                WidthTextBox.BackColor = _errorColor;
                return;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Color = ColorTextBox.Text;
                ColorTextBox.BackColor = _correctColor;
            }
            catch
            {
                ColorTextBox.BackColor = _errorColor;
                return;
            }
        }
    }
}
