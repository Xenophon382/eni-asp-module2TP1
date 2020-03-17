using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.bo
{
    class Carre : Forme
    {
        public int Longueur { get; internal set; }

        public override double Aire()
        {
            return Math.Pow(this.Longueur, 2);
        }

        public override double Perimetre()
        {
            return 4 * this.Longueur;
        }

        public override string ToString() => "Carré de coté " + this.Longueur + "\n" + base.ToString();


    }
}
