using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO;
public class Guest {

    private int age;

    public int Age {
        get { return age; }//getter que permite obtener el age
        set {//seter para poder cambiar el valor 
            if (value >= 18)
                age = value;
            else
                age = 18;
        }
    }
    public string Dni { get; }
    public double Salary { get; private set; }

    public void Promote (double quatity) {
        Salary += quatity;
    }
    public void Promote() {
        double quantity = CalcSalaryPromotion();
        Salary += quantity;
    }
    private double CalcSalaryPromotion() {
        return 100.0;
    }


}
