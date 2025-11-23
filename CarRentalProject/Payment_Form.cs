using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static CarRentalProject.Car;

namespace CarRentalProject
{
   
    public partial class Payment_Form : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;


        private String membershipselection;
        private String user;
        private Car car;
        private DateTime rentEnd;

        private static double minicost_day = 100;
        private static double familycost_day = 300;
        private const double  standardcost = 50;
        private const double  premiumcost = 150;
        private const double  vipcost = 300;
        private const double premdisc = 0.15;
        private const double vipdisc = 0.25;
        private double totaldisc = 0;
        private double totalcost = 0; //  moved the totalcost to here 

        public Payment_Form(int category, int days, int membership,String username,Car car,DateTime rentEnd)
        {           
            InitializeComponent();
            this.car = car;
            this.user = username;
            this.rentEnd= rentEnd;


            String formattedCost;
            String formattedDisc;

            switch (membership)
            {
                case 0: 
                    totalcost = standardcost;
                    membershipselection = "Standard";
                    break;
                case 1: 
                    totalcost = premiumcost;
                    membershipselection = "Premium";
                    break;
                case 2:
                    totalcost = premiumcost + 25;
                    membershipselection = "Premium_Silver";
                    break;
                case 3:
                    totalcost = premiumcost + 50;
                    membershipselection = "Premium_Gold";
                    break;
                case 4: 
                    totalcost = vipcost;
                    membershipselection = "VIP";
                    break;
            }
            switch (category)
            {
                case 0: totalcost += minicost_day * days  ; break;
                case 1: totalcost += familycost_day * days ; break;

            }
            if (membership == 0)
            {
                formattedCost = totalcost.ToString("N2") + " $";
                Voucher_label.Hide();
                VoucherCost_label.Hide();
                Cost_label.Text = formattedCost;
                Cost_label.AutoSize = false;
                Cost_label.Width = TextRenderer.MeasureText(formattedCost, Cost_label.Font).Width;
                Cost_label.Height = TextRenderer.MeasureText(formattedCost, Cost_label.Font).Height;
            }
            else
            {
                if (membership == 1 || membership==2 || membership == 3)
                    this.totaldisc = totalcost * premdisc;
                if (membership == 4)
                    this.totaldisc = totalcost * vipdisc;

                formattedCost = totalcost.ToString("N2") + " $";
                Cost_label.Text = formattedCost;
                Cost_label.AutoSize = false;
                Cost_label.Width = TextRenderer.MeasureText(formattedCost, Cost_label.Font).Width;
                Cost_label.Height = TextRenderer.MeasureText(formattedCost, Cost_label.Font).Height;

                formattedDisc = this.totaldisc.ToString("N2") + " $";
                VoucherCost_label.Text = formattedDisc;
                VoucherCost_label.AutoSize = false;
                VoucherCost_label.Width = TextRenderer.MeasureText(formattedDisc, VoucherCost_label.Font).Width;
                VoucherCost_label.Height = TextRenderer.MeasureText(formattedDisc, VoucherCost_label.Font).Height;

            }
           
        }

