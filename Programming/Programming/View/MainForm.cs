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


namespace Programming.View
{
    public partial class MainForm : Form
    {
        private Movie[] _movies;

        private Movie _currentMovie;
        
        const int CountElements = 5;

        private Rectangle[] _rectangles;

        private Rectangle _currentRectangle;

        private Random _randomValues;

        public MainForm()
        {   
            InitializeComponent();
            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
            EnumsListBox.SelectedIndex = 0;
            var valuesColor = Enums.GetValues(typeof(Colors));
            _randomValues = new Random();
            _rectangles = new Rectangle[CountElements];
            for(int i = 0; i < CountElements; i++)
            {
                _currentRectangle = new Rectangle();
                _currentRectangle.Width = _randomValues.Next(100) / 10.0;
                _currentRectangle.Lenght = _randomValues.Next(100) / 10.0;
                _currentRectangle.Color = valuesColor.GetValue(_randomValues.Next(0, valuesColor.Length)).ToString();
                _rectangles[i] = _currentRectangle;
                RectangleListBox.Items.Add($"Rectangle {i + 1}");
            }

            _movies = new Movie[CountElements];
            string nameMovie = "Harry Potter";
            var valuesGenre = Enums.GetValues(typeof(Genre));
            for(int i = 0; i < CountElements; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.Duration = _randomValues.Next(1, 100);
                _currentMovie.Release = _randomValues.Next(1901, 2023);
                _currentMovie.Rating = _randomValues.Next(1, 11);
                _currentMovie.Name = nameMovie;
                _currentMovie.Genre = valuesGenre.GetValue(_randomValues.Next(0, valuesGenre.Length)).ToString();
                _movies[i] = _currentMovie;
                MoviesListBox.Items.Add($"Movies {i + 1}");
            }

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
                OutputWeekdayLabel.Text = $"Это день недели ({weekday} - {(int)weekday})";
            }
            else
            {
                OutputWeekdayLabel.Text = "Нет такого дня недели!";
            }
        }

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexRectangle = RectangleListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndexRectangle];
            LenghtTextBox.Text = _currentRectangle.Lenght.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString() ;
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Lenght = Double.Parse(LenghtTextBox.Text);
                LenghtTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                LenghtTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Double.Parse(WidthTextBox.Text);
                WidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ColorTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                ColorTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
        }

        private int FindRectangleWithMaxWidth(Model.Classes.Rectangle[] rectangles)
        {
            double max = 0;
            int index = 0;
           for(int i = 0; i < rectangles.Length; i++)
           {
                if(rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    index = i;
                }
           }
            return index;
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            RectangleListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexMovie = MoviesListBox.SelectedIndex;
            _currentMovie = _movies[selectedIndexMovie];
            DurationTextBox.Text = _currentMovie.Duration.ToString();
            ReleaseTextBox.Text = _currentMovie.Release.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
            NameTextBox.Text = _currentMovie.Name.ToString();
            GenreTextBox.Text = _currentMovie.Genre.ToString();
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DurationTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                DurationTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
        }

        private void ReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ReleaseTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                ReleaseTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RatingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
        }

        private int FindMovieWithMaxRating(Model.Classes.Movie[] movies)
        {
            double max = 0;
            int index = 0;
            for(int i = 0; i < movies.Length; i++)
            {
                if(movies[i].Rating > max)
                {
                    max = movies[i].Rating;
                    index = i;
                }
            }
            return index;
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }
    }
}
