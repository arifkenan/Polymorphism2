using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism2
{
    internal class Cember:Hesapla
    {
        public int yaricap { get; set; }
        public double cevre()
        {
            return 2*yaricap * Math.PI;
        }

        public override double alan()
        {
            return Math.PI*Math.Pow(yaricap, 2);
        }
    }
}
