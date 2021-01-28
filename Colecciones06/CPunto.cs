using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Colecciones06
{
    class CPunto:IComparable<CPunto>
    {
        private int x;
        private int y;

        public CPunto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int CompareTo(CPunto b)
        {
            double maga = Math.Sqrt(x * x + y * y);
            double magb = Math.Sqrt(b.x * b.x + b.y * b.y);
            if (maga > magb)
                return 1;
            if (maga < magb)
                return -1;
            else
                return 0;
            
        }

        public override string ToString()
        {
            return string.Format("X={0}, Y={1}",x ,y);
        }
    }
}
