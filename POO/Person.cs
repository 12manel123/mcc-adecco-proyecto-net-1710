using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;
public class Person {
    public void Saludar() {
        Console.WriteLine("Hola");
    }
    public void Saludar(string nombre) {
        Console.WriteLine("Hola "+nombre);
    }
}
