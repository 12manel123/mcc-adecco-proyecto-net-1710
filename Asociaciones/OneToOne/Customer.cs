using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociaciones.OneToOne;
public class Customer {

    //Atributos
    public int Id;
    public string Name;
    public int Age;

    //Asociaciones
    public Address Address;

    //Constructores
    public Customer() { }
    //Métodos

    //ToStrng
    public override string ToString() {
        return $"Customer: {Id}, Name: {Name}, Age: {Age}";
    }


     
}

