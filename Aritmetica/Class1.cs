using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetica
{
    //ESTO ESTO ES UNA BIBLIOTECA, Ya está compilado y está como Aritmetica.dll
    public class MisMates
    {
        private double a;
        private double b;
        private double r;
        
        public MisMates(double pA, double pB)
        {
            a = pA;
            b = pB;
        }
        public double R { get => r; set => r = value; }

        public double suma()
        {
            r = a + b;
            return r;
        }

        public double multi()
        {
            r = a * b;
            return r;
        }
    }
}
