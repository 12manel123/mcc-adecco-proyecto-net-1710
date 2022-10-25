using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Asociaciones.ManyToOne;
using static System.Reflection.Metadata.BlobBuilder;

namespace Asociaciones.ManyToMany;
internal class Film {
    public long Id;
    public string Title;
    public int Duration;

    public List<Category> Categoryes = new List<Category>();//Importante inicializar

    public Film() { }

    public override string ToString() {
        return $"Film: {Id}, Name: {Title}, Duration: {Duration}, Categories: {Categoryes.Count}";
    }
}
