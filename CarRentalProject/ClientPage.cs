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
using System.Globalization;

namespace CarRentalProject
{
    public partial class ClientPage : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        private String username;
        private Car car;
        private String rentEnd;
        private int membershipLevel;
        public ClientPage(String username, String membership)
        {
            InitializeComponent();
            this.membershipLevel = getMemberLevel(membership);
            using (cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ran Samoilov\Desktop\car rental final!\CarRentalProject\Database.mdf;Integrated Security=True"))
            {
                int level;
                cn.Open();
                String query = "UPDATE Users SET Membership =@Membership WHERE Username= @Username";
                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Membership", membership);
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("SELECT * FROM Users WHERE Username='" + username + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Name_label.Text = "Welcome " + dr["Username"].ToString() + " currently your membership is " + dr["Membership"].ToString();
                    this.username = dr["Username"].ToString();
                    this.car = new Car(dr["Manufactor"].ToString(), dr["Model"].ToString(), dr["Type"].ToString(), null);
                    setRentEnd(dr["rentEnd"].ToString());

                    Car_label.Text += car.getManufacturer() + " " + car.getModel();
                    Type_label.Text += car.getType();
                    Time_label.Text += rentEnd;

                    level = getMemberLevel(dr["Membership"].ToString());
                    switch (level)
                    {
                        case 0:
                            new Standard(this.username, this.car, rentEnd).showButtons();
                            memberextra_lbl.Hide();
                            break;
                        case 1: new Premium(this.username, this.car, rentEnd).showButtons(this); break;
                        case 2: new PremiumSilver(this.username, this.car, rentEnd).showButtons(this); break;
                        case 3: new PremiumGold(this.username, this.car, rentEnd).showButtons(this); break;
                        case 4: new Vip(this.username, this.car, rentEnd).showButtons(this); break;
                    }


                }
                dr.Close();


            }


        }
        public ClientPage(String username)
        {
            InitializeComponent();
            int level;
            using (cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ran Samoilov\Desktop\car rental final!\CarRentalProject\Database.mdf;Integrated Security=True"))
            {
                cn.Open();

                cmd = new SqlCommand("SELECT * FROM Users WHERE Username='" + username + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Name_label.Text = "Welcome " + dr["Username"].ToString() + " currently your membership is " + dr["Membership"].ToString();
                    this.car = new Car(dr["Manufactor"].ToString(), dr["Model"].ToString(), dr["Type"].ToString(), null);
                    this.username = dr["Username"].ToString();
                    setRentEnd(dr["rentEnd"].ToString());

                    Car_label.Text += car.getManufacturer() + " " + car.getModel();
                    Type_label.Text += car.getType();
                    Time_label.Text += rentEnd;

                    level = getMemberLevel(dr["Membership"].ToString());
                    this.membershipLevel = level;
                    switch (level)
                    {
                        case 0:
                            new Standard(this.username, this.car, rentEnd).showButtons();
                            memberextra_lbl.Hide();
                            break;
                        case 1: new Premium(this.username, this.car, rentEnd).showButtons(this); break;
                        case 2: new PremiumSilver(this.username, this.car, rentEnd).showButtons(this); break;
                        case 3: new PremiumGold(this.username, this.car, rentEnd).showButtons(this); break;
                        case 4: new Vip(this.username, this.car, rentEnd).showButtons(this); break;
                    }
                }
                dr.Close();
            }
        }
        private void setRentEnd(String date)
        {
            DateTime endDate = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            TimeSpan timediff = endDate - DateTime.Now;
            this.rentEnd = ((int)timediff.TotalDays + 1).ToString();
        }

        private void ClientPage_Load(object sender, EventArgs e)
        {

            Refuel_btn.FlatStyle = FlatStyle.System;
            Guide_btn.FlatStyle = FlatStyle.System;
            Restaurant_btn.FlatStyle = FlatStyle.System;
            Taxi_btn.FlatStyle = FlatStyle.System;
            String hexColor = "#f8fa9d";
            Color color = ColorTranslator.FromHtml(hexColor);
            groupbox.BackColor = color;
        }

        private int getMemberLevel(String membership)
        {
            if (membership.Equals("Premium"))
                return 1;
            if (membership.Equals("Premium_Silver"))
                return 2;
            if (membership.Equals("Premium_Gold"))
                return 3;
            if (membership.Equals("VIP"))
                return 4;

            return 0;
        }

        private void Refuel_btn_Click(object sender, EventArgs e)
        {
            switch (this.membershipLevel)

            {
                case 2:
                    PremiumSilver silver = new PremiumSilver(this.username, this.car, rentEnd);
                    silver.payForRefuel();
                    break;
                case 3:
                    PremiumGold gold = new PremiumGold(this.username, this.car, rentEnd);
                    gold.payForRefuel();
                    break;
                case 4:
                    Vip vip = new Vip(this.username, this.car, rentEnd);
                    vip.payForRefuel();
                    break;
                default:
                    Premium prem = new Premium(this.username, this.car, rentEnd);
                    prem.payForRefuel();
                    break;

            }
        }

        private void Restaurant_btn_Click(object sender, EventArgs e)
        {
            PremiumGold gold = new PremiumGold(this.username, this.car, rentEnd);
            gold.pickRestaurant();
        }

        private void Guide_btn_Click(object sender, EventArgs e)
        {
            PremiumSilver silver = new PremiumSilver(this.username, this.car, rentEnd);
            silver.showGuide();
        }

        private void Taxi_btn_Click(object sender, EventArgs e)
        {
            Vip vip = new Vip(this.username, this.car, rentEnd);
            vip.taxiPickUP();
        }

        private void Driver_btn_Click(object sender, EventArgs e)
        {
            Vip vip = new Vip(this.username, this.car, rentEnd);
            vip.manageDriver();
        }

    }
}





