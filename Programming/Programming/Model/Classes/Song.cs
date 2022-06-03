using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Продолжительность песни в секундах.
        /// </summary>
        private double _duration;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название песни.</param>
        /// <param name="duration">Продолжительность песни в секундах. Должна быть положительной.</param>
        /// <param name="genre">Жанр песни.</param>
        /// <param name="author">Автор песни.</param>
        public Song(string name,
                    double duration,
                    string genre,
                    string author)
        {
            Name = name;
            Duration = duration;

        }

        /// <summary>
        /// Возвращает и задаёт имя музыканта.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Возвращает и задает жанр песни.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт продолжительность песни в секундах. Должно быть положительным числом.
        /// </summary>
        public double Duration
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
    }
}
