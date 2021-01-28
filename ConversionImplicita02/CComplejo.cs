using System;
using System.Collections.Generic;
using System.Text;

namespace ConversionExplicita02
{
    class CComplejo
    {
        //a+bi
        private int a;
        private int b;

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }

        public CComplejo(int pa, int pb)
        {
            a = pa;
            b = pb;
        }

        public override string ToString()
        {
            return string.Format("{0}+{1}i",a,b);
        }

        //Creamos una conversion explicita a reales
        public static explicit operator CReal(CComplejo pi)
        {
            CReal temp = new CReal();
            temp.R = pi.a;
            return temp;
        }
    }
}
