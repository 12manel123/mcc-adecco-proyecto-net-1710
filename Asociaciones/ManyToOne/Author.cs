using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asociaciones.ManyToOne;
internal class Author {
    public long Id;
    public string Name;
    public int Age;

    public List<Book> Books = new List<Book>();//Importante inicializar
    public Author(){}

    public override string ToString() {
        return $"Author: {Id}, Name: {Name}, Books: {Books.Count}";
    }
}