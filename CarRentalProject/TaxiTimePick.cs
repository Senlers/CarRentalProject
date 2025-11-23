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
    public partial class TaxiTimePick : Form
    {

        public TaxiTimePick()
        {
            InitializeComponent();

        }


        private void pickup_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A driver will pick you up at: " + picker_date.Value.ToString("dd/MM/yyyy") + " at time: "
                + picker_time.Value.ToString("hh:mm"));
            this.Close();
        }

        private void picker_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void picker_time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TaxiTimePick_Load(object sender, EventArgs e)
        {
            picker_date.MinDate = DateTime.Now;
            pickup_btn.Show();
        }
    }
}
