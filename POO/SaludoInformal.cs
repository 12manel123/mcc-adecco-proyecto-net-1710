using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;
public class SaludoInformal : ISaludo {//Clase para impelemtar una Interfaz llamada ISaludo
    public void saludar() {
        Console.WriteLine("Sup bro!");

    }
    public void saludar(string nombre) {
        Console.WriteLine("Sup "+nombre+"!");

    }

}
