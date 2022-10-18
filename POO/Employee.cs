using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Employee{

        //1. Atributos
        public string Dni;

        public string Name;

        public int Age;

        public double Salary;

        public bool Married;

        //2. Constructor: Metodo especial que permite construir objetos
        public Employee(string dni,string name, int age,double salary,bool married){
            
            Dni = dni;
            Name = name;
            Age = age;
            Salary = salary;
            Married = married;
            Console.WriteLine($"Employee {Dni} successfully created");
        }
        //3. Constructor sobrecargado: Ya existiendo dublicado pero variando los parametros
        public Employee(string dni, string name)
        {
            Dni = dni;
            Name = name;
            Console.WriteLine($"Employee {Dni} successfully created");
        }
        public Employee(string Dni, string name, double salary)
        {

            this.Dni = Dni;//al llamarse el mismo, se tiene que especificar con this. para referirse a variable interna de la clase
            Name = name;
            Salary = salary;
            Console.WriteLine($"Employee {Dni} successfully created");
        }
        public Employee() { }
    }
}
