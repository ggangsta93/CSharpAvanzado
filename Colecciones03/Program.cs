using System;
using System.Collections.Generic;

namespace Colecciones03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista de objetos de muestra clase
            //Adiciona explicita, no con Add

            List<CPunto> puntos = new List<CPunto> {
                new CPunto(2,3), //Esta forma reemplaza vía Add
                new CPunto(5, 23), 
                new CPunto(7, 9)
            };

            foreach (CPunto p in puntos)
                Console.WriteLine(p);

            //Adicionamos un punto
            Console.WriteLine("------Add(new CPunto(45, 90))-------");
            puntos.Add(new CPunto(45, 90));

            foreach (CPunto p in puntos)
                Console.WriteLine(p);

            //Insertamos un punto
            Console.WriteLine("------Insert(2, new CPunto(100, 150))-------");
            puntos.Insert(2, new CPunto(100, 150));

            foreach (CPunto p in puntos)
                Console.WriteLine(p);

            //Copiamos de lista a arreglo
            Console.WriteLine("------PASARLO A ARREGLO-------");
            CPunto[] arregloPuntos = puntos.ToArray();

            for (int n=0; n<arregloPuntos.Length; n++)
            {
                Console.WriteLine(arregloPuntos[n]);
            }

        }
    }
}
