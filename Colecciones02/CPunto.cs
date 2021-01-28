using System;
using System.Collections.Generic;
using System.Text;

namespace Colecciones02
{
    class CPunto
    {
        private int x;
        private int y;

        public CPunto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format("X={0}, Y={1}",x ,y);
        }
    }
}
