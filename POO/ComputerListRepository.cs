using System;
using System.Collections.Generic;
using System.Linq;
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
            new Computer{Id=4,Model="Intel 23.2A",Ram=4},
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
            if (computer.Ram >= min&&computer.Ram<=max) {
                computersByRam.Add(computer);
            }
        }
        return computersByRam;
    }
}

