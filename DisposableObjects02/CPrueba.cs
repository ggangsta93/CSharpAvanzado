using System;
using System.Collections.Generic;
using System.Text;

namespace DisposableObjects02
{
    //Implementamos a IDisposable
    class CPrueba:IDisposable
    {
        private int a;

        public CPrueba(int pA)
        {
            a = pA;
        }
        public override string ToString()
        {
            return string.Format("El valor es {0}",a);
        }

        public void Dispose()
        {
            Console.WriteLine("Estamos en Dispose, aqui liberamos lo no administrado {0}",a);
        }
    }
}
