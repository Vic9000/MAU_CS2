using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Assignment4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ControlTower _tower;

        public MainWindow()
        {
            InitializeComponent();
            _tower = new ControlTower();

            // UI subscribes to ControlTower events
            _tower.TowerTakeOffNotification += Tower_FlightEvent;
            _tower.TowerLandedNotification += Tower_FlightEvent;

            // Binds flights ListBox to tower's ObservableCollection
            lstFlights.ItemsSource = _tower.Flights;

            // Setup Realism: Pre-populates the app with entries from the image in the assignment
            _tower.AddFlight(new Airplane("SAAS Caroline", "SAAS 986", "Bangkok", 5));
            _tower.AddFlight(new Airplane("Boing 747 XL", "LFT 123", "New York", 6));

            // Populate the log with the initial "sent to runway" messages seen in your image
            AddSentToRunwayMessage("SAAS Caroline", "SAAS 986", "Bangkok");
            AddSentToRunwayMessage("Boing 747 XL", "LFT 123", "New York");
        }

        private void BtnAddPlane_Click(object sender, RoutedEventArgs e)
        {
            // Ensure inputs are correct and flight time is a number
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtFlightId.Text) ||
                string.IsNullOrWhiteSpace(txtDestination.Text) || !int.TryParse(txtFlightTime.Text, out int flightTime))
            {
                MessageBox.Show("Please enter all flight details correctly, including numeric Flight time.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Create the plane object from UI inputs
            Airplane newPlane = new Airplane(txtName.Text, txtFlightId.Text, txtDestination.Text, flightTime);
            // Tower registers the flight
            _tower.AddFlight(newPlane);

            // Log the "sent to runway" message
            AddSentToRunwayMessage(newPlane.Name, newPlane.FlightNumber, newPlane.Destination);
        }

        private void BtnTakeOff_Click(object sender, RoutedEventArgs e)
        {
            // Process selection from the UI list
            if (lstFlights.SelectedItem is Airplane selectedPlane)
            {
                // Checks to prevent repeated take-off for an airborne plane
                if (selectedPlane.InFlight)
                {
                    MessageBox.Show("This aircraft is already airborne!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Call take-off command from ControlTower
                _tower.SendTakeOffCommand(selectedPlane);
            }
            else
            {
                MessageBox.Show("Please select an aircraft from the 'Current Flights' list to authorize take-off.", "Selection Required", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Status logging 
        private void Tower_FlightEvent(object sender, AirplaneEventArgs e)
        {
            string formattedLogMessage;
            // Use the status message carried by the AirplaneEventArgs payload
            if (e.StatusMessage.Contains("taking off"))
            {
                formattedLogMessage = $"{e.StatusMessage}, {e.Timestamp:HH:mm:ss}!";
            }
            else
            {
                formattedLogMessage = $"{e.StatusMessage}, {e.Timestamp:HH:mm:ss}";
            }

            // Logs formatted message to lbx
            lstLog.Items.Add(formattedLogMessage);
            ScrollLogToEnd();

            // Refreshes the UI flight list
            lstFlights.Items.Refresh();
        }

        // Helper method for generating "sent to runway" log entries
        private void AddSentToRunwayMessage(string planeName, string flightId, string destination)
        {
            // Message format: "Flight ID, heading for Destination sent to runway!"
            string logEntry = $"{planeName}, {flightId}, heading for {destination} sent to runway!";
            lstLog.Items.Add(logEntry);
            ScrollLogToEnd();
        }

        private void ScrollLogToEnd()
        {
            // Auto-scroll logic for better user experience
            if (lstLog.Items.Count > 0)
            {
                lstLog.ScrollIntoView(lstLog.Items[lstLog.Items.Count - 1]);
            }
        }
    }
}