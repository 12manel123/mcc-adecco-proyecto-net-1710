using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO {
    public abstract class RoadVehicle {//con abstract no puedes crear objetos, pero los hijos si
        public string Manufacturer;
        public int NumRuedas;
        public bool Status;

        public void Start() {
            Status = true;

        }
        public virtual void Stop() {//para evitar duplicados agregas el virtual y en el duplicado añades:
            Status = false;
        }
    }

    //extiende a RoadVehicle, es un hijo el "car"
    public class Car : RoadVehicle {//los ":" significa que hereda directamente, diciendo cual es el padre
        public int NumPuertas;
        public bool RuedaRepuesto;
        public int NumPassengers;
        public int NumPerson;


        public override void Stop() { 
            base.Stop();//aca es el duplicado, añades esto para definir duplicado añadiendo algo mas
            NumPerson = 0;
        }
    }
    public class MotorCycle : RoadVehicle {//los ":" significa que hereda directamente, diciendo cual es el padre
        public bool Copilot;
        public bool Naked;
    }
    public class Truck : RoadVehicle {
        public bool Trailer;
        public int TrailerCapacity;
    }
    public class ElectricCar : Car {//los ":" significa que hereda directamente, diciendo cual es el padre
        public int BateryCapacity;
    }
    public class Combustion : Car {//los ":" significa que hereda directamente, diciendo cual es el padre
        public int TanckCapacity;
        public double Emission;
    }

}
