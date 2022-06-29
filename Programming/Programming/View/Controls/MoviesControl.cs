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
using Programming.Model.Classes;

namespace Programming.View.Controls
{
    /// <summary>
    /// Представляет реализацию по представлению фильмов.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Цвет корректного значения.
        /// </summary>
        private readonly Color _correctColor = Color.White;

        /// <summary>
        /// Цвет некорректного значения.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        /// <summary>
        ///Количество элементов. 
        /// </summary>
        private const int _countElements = 5;

        /// <summary>
        /// Массив фильмов.
        /// </summary>
        private Movie[] _movies;

        /// <summary>
        /// Выбранный фильм.
        /// </summary>
        private Movie _currentMovie;


        /// <summary>
        /// Случайные значения.
        /// </summary>
        private Random _random;

        /// <summary>
        /// Создает экземляр класса <see cref="MoviesControl"/>.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();
            MakeMovies();
        }

        /// <summary>
        /// Инициализирует массив фильмов.
        /// </summary>
        /// <returns>Возвращает массив фильмов.</returns>
        private void MakeMovies()
        {
            _random = new Random();
            _movies = new Movie[_countElements];
            string nameMovie = "Harry Potter";
            var valuesGenre = Enums.GetValues(typeof(Genre));
            for (int i = 0; i < _countElements; i++)
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

        /// <summary>
        /// Находит фильм, чей рейтинг больше остальных.
        /// </summary>
        /// <param name="movies">Массив фильмов.</param>
        /// <returns>Возвращает индекс элемента массива, чей рейтинг больше остальных.</returns>
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

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Duration = int.Parse(DurationTextBox.Text);
                DurationTextBox.BackColor = _correctColor;
            }
            catch
            {
                DurationTextBox.BackColor = _errorColor;
                return;
            }
        }

        private void ReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Release = int.Parse(ReleaseTextBox.Text);
                ReleaseTextBox.BackColor = _correctColor;
            }
            catch
            {
                ReleaseTextBox.BackColor = _errorColor;
                return;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = int.Parse(RatingTextBox.Text);
                RatingTextBox.BackColor = _correctColor;
            }
            catch
            {
                RatingTextBox.BackColor = _errorColor;
                return;
            }
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }
    }
}
