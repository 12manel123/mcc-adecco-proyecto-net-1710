// See https://aka.ms/new-console-template for more information
using POO;

Console.WriteLine("Progrmaa inicial!");
/*
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

SmartPhone movil1 = new SmartPhone { Manufacturer = "Samsung", Cores = 4, Ram = 8 };
Console.WriteLine(movil1);
SmartPhone movil2 = new SmartPhone { Manufacturer = "One plus", Cores = 8, Ram = 16 };
Console.WriteLine(movil2);*/

Guest invitado = new Guest();
invitado.Age = -20;
//invitado.age = 20;//no dejara aqui ya que es metodo private
Console.WriteLine(invitado.Age);
Console.WriteLine(invitado.Dni);
//invitado.Dni = "2323233H";
Console.WriteLine(invitado.Salary);
invitado.Promote(200.0);
Console.WriteLine(invitado.Salary);

//Promote sobrecargado
invitado.Promote();
Console.WriteLine(invitado.Salary);


Address address1 = new Address {
    Street = "Calle 1",
    PostalCode = "434356",
    City = "Pepe",
    Country = "Spain"
};
//asociacion entre clases
Customer customer1 = new Customer {
    Dni = "232323R",
    Email = "cust1@company.com",
    Adress = address1
};

Console.WriteLine(customer1.Adress.Street);


Car car = new Car();
car.Manufacturer = "Ford";//heredada
car.NumRuedas = 4;//heredada
car.NumPassengers = 5;//heredada de roadvehicle
car.NumPuertas = 3;//especifica de car
car.RuedaRepuesto = false;//especifica de car
car.Start();//heredado
Console.WriteLine(car.RuedaRepuesto);
MotorCycle moto = new MotorCycle();
moto.Manufacturer = "Peugeot";
moto.NumRuedas = 2;
moto.Copilot = true;
moto.Naked = false;


Truck truck = new Truck();
truck.Manufacturer = "Peugeot";
truck.NumRuedas = 2;
truck.Trailer = true;
truck.TrailerCapacity = 323;


ElectricCar electric1 = new ElectricCar();
electric1.Manufacturer = "Alfa";//heredada de roadvehicle
electric1.NumRuedas = 4;//heredada de roadvehicle
electric1.NumPassengers = 5;//heredada de roadvehicle
electric1.NumPuertas = 5;//heredada de car
electric1.RuedaRepuesto = true;//heeredada de car
electric1.BateryCapacity = 50000;//especifica
electric1.Start();


Car alfaRomeo = new Car();
alfaRomeo.NumPerson = 3;
alfaRomeo.Start();
Console.WriteLine(alfaRomeo.Status+" test "+alfaRomeo.NumPerson);

alfaRomeo.Stop();
Console.WriteLine(alfaRomeo.Status + " caca " + alfaRomeo.NumPerson);


//poliformismo

Customer client = new Customer {
    Dni = "23232323E",
    Vehicle = moto
};
client.Vehicle.Start();


DoSomething(car);
DoSomething(truck);
void DoSomething(RoadVehicle vehicle) {
    vehicle.Start();
    vehicle.Stop();
}
var vehicles = new List<RoadVehicle> {//Pasar en una variable distintas clases
    new MotorCycle{Copilot=true},
    new ElectricCar{BateryCapacity=30000}
};

Customer client2 = new Customer {
    Dni = "3232323W",
    PersonalVehicles = vehicles//Polimorfismo
};

//priny vehicles
client2.PersonalVehicles.ForEach(v=>Console.Write(v));//Mostear en una linea un bucle de una lista