using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;
public class SaludoFormal : ISaludo {//Clase para impelemtar una Interfaz llamada ISaludo
    public void Saludar() {
        Console.WriteLine("Hello ladies and gentlemen!");
        
    }
    public void Saludar(string nombre) {
        Console.WriteLine("Hello "+nombre+", have a nice day");

    }

}

