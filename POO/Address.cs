using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;
public class Address {

    public string Street;
    public string PostalCode;
    public string City;
    public Country Country;//ASSOCIACION ENTRE CLASES 
    public Address() {}
        
        
}
public class Country {
    public string Name;
    public string NameISO;
    public bool Corruption;
    public bool Invaded;
    public Country(){}

    //ascoiacion con una nieva clase Language(1:N)
    public List<Language> Languages;
    public void Invadir() {
        Invaded = true;
    }
    public void Abandonar() {
        Invaded = false;
    }
}
public class Language {
    public string Name;
    public int Dialects;
    public Language() {}
}

