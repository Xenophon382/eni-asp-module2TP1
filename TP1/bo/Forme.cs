using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.bo
{
    abstract class Forme
    {
        abstract public double Aire();
        abstract public double  Perimetre();
        public override string ToString()
        {
            return " Aire : "+ this.Aire()+" \n Perimetre :" + this.Perimetre() + " \n";
        }
    }

    

}
