using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    internal class Dikdortgen:Hesapla
    {
        public double uzunkenar { get; set; }
        public double kisakenar { get; set; }

        public override double alan() { return kisakenar*uzunkenar; }
    }
}
