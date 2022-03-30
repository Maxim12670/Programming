using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _length;

        private double _width;

        public Rectangle()
        {
        }

        public Rectangle(double length,
                        double width,
                        string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }

        public string Color { get; set; }

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        message: "Length cannot be negative!");
                }

                _length = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        message: "Width cannot be negative!");
                }

                _width = value;
            }
        }
    }
}
