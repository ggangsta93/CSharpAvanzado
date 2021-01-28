using System;
using System.Collections.Generic;
using System.Text;

namespace ConversionExplicita01
{
    class CReal
    {
        private double r;

        public CReal(){}
        public CReal(double pr)
        {
            r = pr;
        }
        
        public double R { get => r; set => r = value; }

        public override String ToString()
        {
            return string.Format("r={0}", r);
        }
    }
}
