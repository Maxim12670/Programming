﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Song
    {
        private double _duration;

        public Song()
        {
        }

        public Song(string name,
                    double duration,
                    string genre,
                    string author)
        {
            Name = name;
            Duration = duration;

        }

        public string Author { get; set; }
        public string Genre { get; set; }

        public string Name { get; set; }

        public double Duration
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
    }
}
