using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces02
{
    class CRadio:IElectronico
    {
        string marca;

        public CRadio(string pMarca)
        {
            marca = pMarca;
        }

        public void Encender(bool pInterruptor)
        {
            if (pInterruptor)
                Console.WriteLine("Encendido");
            else
                Console.WriteLine("Apagado");
        }

        public override string ToString()
        {
            return string.Format("El radio es marca {0}", marca);
        }
    }
}
