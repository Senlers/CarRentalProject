using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarRentalProject
{
    public partial class Registration_Form : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Registration_Form()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ran Samoilov\Desktop\car rental final!\CarRentalProject\Database.mdf;Integrated Security=True");
            cn.Open();
            if (!usernameValidation(txt_newusername.Text)) { MessageBox.Show("Wrong username input, the length must be higher than 4 and contain only letters and numbers without space."); }
            else if (!passwordValidation(txt_newpassword.Text)) { MessageBox.Show("Wrong Password, password's lengh must be higher than 6 without space "); }
            else if (!emailValidation(txt_newemail.Text)) { MessageBox.Show("Wrong Email, Email must contain @ and end with .com / .net / .org / .co.il"); }
            else if (!idValidation(txt_newdriverid.Text)) { MessageBox.Show("Wrong ID, Must contain 9 numbers"); }
            else
            {
                cmd = new SqlCommand("select * from Users where Username='" + txt_newusername.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into Users values(@Username,@Password,@Email,@DriverID,@Date_of_birth,null,null,null,null,null,null)", cn);
                    cmd.Parameters.AddWithValue("Username", txt_newusername.Text);
                    cmd.Parameters.AddWithValue("Password", txt_newpassword.Text);
                    cmd.Parameters.AddWithValue("Email", txt_newemail.Text);
                    cmd.Parameters.AddWithValue("DriverID", txt_newdriverid.Text);
                    cmd.Parameters.AddWithValue("Date_of_birth", datatime_dt1.Value.ToString("dd/MM/yyyy"));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    
                }
            }


        }

        private void txt_newdriverid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }


        private bool usernameValidation(String username)
        {
            if (username.Length <= 4 || string.IsNullOrWhiteSpace(username))
                return false;
            if (username.Any(ch => !char.IsLetterOrDigit(ch)))
                return false;

            return true;
        }

        private bool passwordValidation(String password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Contains(" "))
                return false;
            if (password.Length < 6)
                return false;

            return true;
        }

        private bool emailValidation(String email)
        {
            if (!email.Contains('@') || (!email.EndsWith(".com") && !email.EndsWith(".net") && !email.EndsWith(".org") && !email.EndsWith(".co.il")))
                return false;

            return true;
        }

        private bool idValidation(String id)
        {
            if (id.Length != 9)
                return false;
            return true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

    }
}
