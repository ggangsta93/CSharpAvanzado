using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces04
{
    //Ahora implementamos ICalcular que al tener la jerarquia tambien nos forza a 
    //implementar IMostrar
    class CSuma : ICalcular
    {
        private int a;
        private int b;
        private int r;
        
        //Implementacion de ICalcular
        public int Calculo(int pa, int pb)
        {
            a = pa;
            b = pb;
            r = a + b;
            return r;
        }

        //Implementamos de IMostrar por la jerarquia
        public void MostrarDatos()
        {
            Console.WriteLine("{0} + {1} = {2}",a,b,r);
        }
    }
}
