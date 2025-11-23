using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalProject
{
    public class Car
    {
        private String manufacturer;
        private String model;
        private String type;
        private String seats;
        
        public Car(String manufacturer,String model, String type, String seats)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.type = type;
            this.seats= seats;
        }
        public Car() { }

        public String getManufacturer()
        {
            return this.manufacturer;
        }
        public String getModel()
        {
            return this.model;
        }
        public String getType()
        {
            return this.type;
        }
        public String getSeats()
        {
            return this.seats;
        }





    }
}
