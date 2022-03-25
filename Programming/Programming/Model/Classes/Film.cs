using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Film
    {
        private string _name;
        private int _duration;
        private int _release;
        private string _genre;
        private double _rating;

        public Film()
        {
        }

        public Film(string name,
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

        public string Name { get; set; }

        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(message: "Продолжительность не может быть отрицательной!");
                }

                _duration = value;
            }
        }

        public int Release
        {
            get
            {
                return _release;
            }
            set
            {
                if(value < 1900)
                {
                    throw new ArgumentException(message: "Неверно выбран год!");
                }

                _release = value;
            }
        }

        public string Genre { get; set; }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value < 0 | value > 10)
                {
                    throw new ArgumentException(message: "Рейтинг находится в промежутке от 0 до 10!");
                }

                _rating = value;
            }
        }
    }
}
