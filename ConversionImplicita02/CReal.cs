using System;
using System.Collections.Generic;
using System.Text;

namespace ConversionExplicita02
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

        //Creamos una conversion implicita de reales a imaginarios
        public static implicit operator CComplejo(CReal pR)
        {
            CComplejo temporal = new CComplejo((int)pR.r,0);
            return temporal;
        }

    }
}
