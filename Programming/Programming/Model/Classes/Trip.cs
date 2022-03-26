using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Trip
    {
        private int _flightTime;

        public Trip()
        {
        }

        public Trip(string departurePoint,
                    string destination,
                    int flightTime)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTime = flightTime;
        }

        public string DeparturePoint { get; set; }

        public string Destination { get; set; }

        public int FlightTime
        {
            get
            {
                return _flightTime;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(message: "Flight duration cannot be negative!");
                }

                _flightTime = value;
            }
        }
    }
}
