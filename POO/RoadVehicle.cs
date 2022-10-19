using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO {
    public class RoadVehicle {
        public string Manufacturer;
            public int NumRuedas;
            public bool Status;

        public void Start() {
            Status = true;

        }
        public void Stop() {
            Status = false;
        }
    }

    //extiende a RoadVehicle, es un hijo el "car"
    public class Car : RoadVehicle {//los ":" significa que hereda directamente, diciendo cual es el padre
        public int NumPuertas;
        public bool RuedaRepuesto;
    }
    public class MotorCycle : RoadVehicle {//los ":" significa que hereda directamente, diciendo cual es el padre
        public bool Copilot;
        public bool Naked;
    }
    public class Truck : RoadVehicle {//los ":" significa que hereda directamente, diciendo cual es el padre
        public string Trailer;
        public int TrailerCapacity;
    }
}