        private void Pay(object sender, EventArgs e)
        {

            if (!NameOnCardVari(Name_txt.Text)) { MessageBox.Show("The name on the card must be First and Last name only."); }
            else if (!CardNumVari(CardNum_txt.Text)) { MessageBox.Show("Card number must be 16 digits long with no whitespaces in between!"); }
            else if (!CVCVari(CVC_txt.Text)) { MessageBox.Show("CVC must be 3 digits long with no whitespaces in between!"); }
            else if (!ExperationVari(Expiration_txt.Text)) { MessageBox.Show("Expretion Date must be in the format of: MM/YY"); }
            else
            {
                MessageBox.Show("Thank you for your payment! Your transaction has been accepted and your payment has been processed successfully.");
                using (cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ran Samoilov\Desktop\car rental final!\CarRentalProject\Database.mdf;Integrated Security=True"))
                {
                    cn.Open();
                    cmd = new SqlCommand("SELECT * FROM "+car.getType()+" WHERE Manufactor='"+car.getManufacturer()+"'",cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        String manuName = dr["Manufactor"].ToString();
                        String modelName = dr["Model"].ToString();
                        dr.Close();

                        String query = "UPDATE Users SET Manufactor =@Manufactor, Model =@Model, RentEnd=@RentEnd, Type=@Type, Refuel=@Refuel WHERE Username= @Username";
                        cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@Username", user);
                        cmd.Parameters.AddWithValue("@Model", manuName);
                        cmd.Parameters.AddWithValue("@Manufactor", modelName);
                        cmd.Parameters.AddWithValue("@RentEnd", rentEnd.ToString("dd/MM/yyyy"));
                        cmd.Parameters.AddWithValue("@Type",car.getType());
                        cmd.Parameters.AddWithValue("@Refuel", this.totaldisc);
                        cmd.Connection = cn;
                        cmd.ExecuteNonQuery();



                        cmd = new SqlCommand("SELECT Username FROM Users WHERE Username='" + this.user + "'", cn);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            ClientPage clientPage = new ClientPage(dr["Username"].ToString(), membershipselection);
                            clientPage.Show();
                        }
                        dr.Close();
                    }
                }
                this.Close();
            }

        }


        private bool NameOnCardVari(String nameoncard)
        {
            nameoncard = nameoncard.Trim();
            int spaceIndex = nameoncard.IndexOf(' ');
            if (nameoncard.IsNullOrEmpty()) return false;
            if (spaceIndex < 0 || spaceIndex != nameoncard.LastIndexOf(' '))
            {

                return false;
            }
            string[] words = nameoncard.Split(' ');
            if (words.Length != 2)
            {
                return false;
            }
            return true;
        }

        private bool CardNumVari(String cardnum)
        {
            if (cardnum.Length != 16)
            {
                return false;
            }
            foreach (char c in cardnum)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        private bool CVCVari(String cardnum)
        {
            if (cardnum.Length != 3)
            {
                return false;
            }
            foreach (char c in cardnum)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        private bool ExperationVari(String cardnum)
        {
            if (cardnum.Length != 5)
            {
                return false;
            }
            if (!int.TryParse(cardnum.Substring(0, 2), out int month) || month < 1 || month > 12)
            {
                return false;
            }
            if (cardnum[2] != '/')
            {
                return false;
            }
            if (!int.TryParse(cardnum.Substring(3, 2), out int year) || year < 0 || year > 99)
            {
                return false;
            }
            return true;
        }

        private void CardNum_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void CVC_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }


        private void Name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
                e.Handled = true;

        }

        
        private void Expiration_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
          
        }

        private void Expiration_txt_TextChanged(object sender, EventArgs e)
        {
            if (Expiration_txt.Text.Length == 4 && !Expiration_txt.Text.Contains("/"))
            {
                Expiration_txt.Text = Expiration_txt.Text.Insert(2, "/");
                Expiration_txt.SelectionStart = Expiration_txt.TextLength;
            }
            else
            {
                if (Expiration_txt.Text.Length < 5 && Expiration_txt.Text.Contains("/"))
                {
                    Expiration_txt.Text = Expiration_txt.Text.Replace("/", "");
                    Expiration_txt.SelectionStart = Expiration_txt.TextLength;
                }
            }
        }

        private void payment_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string payments_amnt = payment_combo.SelectedItem.ToString();
            if (int.TryParse(payments_amnt, out int numberofpayments))
            {
                double costperpayment = totalcost / numberofpayments;
                string formattedpaymentperinstallment = costperpayment.ToString("N3");
                installment_txt.Text = $"Payment per installment: {formattedpaymentperinstallment}$";
                installment_txt.Visible= true;
            }
            
        }
    }
}
