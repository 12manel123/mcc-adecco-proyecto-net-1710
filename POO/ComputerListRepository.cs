using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POO;
internal class ComputerListRepository : IComputerRepository {

    //Atributo
    private List<Computer> computers;
    //Constructor

    public ComputerListRepository() {
        computers = new List<Computer> {
            new Computer{Id=1,Model="MackBro",Ram=8},
            new Computer{Id=2,Model="MSI",Ram=2},
            new Computer{Id=3,Model="Asus 12A",Ram=16},
            new Computer{Id=4,Model="Intel 23.2A",Ram=4}
        };
    }

    //Implementar métodos de interfaz
    public List<Computer> FindAll() {
        return computers;
    }

    public Computer FindById(int id) {
        int i = 0;
        foreach  (Computer computer in computers) {

            if (computer.Id == id) {
                return computers[i];
            }
            i++;
        }
        return null;
    }

    public bool ExistsById(int id) {
        foreach (Computer computer in computers) {
            if (computer.Id == id) {
                return true;
            }
        }
        return false;
    }

    public List<Computer> FindByRam(int min,int max) {
        List<Computer> computersByRam = new List<Computer>();
        foreach (Computer computer in computers) {
            if (computer.Ram >= min && computer.Ram <= max) {
                computersByRam.Add(computer);
            }
        }
        return computersByRam;
    }


   

    public Computer FindByModel(string model) {
        foreach (Computer computer in computers) {
            if (computer.Model.ToLower().Equals(model.ToLower())) {
                return computer;
            }
        }
        return null;
    }


    public bool Save(Computer computer) {
            if (ExistsById(computer.Id) != true) {
                new Computer { Id = computer.Id, Model = computer.Model, Ram = computer.Ram };
                ComputerValidator validator = new ComputerValidator();
            if (validator.Validate(computer)) {
                computers.Add(computer);//añadi esto para poder agregarlo
                Console.WriteLine("Creado correctamente");
            }
            else {
                Console.WriteLine("Validación erronea");
                return false;
            }
                return true;
            }
            else { return false; }
    }

    public int ComputersLength() {
        int i = 0;
        foreach (Computer computer in computers) {
            i++;
        }
        return i;
    }
    public int SaveAll(List<Computer> computersToAdd) {
        /*List<Computer> newComputers = new List<Computer>();
        foreach (Computer computer in computersToAdd) {
            if (ExistsById(computer.Id) != true) {
                newComputers.Add(computer);
            }
            else { return false; }
        }
        return true;*///Otra manera si nutrizar otras funciones

        int contador = 0;
        foreach (Computer computer in computersToAdd) {
            bool saved = Save(computer);
            if (saved) contador++;
        }
        return contador;
    }



    public void PrintAll() {
        foreach(Computer computer in computers) 
            Console.WriteLine(computer);
    }


    public bool Update(Computer computer) {

        if(ExistsById(computer.Id)) {
            for (int i=0; i<computers.Count; i++) {
                if (computers[i].Id == computer.Id) {
                    computers[i].Model = computer.Model;
                    computers[i].Ram = computer.Ram;
                    Console.WriteLine("Update successful with id: "+computer.Id);
                    return true;
                }
            }
            return false;
        }
        else {
            Console.WriteLine("Computer not found");
            return false;
        }


    }


    public void RemoveComputer(Computer computer) {
        computers.Remove(computer);
    }
    public void RemoveAllComputers() {
        if (computers.Any()) {
            computers.Clear();
            Console.WriteLine("Deleted all completed");

        }

        /*foreach (Computer computer in computers)
            computers.Remove(computer);*/


        //computers.Remove(computer);


    }

    public bool RemoveComputerById(int id) {
        if (ExistsById(id)) {
            for (int i = 0; i < computers.Count; i++) {

                if (computers[i].Id == id) {
                    computers.RemoveAt(i);
                    // computers.Remove(FindById(id));
                    return true;
                }
            }
            return false;
        }
        return false;
        /*
        computers.Remove(FindById(id));//Impemetaa removeAt despues*/

    }
    public int RemoveComputerByIds(List<int>ids) {
        int i = 0;
        foreach (int id in ids) {
            bool deleted = RemoveComputerById(id);
            if (deleted) i++;
        }
        return i;

    }

    public int CalculateMediumRam() {
        int media = 0;
        foreach (Computer computer in computers) {
            media+=computer.Ram;
        }
        return media / computers.Count;


    }
    public int CalculateMaxRam() {
        int max = 0;
        foreach (Computer computer in computers) {
            if (max <= computer.Ram) {
                max = computer.Ram; 
            } 
        }
        return max;
    }
    public int CalculateMinRam() {
        int min = computers[0].Ram;
        foreach (Computer computer in computers) {
        
            if (min >= computer.Ram) {
                min = computer.Ram;
            }
        }
        return min;
    }

}

