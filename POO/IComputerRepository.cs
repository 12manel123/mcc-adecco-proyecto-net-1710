﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
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

    void RemoveAllComputers();

    //borrar por id

    bool RemoveComputerById(int id);
    //borrar por ids

    int RemoveComputerByIds(List<int>ids);


    //modificar un computer
    bool Update(Computer computer);
    //calcular ram media
    int CalculateMediumRam();

    //ram maxima
    int CalculateMaxRam();

    //ram minima

    int CalculateMinRam();

}

