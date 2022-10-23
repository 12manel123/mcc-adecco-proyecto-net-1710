using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;
internal interface IComputerRepository {

    List<Computer> FindAll();

    Computer FindById(int id);

    //comproar si existen por id
    bool ExistsById(int id);

    //recuperar varios por ids



    //recuperar por Ram
    List<Computer> FindByRam(int min, int max);

    //buscar por Model

    Computer FindByModel(string model);


    //guardar
    bool Save(Computer computer);
    //recuperar num ordenadores
    int ComputersLength();
    //guardar varios
    int SaveAll(List<Computer> computersToAdd);

    //imprimir por consola los ordenadres de la lista
    void PrintAll();

    //borrar
    void RemoveComputer(Computer computer);

    //borrar todos de la lista

    //borrar por ids

    //añador cosas de precios(ideas)

    }

