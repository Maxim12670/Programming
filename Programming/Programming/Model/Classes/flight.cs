using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о рейсе.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Время полёта в минутах.
        /// </summary>
        private int _time;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departure">Место отправления.</param>
        /// <param name="destination">Место прибытия</param>
        /// <param name="time">Время полёта в минутах. Должно быть положительным числом.</param>
        public Flight(string departure,
                    string destination,
                    int time)
        {
            Departure = departure;
            Destination = destination;
            Time = time;
        }

        /// <summary>
        /// Возвращает и задаёт место отправления.
        /// </summary>
        public string Departure { get; set; }

        /// <summary>
        /// Возвращает и задаёт место прибытия.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задаёт время полёта в минутах. Должно быть положительным числом.
        /// </summary>
        public int Time
        {
            get
            {
                return _time;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Time));
                _time = value;
            }
        }
    }
}
