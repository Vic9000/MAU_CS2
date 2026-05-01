using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class AirplaneEventArgs : EventArgs
    {
        public string PlaneName { get; }
        public string FlightNumber { get; }
        public string Destination { get; }
        public string StatusMessage { get; }
        public DateTime Timestamp { get; }

        public AirplaneEventArgs(string planeName, string flightNumber, string destination, string statusMessage)
        {
            PlaneName = planeName;
            FlightNumber = flightNumber;
            Destination = destination;
            StatusMessage = statusMessage;
            Timestamp = DateTime.Now;
        }
    }
}
