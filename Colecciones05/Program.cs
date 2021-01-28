using System;
using System.Collections.Generic;

namespace Colecciones05
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<CPunto> puntos = new Queue<CPunto>();
            puntos.Enqueue(new CPunto(3, 7));
            puntos.Enqueue(new CPunto(7, 9));
            puntos.Enqueue(new CPunto(11, 2));

            foreach (CPunto p in puntos)
                Console.WriteLine("-> {0}", p);

            //Hacemos un pick
            Console.WriteLine("----Hacemo Peek()----");
            Console.WriteLine("Peek {0}", puntos.Peek());

            foreach (CPunto p in puntos)
                Console.WriteLine("-> {0}", p);

            //Hacemos Dequeue
            Console.WriteLine("----Hacemo Dequeue()----");
            Console.WriteLine("Dequeue {0}", puntos.Dequeue());
            Console.WriteLine("Dequeue {0}", puntos.Dequeue());

            foreach (CPunto p in puntos)
                Console.WriteLine("-> {0}", p);
        }
    }
}
