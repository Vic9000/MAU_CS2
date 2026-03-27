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
            lbxCategory.DataSource = Enum.GetValues(typeof(CategoryType));
        }

        private void UpdateGUI()
        {
            lbxAnimals.Items.Clear();

            string[] infoStrings = animalManager.ToStringSummaryAllAnimals();

            if (infoStrings != null)
            {
                lbxAnimals.Items.AddRange(infoStrings);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Read and validate common inputs
            string name = txtName.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a name for the animal.", "Input Error");
                return;
            }

            if (!double.TryParse(txtAge.Text, out double age) || !double.TryParse(txtWeight.Text, out double weight))
            {
                MessageBox.Show("Please enter valid numbers for Age and Weight.", "Input Error");
                return;
            }

            GenderType gender = (GenderType)cmbGender.SelectedItem;
            string selectedSpecies = lbxSpecies.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedSpecies))
            {
                MessageBox.Show("Please select a species from the list.", "Input Error");
                return;
            }

            Animal newAnimal = null;
            string idPrefix = "U";

            if (selectedSpecies == "Dog" || selectedSpecies == "Cat")
            {
                // Create the dialog and pass in the species
                MammalView mammalDialog = new MammalView(selectedSpecies);

                // ShowDialog() pauses MainForm until the popup is closed
                if (mammalDialog.ShowDialog() == DialogResult.OK)
                {
                    // Grab the completed animal from the dialog property
                    newAnimal = mammalDialog.CreatedMammal;
                    idPrefix = "M"; // 'M' for Mammal
                }
                else
                {
                    return;
                }
            }
            else if (selectedSpecies == "Lizard" || selectedSpecies == "Turtle")
            {
                ReptileView reptileDialog = new ReptileView(selectedSpecies);

                if (reptileDialog.ShowDialog() == DialogResult.OK)
                {
                    newAnimal = reptileDialog.CreatedReptile;
                    idPrefix = "R"; // 'R' for Reptile
                }
                else
                {
                    return;
                }
            }

            if (newAnimal != null)
            {
                newAnimal.Name = name;
                newAnimal.Age = age;
                newAnimal.Weight = weight;
                newAnimal.Gender = gender;

                newAnimal.Id = animalManager.GetNewID(idPrefix);
                animalManager.Add(newAnimal);

                UpdateGUI();

                txtName.Text = "";
                txtAge.Text = "";
                txtWeight.Text = "";
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbxAnimals.SelectedIndex;

            if (selectedIndex >= 0)
            {
                if (!double.TryParse(txtAge.Text, out double age) || !double.TryParse(txtWeight.Text, out double weight))
                {
                    MessageBox.Show("Please enter valid numbers for Age and Weight.", "Input Error");
                    return;
                }

                Animal animalToEdit = animalManager.GetAt(selectedIndex);

                if (animalToEdit != null)
                {
                    // Update the animal's data
                    animalToEdit.Name = txtName.Text;
                    animalToEdit.Age = age;
                    animalToEdit.Weight = weight;
                    animalToEdit.Gender = (GenderType)cmbGender.SelectedItem;

                    UpdateGUI();

                    lbxAnimals.SelectedIndex = selectedIndex;
                }
            }
            else
            {
                MessageBox.Show("Please select an animal from the list to edit.", "Selection Error");
            }
        }

        private void lbxAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Now reading from lbxAnimals
            int selectedIndex = lbxAnimals.SelectedIndex;

            if (selectedIndex >= 0)
            {
                Animal selectedAnimal = animalManager.GetAt(selectedIndex);

                if (selectedAnimal != null)
                {
                    lblInfo1.Text = $"Info About {selectedAnimal.Name}";
                    lbxInfo.Items.Clear();
                    lbxInfo2.Items.Clear();

                    lbxInfo.Items.Add($"ID: {selectedAnimal.Id}");
                    lbxInfo.Items.Add($"Name: {selectedAnimal.Name}");
                    lbxInfo.Items.Add($"Age: {selectedAnimal.Age}");
                    lbxInfo.Items.Add($"Gender: {selectedAnimal.Gender}");

                    string fullInfo = selectedAnimal.ToString();

                    string[] infoLines = fullInfo.Split(new[] { ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string line in infoLines)
                    {
                        lbxInfo2.Items.Add(line.Trim());
                    }

                    txtName.Text = selectedAnimal.Name;
                    txtAge.Text = selectedAnimal.Age.ToString();
                    txtWeight.Text = selectedAnimal.Weight.ToString();
                    cmbGender.SelectedItem = selectedAnimal.Gender;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbxAnimals.SelectedIndex;

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

        private void lbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Make sure something is actually selected to prevent crashes
            if (lbxCategory.SelectedItem == null) return;

            lbxSpecies.Items.Clear();

            CategoryType selectedCategory = (CategoryType)lbxCategory.SelectedItem;

            if (selectedCategory == CategoryType.Mammal)
            {
                lbxSpecies.Items.Add("Dog");
                lbxSpecies.Items.Add("Cat");
            }
            else if (selectedCategory == CategoryType.Reptile)
            {
                lbxSpecies.Items.Add("Lizard");
                lbxSpecies.Items.Add("Turtle");
            }

            if (lbxSpecies.Items.Count > 0)
            {
                lbxSpecies.SelectedIndex = 0;
            }
        }
    }
}
