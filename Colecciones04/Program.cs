using System;
using System.Collections.Generic;

namespace Colecciones04
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<CPunto> puntos = new Stack<CPunto>();
            puntos.Push(new CPunto(3, 4));
            puntos.Push(new CPunto(5, 7));
            puntos.Push(new CPunto(9, 11));
            puntos.Push(new CPunto(1, 4));

            foreach (CPunto p in puntos)
                Console.WriteLine("-> {0}", p);

            //Hacemos un pick
            Console.WriteLine("----Hacemo Peek()----");
            Console.WriteLine("Peek {0}", puntos.Peek());

            foreach (CPunto p in puntos)
                Console.WriteLine("-> {0}", p);

            //Hacemos pop
            Console.WriteLine("----Hacemo Pop()----");
            Console.WriteLine("Pop {0}", puntos.Pop());
            Console.WriteLine("Pop {0}", puntos.Pop());

            foreach (CPunto p in puntos)
                Console.WriteLine("-> {0}", p);



        }
    }
}
