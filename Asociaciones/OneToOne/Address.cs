using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociaciones.OneToOne;
public class Address {
    //Atributos
    public int Id;
    public string Street;
    public string City;


    //Asociaciones
    public Customer Customer;//bidirecional (opcional)
    public Address(){}
    //ToString
    public override string ToString() {
        return $"Customer: {Id}, Name: {Street}, Age: {City}";
    }

}
