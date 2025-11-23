using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarRentalProject.Premium;

namespace CarRentalProject
{
    public class PremiumSilver : Premium
    {
        public PremiumSilver(string username_new, Car car, String rentEnd) : base(username_new, car, rentEnd) { }

        public override void showButtons(Form client)
        {
            client.Controls["Refuel_btn"].Show();
            client.Controls["Guide_btn"].Show();
        }
        
            
        
        public void showGuide()
        {
            MessageBox.Show("Call 1-555-5555 and let them know you are a SILVER member at " +
                "carASAP and you will get free information about amazing places to visit!");
        }
    }
}

