using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.bo
{
    class Cercle : Forme
    {
        public int Rayon { get; set; }

        public override double Aire()
        {
            return (Math.PI * Math.Pow(this.Rayon, 2));
        }

        public override double Perimetre()
        {
            return 2 * Math.PI * this.Rayon;
        }

        public override string ToString() =>"Cercle de rayon " + this.Rayon + "\n" + base.ToString();
    }
}
