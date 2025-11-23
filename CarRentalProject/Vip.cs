using Azure.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static CarRentalProject.Standard;

namespace CarRentalProject
{
    [Serializable]
    public class Vip: Standard
    { 
        public struct Driver
        {
            public String name;
            public String familyname;
            public String id;

            public string Name { get => name; set => name = value; }
            public string FamilyName { get => familyname; set => familyname = value; }
            public string ID { get => id; set => id = value; }
        }


        [XmlElement]
        public List<Driver> driversList = new List<Driver>();

        public Vip(String username, Car car, String rentEnd) : base(username, car, rentEnd) 
        {

        }
        public Vip() 
        {
            
        }


        public void showButtons(Form client)
        {
            client.Controls["Refuel_btn"].Show();
            client.Controls["Taxi_btn"].Show();
            client.Controls["Driver_btn"].Show();
        }
        public void taxiPickUP()
        {
            TaxiTimePick pick = new TaxiTimePick();
            pick.Show();
        }

        public void manageDriver()
        {


            DriverManagement_Form manage = new DriverManagement_Form(this);
            manage.Show();
        }

        public void addDriver(Driver driver)
        {
            if (!driversList.Contains(driver))
                    this.driversList.Add(driver);
        }

        public bool removeDriver(Driver driver) 
        {
            if (driversList.Contains(driver))
            {
                driversList.Remove(driver);
                return true;
            }
            return false;
        }
        public List<Driver> getDriversList()
        {
            return driversList;
        }
        public String getUsername()
        {
            return this.username;
        }

        public override void payForRefuel()
        {
            RefuelPay_Form pay = new RefuelPay_Form(this);
            pay.Show();
        }

    }
}
