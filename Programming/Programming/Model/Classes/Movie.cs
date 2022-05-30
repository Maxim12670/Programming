using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Продолжительность фильма в минутах.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Год релиза фильма.
        /// </summary>
        private int _release;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="name">Название фильма.</param>
        /// <param name="duration">Продолжительность фильма в минутах. Должно быть положительным числом.</param>
        /// <param name="release">Год релиза фильма. Должно быть в диапазоне от 1900 до 2022 (включительно).</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтинг фильма. Должен быть в диапазоне от 0 до 10 (включительно).</param>
        public Movie(string name,
                int duration,
                int release,
                string genre,
                double rating)
        {
            Name = name;
            Duration = duration;
            Release = release;
            Genre = genre;
            Rating = rating;
        }
        /// <summary>
        /// Возвращает и задаёт название фильма.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задаёт продолжительность фильма в минутах. Должно быть положительным числом.
        /// </summary>
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт год релиза фильма. Должно быть в диапазоне от 1900 до 2022 (включительно).
        /// </summary>
        public int Release
        {
            get
            {
                return _release;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(Release));
                _release = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт рейтинг фильма. Должен быть в диапазоне от 0 до 10 (включительно).
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }
    }
}
