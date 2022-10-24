using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace POO;
public class ComputerValidator {

    public bool Validate(Computer computer) {
        if (computer == null || computer.Id == 0) {return false;}
        if (computer.Ram<= 2 || computer.Ram >= 256) { return false; }
        if (computer.Model == null || computer.Model.Length <= 3) { return false; }
        return true;
    }
}

