using Assignment1;

namespace Assignment1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            lbxCategory.DataSource = Enum.GetValues(typeof(CategoryType));

            cmbGender.DataSource = Enum.GetValues(typeof(GenderType));

            lbxCategory.SelectedIndex = -1;
            cmbGender.SelectedIndex = (int)GenderType.Unknown;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbxCategory.SelectedItem == null || lbxSpecies.SelectedItem == null)
            {
                MessageBox.Show("Please select both a category and a species.");
                return;
            }

            string species = lbxSpecies.SelectedItem.ToString();
            CategoryType selectedCategory = (CategoryType)lbxCategory.SelectedItem;
            Animal animal = null;

            if (selectedCategory == CategoryType.Mammal)
            {
                using (MammalView mammalForm = new MammalView(species))
                {
                    if (mammalForm.ShowDialog() == DialogResult.OK)
                        animal = mammalForm.CreatedMammal;
                }
            }
            else if (selectedCategory == CategoryType.Reptile)
            {
                using (ReptileView reptileForm = new ReptileView(species))
                {
                    if (reptileForm.ShowDialog() == DialogResult.OK)
                        animal = reptileForm.CreatedReptile;
                }
            }

            if (animal != null)
            {
                animal.Name = txtName.Text;

                if (int.TryParse(txtAge.Text, out int age)) animal.Age = age;

                if (decimal.TryParse(txtWeight.Text, out decimal weight)) animal.Weight = weight;

                animal.GenderType = (GenderType)cmbGender.SelectedItem;

                UpdateResultBox(animal);
            }
        }

        private void UpdateResultBox(Animal animal)
        {
            lstInfo.Items.Clear();
            string fullInfo = animal.ToString();
            string[] lines = fullInfo.Split(';');

            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                    lstInfo.Items.Add(line.Trim());
            }
        }

        private void lbxCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lbxSpecies.Items.Clear();

            if (lbxCategory.SelectedItem == null) return;
            CategoryType selectedCategory = (CategoryType)lbxCategory.SelectedItem;

            switch (selectedCategory)
            {
                case CategoryType.Mammal:
                    lbxSpecies.Items.Add("Dog");
                    lbxSpecies.Items.Add("Cat");
                    break;
                case CategoryType.Reptile:
                    lbxSpecies.Items.Add("Turtle");
                    lbxSpecies.Items.Add("Lizard");
                    break;
            }
        }

        private void lbxSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxSpecies.SelectedItem == null) return;

            string species = lbxSpecies.SelectedItem.ToString();
        }
    }
}
