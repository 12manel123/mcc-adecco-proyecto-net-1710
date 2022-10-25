using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using System.Xml.Linq;

namespace Asociaciones.ManyToOne;

//Many Books to One Author (ManyToOne)
internal class Book {
    //Atributos
    public long Id;
    public string Title;

    //Asociaciones
    public Author Author;//ManyToOne

    public Book() { }

    public override string ToString() {
        return $"Book: {Id}, Title: {Title}, Author:  {Author.Name}";
    }
}
