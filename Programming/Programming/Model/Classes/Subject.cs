using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Subject
    {
        private int _rating;

        private int _lessonsNumber;

        public Subject()
        {
        }

        public Subject(string name,
                          int rating,
                          int lessonsNumber)
        {
            Name = name;
            Rating = rating;
            LessonsNumber = lessonsNumber;
        }

        public string Name { get; set; }

        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value < 0 | value > 100)
                {
                    throw new ArgumentException(message: "The rating ranges from 0 to 100!");
                }

                _rating = value;
            }
        }

        public int LessonsNumber
        {
            get
            {
                return _lessonsNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        message: "The lessons number cannot be less than zero!");
                }

                _lessonsNumber = value;
            }
        }
    }
}
