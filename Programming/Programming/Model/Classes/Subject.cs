using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о дисциплине.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Рейтинг.
        /// </summary>
        private int _rating;

        /// <summary>
        /// Количество уроков.
        /// </summary>
        private int _lessonsNumber;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        public Subject()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="name">Название предмета.</param>
        /// <param name="rating">Рейтинг. Должен быть в пределах от 0 до 100.</param>
        /// <param name="lessonsNumber">Количество уроков. Должно быть положительным числом.</param>
        public Subject(string name,
                          int rating,
                          int lessonsNumber)
        {
            Name = name;
            Rating = rating;
            LessonsNumber = lessonsNumber;
        }
        
        /// <summary>
        /// Возвращает и задает название предмета.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает рейтинг по предметам. Должен находится в диапозоне от 0 до 100.
        /// </summary>
        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 100, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// Возвращает и задает колличество уроков. Должно быть положительным числом.
        /// </summary>
        public int LessonsNumber
        {
            get
            {
                return _lessonsNumber;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(LessonsNumber));
                _lessonsNumber = value;
            }
        }
    }
}
