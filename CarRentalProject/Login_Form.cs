using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalProject
{
    public partial class Login_Form : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Login_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration(object sender, EventArgs e)
        {
            Registration_Form newregister = new Registration_Form();
            newregister.Show();
        }

        private void Forgot_Password(object sender, EventArgs e)
        {

        }

        private void Login(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ran Samoilov\Desktop\car rental final!\CarRentalProject\Database.mdf;Integrated Security=True");
            cn.Open();
            if (txt_password.Text != string.Empty || txt_username.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from Users where Username='" + txt_username.Text + "' and Password='" + txt_password.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    String username = dr["username"].ToString().Trim();
                    String membership = dr["membership"].ToString();
                    if (membership == "")
                    {
                        dr.Close();
                        this.Hide();
                        CarSelection_Form form3 = new CarSelection_Form(username);
                        form3.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        this.Hide();
                        ClientPage client = new ClientPage(username);
                        client.Show();
                    }
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
