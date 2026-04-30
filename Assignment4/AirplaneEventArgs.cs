using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public class AirplaneEventArgs : EventArgs
    {
        public string FlightNumber { get; }
        public string Destination { get; }
        public string StatusMessage { get; }
        public DateTime Timestamp { get; }

        public AirplaneEventArgs(string flightNumber, string destination, string statusMessage, DateTime timestamp)
        {
            FlightNumber = flightNumber;
            Destination = destination;
            StatusMessage = statusMessage;
            Timestamp = DateTime.Now;
        }
    }
}
