using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoExtension03
{
    class MiInt : ISaludador
    {
        private int a;

        public MiInt(int pA)
        {
            a = pA;
        }
        public override string ToString()
        {
            return string.Format("Tu int es {0}",a);
        }

        public void Saludar()
        {
            Console.WriteLine("Hola desde mi int {0}",a);
        }
    }
}
