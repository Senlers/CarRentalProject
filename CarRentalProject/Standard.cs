using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static CarRentalProject.Car;

namespace CarRentalProject
{
    public class Standard
    {
        [XmlElement]
        public String username;
        [XmlElement]
        public String rentEnd;
        [XmlElement]
        public Car car;

        public Standard(String username,Car car,String rentEnd)
        {
            this.username = username;
            this.car = car;
            this.rentEnd = rentEnd;
        }
        public Standard() { }

       public String getUsername()
        {
            return username;
        }
        public Car GetCar()
        {
            return car;
        }

        public String getRentEnd()
        {
            return rentEnd;
        }

        public virtual void showButtons() { }
        public virtual void payForRefuel(){  }

    }
}
