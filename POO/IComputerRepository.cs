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

    //buscar por Ram

    //buscar por Model

    //guardar

    //modificar

    //borrar

    //borrar todos de la lista

    //borrar por ids



}

