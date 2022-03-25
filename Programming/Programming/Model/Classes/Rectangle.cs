using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _lenght;
        private double _width;

        public Rectangle()
        {
        }

        public Rectangle(double lenght,
                        double width,
                        string color)
        {

        }

        public string Color { get; set; }

        public double Lenght
        {
            get
            {
                return _lenght;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(message: "Длина не может быть отрицательной!");
                }

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
                if (value < 0)
                {
                    throw new ArgumentException(message: "Ширина не может быть отрицательной!");
                }

                _width = value;
            }
        }
    }
}
