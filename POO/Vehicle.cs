using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;

public class Vehicle {
    public string Manufacturer;
    public string Model;
    public double CubicCentimeters;
    public bool Status;//encendidio(true) o apagado (false)
    public int Speed;

    //Constructor vacio
    public Vehicle() {}

    //Métodos
    public void Start() {
        Status = true;
    }
    public void Stop() {
        Status = false;
    }
    public void Acelerar(int speed) {
        if (speed > 0 && Speed + speed <= 120)
            Speed += speed;
        else if (Speed + speed > 120)
            Speed = 120;
    }

    public void Acelerar(int speed, int limit) {
        if (speed > 0 && Speed + speed <= limit)
            Speed += speed;
        else if (Speed + speed > limit)
            Speed = limit;
    }

    public void Reducir(int speed) {
        if (speed > 0 && Speed - speed >= 0)
            Speed -= speed;
        else if (Speed - speed < 0)
            Speed = 0;
    }
    
}