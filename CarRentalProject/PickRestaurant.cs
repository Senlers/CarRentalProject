using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalProject
{
    public partial class PickRestaurant : Form
    {
        private string selectedOption;
        public PickRestaurant()
        {
            InitializeComponent();
        }


        private void pick_rest_btn_Click(object sender, EventArgs e)
        {
            if (selectedOption != null)
            {
                MessageBox.Show("You selected: " + selectedOption + ", Have fun in behalf of our team!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select an option.");
            }
            
        }

        private void north_radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                selectedOption = "The Northen Sailor";
            }
        }

        private void meat_radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                selectedOption = "The meat Of The Seas";
            }
        }

        private void south_radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                selectedOption = "Southern Dutchman";
            }
        }

        private void PickRestaurant_Load(object sender, EventArgs e)
        {

            pick_rest_btn.Show();
        }
    }
}
