using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarRentalProject.Standard;

namespace CarRentalProject
{
    public class Premium : Standard
    {
        public Premium(String username, Car car, String rentEnd) : base(username, car, rentEnd) { }

        public virtual void showButtons(Form client)
        {
            client.Controls["Refuel_btn"].Show();           
        }
        public override void payForRefuel()
        {
            RefuelPay_Form pay = new RefuelPay_Form(this);
            pay.Show();
        }

    }
}
