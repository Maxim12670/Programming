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
                if (value < 0)
                {
                    throw new ArgumentException(message: "Duration cannot be negative!");
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
                    throw new ArgumentException(message: "Wrong year selected!");
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
                if (value < 0 | value > 10)
                {
                    throw new ArgumentException(message: "The rating is between 0 and 10!");
                }

                _rating = value;
            }
        }
    }
}
