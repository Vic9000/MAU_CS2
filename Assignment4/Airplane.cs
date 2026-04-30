using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Threading;

namespace Assignment4
{
    public class Airplane
    {
        // Properties
        public string FlightNumber { get; set; }
        public string Destination { get; set; }
        public int FlightTime { get; set; }  // Unit: hours
        public bool InFlight { get; private set; }  // To help prevent repeat take-offs

        // Event delegates
        public event EventHandler<AirplaneEventArgs> TakeOff;
        public event EventHandler<AirplaneEventArgs> Landed;

        private DispatcherTimer dispatchTimer;

        public Airplane(string flightNumber, string destination, int flightTime)
        {
            FlightNumber = flightNumber;
            Destination = destination;
            FlightTime = flightTime;
            InFlight = false;

            // Initialize timer
            dispatchTimer = new DispatcherTimer();
            dispatchTimer.Tick += DispatchTimer_Tick;
        }

        public void AuthorizeTakeOff()
        {
            // Prevents repeated take-offs
            if (InFlight) return;

            InFlight = true;

            dispatchTimer.Interval = TimeSpan.FromSeconds(FlightTime);
            dispatchTimer.Start();

            // TakeOff event trigger
            string message = $"Flight {FlightNumber} has taken off for {Destination}.";
            OnTakeOff(new AirplaneEventArgs(FlightNumber, Destination, message));
        }

        private void DispatchTimer_Tick(object sender, EventArgs e)
        {
            // Stop timer to prevent looping
            dispatchTimer.Stop();
            InFlight = false;

            Destination = "Home";

            string message = $"Flight {FlightNumber} has safely landed.";
            OnLanded(new AirplaneEventArgs(FlightNumber, Destination, message));
        }

        protected virtual void OnTakeOff(AirplaneEventArgs e)
        {
            TakeOff?.Invoke(this, e);
        }

        protected virtual void OnLanded(AirplaneEventArgs e)
        {
            Landed?.Invoke(this, e);
        }

        // Helper function for displaying the info in a ListBox
        public override string ToString()
        {
            string status = InFlight ? "Airborne" : "Grounded";
            return $"{FlightNumber} -> {Destination} ({status})";
        }
    }
}
