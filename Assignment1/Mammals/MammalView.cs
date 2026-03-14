using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class MammalView : Form
    {
        private string species;
        public MammalView(string species)
        {
            InitializeComponent();
            this.species = species;
            InitializeGUI();
        }

        public Mammal CreatedMammal { get; private set; }

        private void InitializeGUI()
        {
            this.Text = $"{species} Details";
            grpSpecific.Text = $"Specific Data for {species}";

            if (species == "Dog")
            {
                lblSpecific.Text = "Breed";
                txtBreed.Visible = true;
                cmbCatFur.Visible = false;
            }
            else if (species == "Cat")
            {
                lblSpecific.Text = "Hair Type";
                txtBreed.Visible = false;
                cmbCatFur.Visible = true;

                cmbCatFur.DataSource = Enum.GetValues(typeof(FurType));
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (species == "Dog")
                CreatedMammal = new Dog();
            else
                CreatedMammal = new Cat();

            int teeth;
            double tail;
            int.TryParse(txtTeeth.Text, out teeth);
            double.TryParse(txtTail.Text, out tail);

            CreatedMammal.NumOfTeeth = teeth;
            CreatedMammal.TailLength = tail;

            if (CreatedMammal is Dog dog)
            {
                dog.Breed = txtBreed.Text;
            }
            else if (CreatedMammal is Cat cat)
            {
                string selectedText = cmbCatFur.SelectedItem.ToString();

                if (Enum.TryParse(selectedText, out FurType fur))
                {
                    cat.FurType = fur;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void MammalView_Load(object sender, EventArgs e)
        {

        }
    }
}
