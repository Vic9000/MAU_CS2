using Assignment1;
using Assignment2;

namespace Assignment1
{
    public partial class MainForm : Form
    {
        private AnimalManager animalManager = new AnimalManager();
        private Animal currAnimal = null;

        public MainForm()
        {
            InitializeComponent();

            InitializeGUI();
        }

        private void InitializeGUI()
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtWeight.Text = "";
            cmbGender.DataSource = Enum.GetValues(typeof(GenderType));
        }

        private void UpdateGUI()
        {
            lbx.Items.Clear(); 

            string[] infoStrings = animalManager.ToStringSummaryAllAnimals();

            if (infoStrings != null)
            {
                lbx.Items.AddRange(infoStrings);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbx.SelectedIndex;

            if (selectedIndex >= 0)
            {
                animalManager.DeleteAt(selectedIndex);

                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Please select an animal from the list to delete.", "Error");
            }
        }
    }
}
