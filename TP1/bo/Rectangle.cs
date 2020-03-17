using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.bo
{
    class Rectangle : Forme
    {
        public int Largeur { get; internal set; }
        public int Longueur { get; internal set; }

        public override double Aire()
        {
            return this.Largeur * this.Longueur;
        }

        public override double Perimetre()
        {
            return 2 * (this.Longueur + this.Largeur);
        }

        public override string ToString() => "Rectangle de longueur " + this.Longueur + " et largeur " + this.Largeur + "\n" + base.ToString();

    }
}
