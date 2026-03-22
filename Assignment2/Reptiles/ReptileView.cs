using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class ReptileView : Form
    {
        private string species;

        public ReptileView(string species)
        {
            InitializeComponent();
            this.species = species;
            InitializeGUI();
        }

        public Reptile CreatedReptile { get; private set; }

        private void InitializeGUI()
        {
            this.Text = $"{species} Details";
            grpSpecific.Text = $"Specific Data for {species}";

            if (species == "Lizard")
            {
                lblSpecific.Text = "Tail Length";
            }
            else if (species == "Turtle")
            {
                lblSpecific.Text = "Shell Width";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (species == "Lizard")
                CreatedReptile = new Lizard();
            else
                CreatedReptile = new Turtle();

            if (double.TryParse(txtLength.Text, out double length))
            {
                CreatedReptile.BodyLength = length;
            }

            CreatedReptile.LivesInWater = rbtnTrue.Checked;

            if (CreatedReptile is Lizard lizard)
            {
                if (double.TryParse(txtSpecific.Text, out double tail))
                    lizard.TailLength = tail;
            }
            else if (CreatedReptile is Turtle turtle)
            {
                if (double.TryParse(txtSpecific.Text, out double shell))
                    turtle.ShellWidth = shell;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
