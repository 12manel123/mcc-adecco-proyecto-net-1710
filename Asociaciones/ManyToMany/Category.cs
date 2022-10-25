using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociaciones.ManyToMany;
internal class Category {
    public long Id;
    public string Name;
    public string Color;

    public List<Film> Films = new List<Film>();//Importante inicializar

    public Category() { }

    public override string ToString() {
        return $"Author: {Id}, Name: {Name}, Color: {Color}, Films: {Films.Count}";
    }
}
