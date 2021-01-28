using System;
using System.Collections;

namespace Colecciones01Queue
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue miQ = new Queue(); //FIFO

            //Adicionamos objetos
            miQ.Enqueue("Manzana");
            miQ.Enqueue("Freza");
            miQ.Enqueue("Pera");

            //Iteramos
            foreach (string fruta in miQ)
                Console.WriteLine("->{0}",fruta);

            Console.WriteLine("-----");

            //Obtenemos objeto
            Console.WriteLine("Dequeue {0}", miQ.Dequeue());//Dequeue Saca el elemento
            Console.WriteLine("Dequeue {0}", miQ.Dequeue());

            foreach (string fruta in miQ)
                Console.WriteLine("->{0}", fruta);

            Console.WriteLine("-----");

            //Adicionamos objetos
            miQ.Enqueue("Limon");
            miQ.Enqueue("Mango");
            miQ.Enqueue("Ciruela");

            //Observamos el objeto
            Console.WriteLine("Peek {0}", miQ.Peek());//Peek sólo muestra, NO SACA!

            foreach (string fruta in miQ)
                Console.WriteLine("->{0}", fruta);

            Console.WriteLine("-----");

            //Conteo de objetos
            Console.WriteLine("Elementos: "+miQ.Count);
            Console.WriteLine("-----");

            //Verificamos si existe 
            Console.WriteLine(miQ.Contains("Mango"));
            Console.WriteLine(miQ.Contains("Manzana"));


        }
    }
}
