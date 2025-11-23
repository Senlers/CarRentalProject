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
using System.Xml.Serialization;
using static CarRentalProject.DriverManagement_Form;
using static CarRentalProject.Vip;
namespace CarRentalProject
{
    public partial class AddEdit_Form : Form
    {
        private String FILE_PATH;
        private Vip vip;
        private List<Driver> drivers;
        private List<Vip> vipUsers;
        public AddEdit_Form(String FILE_PATH, List<Vip> vipUsers, Vip vip)
        {
            InitializeComponent();
            this.vip = vip;
            this.drivers = vip.getDriversList();
            this.vipUsers = vipUsers;
            this.FILE_PATH = FILE_PATH;
            Submit_button.Show();
        }

        private void ID_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void Name_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8)
                e.Handled = true;
        }
        private void DynFamily_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8)
                e.Handled = true;
        }


        private void Submit_button_Click(object sender, EventArgs e)
        {
            String drivername = Name_txt.Text;
            String driverfamily = DynFamily_txt.Text;
            String driverid = ID_txt.Text;
            
            if (!drivername.IsNullOrEmpty() && !driverfamily.IsNullOrEmpty() && !driverid.IsNullOrEmpty() && checkID(ID_txt.Text))
            {
                Driver newDriver = new Driver { name = drivername, familyname = driverfamily, id = driverid };
                this.vip.addDriver(newDriver);
                int indexOfVip = this.vipUsers.IndexOf(this.vip);
                if (indexOfVip > -1 && !this.vipUsers.IsNullOrEmpty())
                {
                    this.vipUsers[indexOfVip] = this.vip;
                }
                else
                {
                    vipUsers.Add(this.vip);
                }

                using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Truncate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Vip>));
                    serializer.Serialize(fileStream, this.vipUsers);
                }


                DriverManagement_Form returnManage = new DriverManagement_Form(this.vip);
                this.Close();
                returnManage.Show();
            }
            else
                MessageBox.Show("Please double check that the fields are not empty and the ID's length is 9 numbers otherwise the driver already exists");

        }

        private bool checkID(String id)
        {
            if (id.Length != 9)
                return false;
            else
            {
                if (!this.drivers.IsNullOrEmpty())
                {
                    if (!this.drivers.Exists(driver => driver.id.Equals(id)))
                    {
                        return true;
                    }
                }
                else
                {
                    this.drivers = new List<Driver>();
                    return true;
                }

                return false;
            }

        }

    }
}
