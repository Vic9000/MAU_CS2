using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Assignment4
{
    public class ControlTower
    {
        // Automatically updating list of flights
        public ObservableCollection<Airplane> Flights { get; set; }

        // Events to be passed to MainWindow
        public event EventHandler<AirplaneEventArgs> TowerTakeOffNotification;
        public event EventHandler<AirplaneEventArgs> TowerLandedNotification;

        public ControlTower()
        {
            Flights = new ObservableCollection<Airplane>();
        }

        public void AddFlight(Airplane airplane)
        {
            // Subscribed to airplane events
            airplane.TakeOff += Airplane_TakeOff;
            airplane.Landed += Airplane_Landed;

            Flights.Add(airplane);
        }

        public void SendTakeOffCommand(Airplane airplane)
        {
            // Checks if the plane exists and is allowed to take off
            if (airplane != null && !airplane.InFlight)
            {
                airplane.AuthorizeTakeOff();
            }
        }

        // Handles airplane events and sends them to the GUI
        private void Airplane_TakeOff(object sender, AirplaneEventArgs e)
        {
            TowerTakeOffNotification?.Invoke(this, e);
        }

        private void Airplane_Landed(object sender, AirplaneEventArgs e)
        {
            TowerLandedNotification?.Invoke(this, e);
        }
    }
}
