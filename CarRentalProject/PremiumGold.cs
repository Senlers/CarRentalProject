using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarRentalProject.Premium;

namespace CarRentalProject
{
     public class PremiumGold : Premium
    {
        public PremiumGold(string username_new, Car car, String rentEnd) : base(username_new, car, rentEnd) { }

        public override void showButtons(Form client)
        {
            client.Controls["Refuel_btn"].Show();
            client.Controls["Restaurant_btn"].Show();
        }

        public void pickRestaurant()
        {
            PickRestaurant pickRestaurant= new PickRestaurant();
            pickRestaurant.Show();
        }
    }
}
