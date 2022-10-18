// See https://aka.ms/new-console-template for more information
using POO;

Console.WriteLine("Progrmaa inicial!");

Employee empleado1 = new Employee("48484848E","Manelete",30,3000.5,true);
Employee empleado2 = new Employee("25252525E", "Pepe", 40, 1500.5, false);

Console.WriteLine("Nombre de Empleado 1: "+empleado1.Name);

Console.WriteLine(empleado1.Salary+empleado2.Salary);
var media = (empleado1.Salary + empleado2.Salary) / 2;
Console.WriteLine("Salario medio: "+media);

Employee empleado3 = new Employee("78787878I", "Juan");
Employee empleado4 = new Employee("23232323I", "Pili");
Console.WriteLine(empleado4.Salary);

Employee empleado5 = new Employee("87878787U", "Pili",3000.0);
Console.WriteLine(empleado5.Dni);

Employee empleado6 = new Employee();
empleado6.Name = "Titi";
empleado6.Age = 30;
Console.WriteLine(empleado6.Name);
Console.WriteLine(empleado6.Dni);

//Construcor dinamico
Employee empleado7 = new Employee { Age = 30,Dni="7773333G" };
Employee empleado8 = new Employee { Age = 30, Dni = "7773333G",Married=false };


Vehicle coche1 = new Vehicle();
coche1.Manufacturer = "Seat";
coche1.Model = "Ibiza";

Vehicle coche2 = new Vehicle { Manufacturer = "Seat", Model = "Ibiza" };
Vehicle coche3 = new Vehicle { Manufacturer = "Ford" };
Vehicle coche4 = new Vehicle { Model = "Mondeo" };
Vehicle coche5 = new Vehicle { Model = "Mondeo", CubicCentimeters = 1.2 };

//Arrancar vehiculo
Console.WriteLine(coche1.Status);
coche1.Start();
Console.WriteLine(coche1.Status);
coche1.Stop();
Console.WriteLine(coche1.Status);
coche1.Status = true;

coche1.Acelerar(50);
Console.WriteLine("Cantidad a acelerar:");
coche1.Acelerar(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(coche1.Speed);

Console.WriteLine("Cantidad a frenar:");
coche1.Reducir(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(coche1.Speed);

Console.Write("Cantidad a acelerar :");
int velocidad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Cantidad límite:");
int limite = Convert.ToInt32(Console.ReadLine());

coche1.Acelerar(velocidad,limite);
Console.WriteLine(coche1.Speed);

Person persona1 = new Person();
persona1.Saludar(Console.ReadLine());
persona1.Saludar();