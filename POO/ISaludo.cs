using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;
//Las interfaces so ntipos abstractos, es decir, no implementan metodos, solo los declaran

public interface ISaludo {//normalmente se introduce al nomanglatura se añada I para identificar que es una "Interface"
    void Saludar();//declara, dice qué se hace
    void Saludar(string nombre);
}

