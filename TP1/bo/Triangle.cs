using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.bo
{
    class Triangle : Forme
    {
        public int A { get; internal set; }
        public int B { get; internal set; }
        public int C { get; internal set; }

        public override double Aire()
        {
            double p = this.Perimetre() / 2;
            return Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));
        }

        public override double Perimetre()
        {
            return this.A + this.B + this.C;
        }

        public override string ToString() => "Triangle de coté  A=" + this.A + " B=" + this.B + " C=" + this.C + "\n" + base.ToString();
    }
}
