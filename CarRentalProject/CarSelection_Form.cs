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
using static CarRentalProject.Car;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarRentalProject
{
    public partial class CarSelection_Form : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        List<Car> minicarlist = new List<Car>();
        List<Car> familycarlist = new List<Car>();
        private String user;
        public CarSelection_Form(string username)
        {
            InitializeComponent();
            Username_label.Text = username;
            this.user = username;


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Category_combo.Items.Add("MiniCars");
            Category_combo.Items.Add("FamilyCars");
            Membership_combo.Items.Add("Standard");
            Membership_combo.Items.Add("Premium");
            Membership_combo.Items.Add("Premium_Silver");
            Membership_combo.Items.Add("Premium_Gold");
            Membership_combo.Items.Add("VIP");
            Membership_label.Hide();
            Dyn_seats_label.Hide();
            Seats_label.Hide();

            start_pickdate.MinDate = DateTime.Today;
            end_pickdate.Value = start_pickdate.Value.AddDays(1);

            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ran Samoilov\Desktop\car rental final!\CarRentalProject\Database.mdf;Integrated Security=True");
            cn.Open();

            String manufacurer;
            String model;
            String seats;

            cmd = new SqlCommand("SELECT * FROM MiniCars", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                manufacurer = dr.GetString(1).Trim();
                model = dr.GetString(2).Trim();
                seats = dr.GetString(3);
                Car minicar = new Car(manufacurer, model, "MiniCars", seats);
                minicarlist.Add(minicar);
            }
            dr.Close();

            cmd = new SqlCommand("SELECT * FROM FamilyCars", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                manufacurer = dr.GetString(1).Trim();
                model = dr.GetString(2).Trim();
                seats = dr.GetString(3).Trim();
                Car familycar = new Car(manufacurer, model, "FamilyCars", seats);
                familycarlist.Add(familycar);
            }
            dr.Close();
        }

        private void Category_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Seats_label.Hide();
            Dyn_seats_label.Hide();

            Model_combo.SelectedIndex = -1;
            Manufacturer_combo.SelectedIndex = -1;
            Manufacturer_combo.Items.Clear();
            int count;
            switch (Category_combo.SelectedIndex)
            {
                case 0:
                    count = minicarlist.Count();
                    for (int i = 0; i < count; i++)
                        Manufacturer_combo.Items.Add(minicarlist[i].getManufacturer());

                    break;


                case 1:
                    count = familycarlist.Count();
                    for (int i = 0; i < count; i++)
                        Manufacturer_combo.Items.Add(familycarlist[i].getManufacturer());

                    break;

            }
        }

        private void Manufacturer_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Seats_label.Hide();
            Dyn_seats_label.Hide();

            Model_combo.SelectedIndex = -1;
            Model_combo.Items.Clear();
            String category = Category_combo.Text;
            String manufac = Manufacturer_combo.Text;

            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ran Samoilov\Desktop\car rental final!\CarRentalProject\Database.mdf;Integrated Security=True");
            cn.Open();

            cmd = new SqlCommand("SELECT Model FROM " + category + " WHERE Manufactor='" + manufac + "'", cn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Model_combo.Items.Add(dr.GetString(0).Trim());
            }
            dr.Close();

        }

        private void btn_clearcars_Click(object sender, EventArgs e)
        {
            Model_combo.SelectedIndex = -1;
            Manufacturer_combo.SelectedIndex = -1;
            Category_combo.SelectedIndex = -1;
            start_pickdate.Value = DateTime.Now;
            end_pickdate.Value = start_pickdate.Value.AddDays(1);
            Membership_combo.SelectedIndex = -1;
            Membership_label.Hide();

        }

        private void start_pickdate_ValueChanged(object sender, EventArgs e)
        {
            end_pickdate.MinDate = start_pickdate.Value.AddDays(1);
        }

        private void Membership_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Membership_combo.SelectedIndex)
            {
                case 0:
                    Membership_label.Text = "There is no bonuses for standard membership";
                    Membership_label.Show();
                    break;
                case 1:
                    Membership_label.Text = "For Premium membership you get refueling voucher amounting for 15% of the payment";
                    Membership_label.Show();
                    break;
                case 2:
                    Membership_label.Text = "For Premium membership you get refueling voucher amounting for 15% of the payment ADDITIONALY silver premium members you can use our Traveling assistance Agent!";
                    Membership_label.Show();
                    break;
                case 3:
                    Membership_label.Text = "For Premium membership you get refueling voucher amounting for 15% of the payment ADDITIONALY gold premium members get a restaurant discount of your choosing";
                    Membership_label.Show();
                    break;
                case 4:
                    Membership_label.Text = "For VIP membership you get refueling voucher amounting for 25% of the payment Benefits Car rental pickup service and Manage the drivers who will ride on the rented car ";
                    Membership_label.Show();
                    break;

            }
        }

        private void btn_nxtpay_Click(object sender, EventArgs e)
        {
            TimeSpan timedifference = end_pickdate.Value - start_pickdate.Value;
            int daysDiff = timedifference.Days;
            bool category = selectionCheck(Category_combo.SelectedIndex);
            bool manu = selectionCheck(Manufacturer_combo.SelectedIndex);
            bool model = selectionCheck(Model_combo.SelectedIndex);
            bool membership = selectionCheck(Membership_combo.SelectedIndex);
            if (!category || !manu || !model || !membership)
                MessageBox.Show("All boxes must be filled");
            else if (daysDiff < 0) MessageBox.Show("Must pick a returning day that's after the picking day!");
            else
            {
                Car newcar = new Car(Manufacturer_combo.Text, Model_combo.Text, Category_combo.Text, Dyn_seats_label.Text);
                DateTime rentEnd = end_pickdate.Value;
                Payment_Form payment = new Payment_Form(Category_combo.SelectedIndex, daysDiff, Membership_combo.SelectedIndex, user, newcar, rentEnd);
                this.Close();
                payment.Show();
            }
        }
        private bool selectionCheck(int num)
        {
            if (num == -1)
                return false;
            else
                return true;
        }

        private void Model_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = Category_combo.Text;
            String manufac = Manufacturer_combo.Text;
            String model = Model_combo.Text;

            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ran Samoilov\Desktop\car rental final!\CarRentalProject\Database.mdf;Integrated Security=True");
            cn.Open();
            cmd = new SqlCommand("SELECT Seats FROM " + category + " WHERE Manufactor='" + manufac + "' AND Model='" + model + "'", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Seats_label.Show();
                Dyn_seats_label.Text = dr.GetString(0).Trim();
                Dyn_seats_label.Show();
            }
            dr.Close();
        }
    }


}
