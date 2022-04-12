using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    class Point2D
    {
        private double _x;

        private double _y;

        public Point2D() 
        {
        }

        public Point2D(int x,
                       int y)
        {
            X = x;
            Y = y;
        }

        public double X
        {
            get
            {
                return _x;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, "X");
                _x = value;
            }
        }

        public double Y
        {
            get
            {
                return _x;
            }
            private set
            {
                Validator.AssertOnPositiveValue(value, "Y");
                _x = value;
            }
        }
    }
}
