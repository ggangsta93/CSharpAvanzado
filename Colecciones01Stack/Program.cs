using System;
using System.Collections;

namespace Colecciones01Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack miStack = new Stack(); //LIFO

            //Agregamos elemento
            miStack.Push("Manzana");
            miStack.Push("Pera");
            miStack.Push("Ciruela");
            miStack.Push("Mango"); //<----El último que entra es el primero que sale!

            //Iteramos el stack
            foreach (string fruta in miStack)
                Console.WriteLine("-> {0}", fruta);

            Console.WriteLine("------");

            //Hacemos pop
            Console.WriteLine(miStack.Pop());

            foreach (string fruta in miStack)
                Console.WriteLine("-> {0}", fruta);

            Console.WriteLine("------");

            //hacemos Peek
            Console.WriteLine(miStack.Peek());

            foreach (string fruta in miStack)
                Console.WriteLine("-> {0}", fruta);

            Console.WriteLine("------");

            //Cantidad de elementos
            Console.WriteLine(miStack.Count);

            Console.WriteLine("------");

        }
    }
}
