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
using Programming.View;
using Programming.Model;
using Rectangle = Programming.Model.Classes.Rectangle;
using Movie = Programming.Model.Classes.Movie;
using Point2D = Programming.Model.Classes.Point2D;
using Programming.Model.Classes;


namespace Programming.View
{
    public partial class MainForm : Form
    {
        private const int countElements = 5;

        private readonly Color normalColorPanel = System.Drawing.Color.FromArgb(127, 127, 255, 127);

        private readonly Color confluxColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);

        private readonly Color correctColor = Color.White;

        private readonly Color errorColor = Color.LightPink;

        private readonly Color normalColor = Color.White;

        private Movie[] _movies;

        private Movie _currentMovie;

        //private Rectangle[] _rectangles;

        private Rectangle _currentRectangle;

        private Random _random;

        private List<Rectangle> _rectangles;

        private List<Panel> _rectanglePanels = new List<Panel>();

        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            EnumsListBox.SelectedIndex = 0;
            MakeMovies();
            _random = new Random();
            _rectangles = new List<Rectangle>();
            //MakeRectangle();
        }

        private int FindMovieWithMaxRating(Model.Classes.Movie[] movies)
        {
            double max = 0;
            int index = 0;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating > max)
                {
                    max = movies[i].Rating;
                    index = i;
                }
            }
            return index;
        }

        private int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
        {
            double max = 0;
            int index = 0;
            for (int i = 0; i < rectangles.Count; i++)
            {
                if (rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    index = i;
                }
            }
            return index;
        }

        //private void MakeRectangle()
        //{
        //    //_rectangles = new List<Rectangle>(CountElements);

        //    var valuesColor = Enums.GetValues(typeof(Colors));
        //    _random = new Random();
        //    _rectangles = new Rectangle[CountElements];
        //    for (int i = 0; i < CountElements; i++)
        //    {
        //        _rectangles[i] = (new Rectangle(_random.Next(1, 100),
        //                    _random.Next(1, 100),
        //                    valuesColor.GetValue(_random.Next(0, valuesColor.Length)).ToString(),
        //                    new Model.Classes.Point2D(_random.Next(1, 50), _random.Next(1, 50))));
        //        RectangleListBox.Items.Add($"Rectangle {i + 1}");
        //    }
        //}

        private void MakeMovies()
        {
            _random = new Random();
            _movies = new Movie[countElements];
            string nameMovie = "Harry Potter";
            var valuesGenre = Enums.GetValues(typeof(Genre));
            for (int i = 0; i < countElements; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.Duration = _random.Next(1, 100);
                _currentMovie.Release = _random.Next(1901, 2023);
                _currentMovie.Rating = _random.Next(1, 11);
                _currentMovie.Name = nameMovie;
                _currentMovie.Genre = valuesGenre.GetValue(
                    _random.Next(0, valuesGenre.Length)).ToString();
                _movies[i] = _currentMovie;
                MoviesListBox.Items.Add($"Movies {i + 1}");
            }
        }

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
                BackColor = normalColorPanel
            };

            RectanglesPanel.Controls.Add(rectaglePanel);
            _rectanglePanels.Add(rectaglePanel);
        }

        private void ClearRectangleInfo()
        {
            IdSelectedTextBox.Clear();
            XSelectedTextBox.Clear();
            YSelectedTextBox.Clear();
            WidthSelectedTextBox.Clear();
            HeightSelectedTextBox.Clear();
        }

        private string FormattedText(Rectangle rectangle)
        {
            return $"{rectangle.Id}:" +
                $"X= {rectangle.Center.X}" +
                $"Y= {rectangle.Center.Y}" +
                $"W= {rectangle.Width}" +
                $"H= {rectangle.Length}";
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int ind = RectanglesSelectedListBox.FindString(rectangle.Id.ToString());

            if (ind == -1) return;

            RectanglesSelectedListBox.Items[ind] = $"{rectangle.Id}: " +
                                                  $"(X: {rectangle.Center.X};" +
                                                  $" Y: {rectangle.Center.Y};" +
                                                  $" W: {rectangle.Width};" +
                                                  $" H: {rectangle.Length})";
        }

        private void FindCollisions()
        {
            for(int i = 0; i < _rectanglePanels.Count; i++)
            {
                RectanglesPanel.Controls[i].BackColor = normalColorPanel;  
            }

            for(int i = 0; i < _rectanglePanels.Count - 1; i++)
            {
                for(int j = i + 1; j < _rectanglePanels.Count; j++)
                {
                    if (!CollisionManager.IsCollision(_rectangles[i], _rectangles[j])) continue;
                    
                    RectanglesPanel.Controls[i].BackColor = confluxColor;
                    RectanglesPanel.Controls[j].BackColor = confluxColor; 
                }
            }
        }

        private void EditRectanglePanels(Rectangle rectangle)
        {
            var rectanglePanel = new Panel
            {
                Location = new Point(rectangle.Center.X, rectangle.Center.Y),
                Height = rectangle.Length,
                Width = rectangle.Width,
                BackColor = normalColorPanel
            };

            int index = RectanglesSelectedListBox.SelectedIndex;
            RectanglesPanel.Controls.Add(rectanglePanel);
            RectanglesPanel.Controls.Remove(_rectanglePanels[index]);
            _rectanglePanels[index] = rectanglePanel;
            FindCollisions();
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

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexMovie = MoviesListBox.SelectedIndex;
            _currentMovie = _movies[selectedIndexMovie];
            DurationTextBox.Text = _currentMovie.Duration.ToString();
            ReleaseTextBox.Text = _currentMovie.Release.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
            NameTextBox.Text = _currentMovie.Name.ToString();
            GenreTextBox.Text = _currentMovie.Genre.ToString();
        }

        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Clear();
            switch (EnumsListBox.SelectedItem)
            {
                case Enums.Colors:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Colors));
                    break;

                case Enums.EducationForm:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(EducationForm));
                    break;

                case Enums.Genre:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;

                case Enums.Manufacture:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Manufacture));
                    break;

                case Enums.Season:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;

                case Enums.Weekday:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
            }
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indexItem = ValuesListBox.SelectedItem;
            IntValueTextBox.Text = ((int)indexItem).ToString();
        }
        private void GoButton_Click(object sender, EventArgs e)
        {
            var season = SeasonComboBox.SelectedItem;
            switch (season)
            {
                case Season.Winter:
                    GoButton.BackColor = Color.Transparent;
                    MessageBox.Show("Бррр! Холодно!");
                    break;

                case Season.Spring:
                    GoButton.BackColor = Color.Orange;
                    break;

                case Season.Summer:
                    GoButton.BackColor = Color.Transparent;
                    MessageBox.Show("Ура! Солнце!");
                    break;

                case Season.Autumn:
                    GoButton.BackColor = Color.Yellow;
                    break;
            }
        }
        private void ParseWeekdayButton_Click(object sender, EventArgs e)
        {
            var weekdayText = WeekdayTextBox.Text;
            Weekday weekday;
            if (Enum.TryParse(weekdayText, out weekday))
            {
                OutputWeekdayLabel.Text =
                    $"Это день недели ({weekday} - {(int)weekday})";
            }
            else
            {
                OutputWeekdayLabel.Text = "Нет такого дня недели!";
            }
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = int.Parse(LenghtTextBox.Text);
                LenghtTextBox.BackColor = correctColor;
            }
            catch
            {
                LenghtTextBox.BackColor = errorColor;
                return;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(WidthTextBox.Text);
                WidthTextBox.BackColor = correctColor;
            }
            catch
            {
                WidthTextBox.BackColor = errorColor;
                return;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ColorTextBox.BackColor = correctColor;
            }
            catch
            {
                ColorTextBox.BackColor = errorColor;
                return;
            }
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            RectangleListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DurationTextBox.BackColor = correctColor;
            }
            catch
            {
                DurationTextBox.BackColor = errorColor;
                return;
            }
        }

        private void ReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ReleaseTextBox.BackColor = correctColor;
            }
            catch
            {
                ReleaseTextBox.BackColor = errorColor;
                return;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RatingTextBox.BackColor = correctColor;
            }
            catch
            {
                RatingTextBox.BackColor = errorColor;
                return;
            }
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var rectangle = AddRectangles();
            FormattedText(rectangle);
            AddPanelRectangles(rectangle);
            RectanglesSelectedListBox.SelectedIndex = _rectangles.Count - 1;
            FindCollisions();
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.Image = global::Programming.Properties.Resources.rectangle_add_24x24;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.Image = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void DeleteButton_MouseEnter(object sender, EventArgs e)
        {
            DeleteButton.Image = global::Programming.Properties.Resources.rectangle_remove_24x24;
        }

        private void DeleteButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
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
            XSelectedTextBox.BackColor = normalColor;
            YSelectedTextBox.BackColor = normalColor;
            WidthSelectedTextBox.BackColor = normalColor;
            HeightSelectedTextBox.BackColor = normalColor;
            ClearRectangleInfo();
            RectanglesSelectedListBox.SelectedIndex = _rectangles.Count - 1;
            FindCollisions();
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
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
                XSelectedTextBox.BackColor = normalColor;
                UpdateRectangleInfo(_currentRectangle);
                EditRectanglePanels(_currentRectangle);
            }
            catch
            {
                XSelectedTextBox.BackColor = errorColor;
                return;
            }
            FindCollisions();
        }

        private void YSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesSelectedListBox.SelectedIndex == -1) return;
            try
            {
                string currentYRectangles = YSelectedTextBox.Text;
                int yRectangleValue = int.Parse(currentYRectangles);
                _currentRectangle.Center.Y = yRectangleValue;
                YSelectedTextBox.BackColor = normalColor;
                UpdateRectangleInfo(_currentRectangle);
                EditRectanglePanels(_currentRectangle);
            }
            catch
            {
                YSelectedTextBox.BackColor = errorColor;
                return;
            }
            FindCollisions();
        }

        private void WidthSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesSelectedListBox.SelectedIndex == -1) return;
            try
            {
                string currentWidthRectangle = WidthSelectedTextBox.Text;
                int widthRectangleValue = int.Parse(currentWidthRectangle);
                _currentRectangle.Width = widthRectangleValue;
                WidthSelectedTextBox.BackColor = normalColor;
                UpdateRectangleInfo(_currentRectangle);
                EditRectanglePanels(_currentRectangle);
            }
            catch
            {
                WidthSelectedTextBox.BackColor = errorColor;
                return;
            }
            FindCollisions();
        }

        private void HeightSelectedTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesSelectedListBox.SelectedIndex == -1) return;
            try
            {
                string currentHeightRectangle = HeightSelectedTextBox.Text;
                int heightRectangleValue = int.Parse(currentHeightRectangle);
                _currentRectangle.Length = heightRectangleValue;
                HeightSelectedTextBox.BackColor = normalColor;
                UpdateRectangleInfo(_currentRectangle);
                EditRectanglePanels(_currentRectangle);
            }
            catch
            {
                HeightSelectedTextBox.BackColor = errorColor;
                return;
            }
            FindCollisions();
        }
    }
}
