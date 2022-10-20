using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;
public class SaludoInformal : ISaludo {//Clase para impelemtar una Interfaz llamada ISaludo
    public void Saludar() {
        Console.WriteLine("Sup bro!");

    }
    public void Saludar(string nombre) {
        Console.WriteLine("Sup "+nombre+"!");

    }

}
