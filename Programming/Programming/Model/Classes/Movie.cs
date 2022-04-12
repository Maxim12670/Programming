using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private int _duration;

        private int _release;

        private double _rating;

        public Movie()
        {
        }

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

        public string Name { get; set; }

        public string Genre { get; set; }

        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, "Duration");
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
                if (1900 > value | value > DateTime.Now.Year)
                {
                    throw new ArgumentException(
                        message: "Release is wrong!");
                }

                _release = value;
            }
        }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, "Rating");
                _rating = value;
            }
        }
    }
}
