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
                Validator.AssertOnPositiveValue(value, nameof(Duration));
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
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(Release));
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
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }
    }
}
