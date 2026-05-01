using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Threading;

namespace Assignment4
{
    public class Airplane
    {
        // Properties
        public string Name { get; set; }
        public string FlightNumber { get; set; }
        public string Destination { get; set; }
        public int FlightTime { get; set; }  // Unit: hours
        public bool InFlight { get; private set; }  // To help prevent repeat take-offs

        // Event delegates
        public event EventHandler<AirplaneEventArgs> TakeOff;
        public event EventHandler<AirplaneEventArgs> Landed;

        private DispatcherTimer _flightTimer;

        public Airplane(string name, string flightNumber, string destination, int flightTime)
        {
            Name = name;
            FlightNumber = flightNumber;
            Destination = destination;
            FlightTime = flightTime;
            InFlight = false;

            // Initialize timer
            _flightTimer = new DispatcherTimer();
            _flightTimer.Tick += FlightTimer_Tick;
        }

        public void AuthorizeTakeOff()
        {
            // Prevents repeated take-offs
            if (InFlight) return;

            InFlight = true;

            _flightTimer.Interval = TimeSpan.FromSeconds(FlightTime);
            _flightTimer.Start();

            // TakeOff event trigger
            string message = $"The aircraft {Name} is taking off, destination {Destination}";
            OnTakeOff(new AirplaneEventArgs(Name, FlightNumber, Destination, message));
        }

        private void FlightTimer_Tick(object sender, EventArgs e)
        {
            // Stop timer to prevent looping
            _flightTimer.Stop();
            InFlight = false;

            // Store current destination to use in Landed message
            string departedDestination = Destination;
            // Change destination to Home when a plane has landed
            Destination = "Home";

            string message = $"{Name} has landed in {departedDestination}";
            OnLanded(new AirplaneEventArgs(Name, FlightNumber, Destination, message));
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
            string status = InFlight ? "(In Flight)" : "(Grounded)";
            return $"{Name},{FlightNumber}, heading for {Destination} {status}";
        }
    }
}
