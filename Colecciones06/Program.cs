using System;
using System.Collections.Generic;

namespace Colecciones06
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<CPunto> puntos = new SortedSet<CPunto>();
            puntos.Add(new CPunto(3,7));
            puntos.Add(new CPunto(8, 11));
            puntos.Add(new CPunto(2, 6));

            foreach (CPunto p in puntos)
                Console.WriteLine("->{0}",p);

            Console.WriteLine("--------------------");

            puntos.Add(new CPunto(1, 15));
            puntos.Add(new CPunto(1, 2));

            foreach (CPunto p in puntos)
                Console.WriteLine("->{0}", p);


        }
    }
}
