using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class flight
    {
        private int _time;

        public flight()
        {
        }

        public flight(string departure,
                    string destination,
                    int time)
        {
            Departure = departure;
            Destination = destination;
            Time = time;
        }

        public string Departure { get; set; }

        public string Destination { get; set; }

        public int Time
        {
            get
            {
                return _time;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(message: "Flight duration cannot be negative!");
                }

                _time = value;
            }
        }
    }
}
