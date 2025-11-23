using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace CarRentalProject
{
    public partial class RefuelPay_Form : Form
    {
        private Standard user;
        private double remainingSum;
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public RefuelPay_Form(Standard level)
        {
            InitializeComponent();
            this.user = level;
            using (cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ran Samoilov\Desktop\car rental final!\CarRentalProject\Database.mdf;Integrated Security=True"))
            {
                cn.Open();
                cmd = new SqlCommand("SELECT Username, Refuel FROM Users WHERE Username='" + level.getUsername() + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Remaining_label.Text = dr[1].ToString() + "$ Remaining";
                    this.remainingSum = (double)dr[1];
                }
            }
            dr.Close();
        }

        private void Pay_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                e.Handled = true;
            if ((Pay_txt.Text.IsNullOrEmpty() || Pay_txt.Text.Contains('.')) && ch == 46)
                e.Handled = true;
        }

        private bool checkNumber(String num)
        {
            if (num.EndsWith('.'))
                return false;

            return true;
        }

        private void Submit_button_Click(object sender, EventArgs e)
        {
            double submitAmount;
            double.TryParse(Pay_txt.Text, out submitAmount);
            if (checkNumber(Pay_txt.Text) && remainingSum>= submitAmount)
            {
                using (cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ran Samoilov\Desktop\car rental final!\CarRentalProject\Database.mdf;Integrated Security=True"))
                {
                    cn.Open();
                    cmd = new SqlCommand("SELECT Username, Refuel FROM Users WHERE Username='" + user.getUsername() + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        double substractionResult = remainingSum - submitAmount;
                        dr.Close();

                        String query = "UPDATE Users SET Refuel=@Refuel WHERE Username= @Username";
                        cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@Username", user.getUsername());
                        cmd.Parameters.AddWithValue("@Refuel", substractionResult);
                        cmd.Connection = cn;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Successful payment");
                        this.Close();
                    }
                }
            }
            else
                MessageBox.Show("Please check the number you have input");
        }
    }
}
