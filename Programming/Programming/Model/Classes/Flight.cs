using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private int _time;

        public Flight()
        {
        }

        public Flight(string departure,
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
                Validator.AssertOnPositiveValue(value, nameof(Time));
                _time = value;
            }
        }
    }
}
