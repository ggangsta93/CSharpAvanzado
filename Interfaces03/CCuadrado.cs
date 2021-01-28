using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces03
{
    //implementa dos interfaces que tienenmetodos con el mismo nombre
    //Esto lo resolvemos con la implementacion explicita de interfaces
    class CCuadrado:IArea,IPerimetro
    {
        private int lado;

        public CCuadrado(int pLado)
        {
            lado = pLado;
        }

        void IArea.Calcular()
        {
            Console.WriteLine("Calcular area= {0}",lado*lado);
        }

        void IPerimetro.Calcular()
        {
            Console.WriteLine("Calcular perimetro= {0}", lado * 4);
        }
    }
}
