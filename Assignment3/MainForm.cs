using Assignment3;
using System.IO;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        private AnimalManager animalManager = new AnimalManager();
        private Animal currAnimal = null;

        // Tracks the current file being worked with
        private string currentFileName = string.Empty;
        private string currentFileType = string.Empty;

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
            cmbFilter.DataSource = Enum.GetValues(typeof(FilterViews));
            txtFilterAge.Visible = false;
        }

        private void UpdateGUI()
        {
            lbxAnimals.Items.Clear();
            lbxInfo.Items.Clear();
            lbxInfo2.Items.Clear();

            string[] infoStrings = animalManager.ToStringSummaryAllAnimals();

            if (infoStrings != null)
            {
                lbxAnimals.Items.AddRange(infoStrings);
            }
        }

        private void UpdateFilterListBox(List<Animal> filteredAnimals)
        {
            lbxFilter.Items.Clear();
            foreach (Animal a in filteredAnimals)
            {
                lbxFilter.Items.Add(a.ToStringSummary());
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
            UpdateGUI();
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

        private void SaveData()
        {
            try
            {
                if (currentFileType == "JSON")
                {
                    animalManager.SaveToJson(currentFileName);
                }
                else if (currentFileType == "Text")
                {
                    animalManager.SaveToText(currentFileName);
                }

                MessageBox.Show("Data saved successfully!", "Success");
            }
            catch (Exception ex) //
            {
                MessageBox.Show(ex.ToString(), "Error Saving File");
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set up the dialog to show JSON and TXT files
            saveFileDialog1.Filter = "JSON Files (*.json)|*.json|Text Files (*.txt)|*.txt";
            saveFileDialog1.Title = "Save Animal Data";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Remember the chosen file and figure out the type based on the extension
                currentFileName = saveFileDialog1.FileName;
                currentFileType = Path.GetExtension(currentFileName).ToLower() == ".json" ? "JSON" : "Text";

                SaveData();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If we don't have a file yet, act like "Save As"
            if (string.IsNullOrEmpty(currentFileName))
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                SaveData();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JSON Files (*.json)|*.json|Text Files (*.txt)|*.txt";
            openFileDialog1.Title = "Open Animal Data";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFileName = openFileDialog1.FileName;
                currentFileType = Path.GetExtension(currentFileName).ToLower() == ".json" ? "JSON" : "Text";

                try
                {
                    if (currentFileType == "JSON")
                    {
                        animalManager.LoadFromJson(currentFileName);
                    }
                    else if (currentFileType == "Text")
                    {
                        animalManager.LoadFromText(currentFileName);
                    }

                    UpdateGUI();
                    MessageBox.Show("Data loaded successfully!", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error Loading File");
                }
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedItem == null) return;

            FilterViews selectedView = (FilterViews)cmbFilter.SelectedItem;

            if (selectedView == FilterViews.Age) 
            {
                txtFilterAge.Visible = true;
                lbxFilter.Items.Clear(); 
                return; 
            }
            else
            {
                txtFilterAge.Visible = false;
                txtFilterAge.Text = "";
            }

            List<Animal> results = new List<Animal>();

            switch (selectedView)
            {
                case FilterViews.None:
                    for (int i = 0; i < animalManager.Count; i++)
                    {
                        results.Add(animalManager.GetAt(i));
                    }
                    break;

                case FilterViews.Dogs:
                    results = animalManager.GetAllDogs();
                    break;

                case FilterViews.Cats:
                    results = animalManager.GetAllCats();
                    break;

                case FilterViews.Lizards:
                    results = animalManager.GetAllLizards();
                    break;

                case FilterViews.Turtles:
                    results = animalManager.GetAllTurtles();
                    break;

                case FilterViews.Sort:
                    results = animalManager.SortAnimalsByName();
                    break;
            }

            UpdateFilterListBox(results);
        }

        private void txtFilterAge_TextChanged(object sender, EventArgs e)
        {
            // Only attempt the LINQ query if a valid number was typed
            if (double.TryParse(txtFilterAge.Text, out double ageLimit))
            {
                List<Animal> results = animalManager.GetAnimalsOlderThan(ageLimit);
                UpdateFilterListBox(results);
            }
            else
            {
                lbxFilter.Items.Clear(); // Clear if empty or invalid text
            }
        }
    }
}
