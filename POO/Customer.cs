using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO {
    internal class Customer {
        public string Dni;
        public string Email;
        public ISaludo Saludo;
        public Address Adress;
        public RoadVehicle Vehicle;//Polimorfismo
        public List<RoadVehicle> PersonalVehicles;

        public Customer() {

        }   

    }
}
