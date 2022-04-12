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
                Validator.AssertValueInRange(value, 0, 100, "Rating");
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
                Validator.AssertOnPositiveValue(value, "LessonsNumber");
                _lessonsNumber = value;
            }
        }
    }
}
