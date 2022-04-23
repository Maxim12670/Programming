using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private static int _allRectanglesCount;

        private double _lenght;

        private double _width;

        private int _id;        

        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public Rectangle(double lenght,
                        double width,
                        string color,
                        Point2D center)
        {
            Lenght = lenght;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public double Lenght
        {
            get
            {
                return _lenght;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Lenght));
                _lenght = value;
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
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        public int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(AllRectanglesCount));
                _allRectanglesCount = value;
            }
        }
    }
}
