using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using static CarRentalProject.Vip;
using Microsoft.IdentityModel.Tokens;

namespace CarRentalProject
{
    public partial class DriverManagement_Form : Form
    {

        private const String FILE_PATH = @"C:\Users\Ran Samoilov\Desktop\car rental final!\drivers.xml";

        private List<Vip> vipUsers;
        private Vip vip;
        private List<Driver> drivers;

        public DriverManagement_Form(Vip vip)
        {
            InitializeComponent();
            this.vip = vip;
            if (File.Exists(FILE_PATH))
            {
                using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Vip>));
                    this.vipUsers = (List<Vip>)serializer.Deserialize(fileStream);
                    int i = 0;
                    int vipIndex = -1;
                    while (i < this.vipUsers.Count)
                    {
                        if (this.vipUsers[i].getUsername().Equals(this.vip.getUsername()))
                        {
                            vipIndex = i;
                            break;
                        }
                        i++;
                    }
                    if (vipIndex != -1)
                    {
                        this.vip = this.vipUsers[i];
                        this.drivers = this.vipUsers[vipIndex].getDriversList();
                    }
                    else
                    {
                        this.vipUsers.Add(this.vip);
                        this.drivers = this.vip.getDriversList();
                    }

                    
                    if (!drivers.IsNullOrEmpty())
                    {
                        foreach (Driver driver in drivers)
                        {
                            ID_combo.Items.Add(driver.id);
                        }
                    }
                }
            }
            else
            {
                this.vipUsers = new List<Vip> { vip };
                using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Vip>));
                    serializer.Serialize(fileStream, this.vipUsers);
                }
            }

            Remove_button.Show();
            Add_button.Show();
        }


        private void Driver_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ID_combo.SelectedIndex != -1)
            {
                int indexOfDriver = drivers.FindIndex(driver => driver.id == ID_combo.Text);
                DynDriver_label.Text = drivers[indexOfDriver].name;
                DynFamily_label.Text = drivers[indexOfDriver].familyname;
            }
            else
            {
                DynDriver_label.Text = "Drivers Name";
                DynFamily_label.Text = "Family Name";
            }
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            int indexOfDriver = drivers.FindIndex(driver => driver.id == ID_combo.Text);
            if (ID_combo.SelectedIndex >= 0)
            {
                if (this.vip.removeDriver(drivers[indexOfDriver]))
                {
                    this.drivers = vip.getDriversList();
                }
                using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Truncate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Vip>));
                    serializer.Serialize(fileStream, vipUsers);
                }

                ID_combo.Items.RemoveAt(ID_combo.SelectedIndex);
                ID_combo.Text = "";
                DynDriver_label.Text = "Drivers Name";
                DynFamily_label.Text = "Family Name";
                ID_combo.SelectedIndex = -1;
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            AddEdit_Form add = new AddEdit_Form(FILE_PATH, this.vipUsers, this.vip);
            this.Close();
            add.Show();
        }
    }
}
