using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Discipline
    {
        private string _subject;
        private int _rating;
        private int _numberOfLessons;

        public Discipline()
        {
        }

        public Discipline(string subject,
                          int rating,
                          int numberOfLessons)
        {
            Subject = subject;
            Rating = rating;
            NumberOfLessons = numberOfLessons;
        }

        public string Subject { get; set; }

        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value > 100 | value < 0)
                {
                    throw new ArgumentException(message: "Рейтин находится в промежутке от 0 до 100!");
                }

                _rating = value;
            }
        }

        public int NumberOfLessons
        {
            get
            {
                return _numberOfLessons;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(message: "Количество уроков не может быть меньше нуля!");
                }

                _numberOfLessons = value;
            }
        }
    }
}
