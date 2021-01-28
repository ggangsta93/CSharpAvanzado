using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces01
{
    class Cpelota
    {
        string tamano;

        public Cpelota(string pTamano)
        {
            tamano = pTamano;
        }

        public override string ToString()
        {
            return string.Format("El tamaño de la pelota es {0}", tamano);
        }
    }
}
