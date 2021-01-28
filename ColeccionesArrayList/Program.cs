using System;
using System.Collections;

namespace Colecciones01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coleccion adentro de System.Colecction
            //ArrayList
            //BitArray
            //HashTable (k,v)
            //Queue
            //SortedList(k,v) k,[]
            //Stack

            ArrayList palabras = new ArrayList();
            int n = 0;
            int r = 0;

            //Podemos adicionar con rango
            palabras.AddRange(new string[] { "Hola", "cómo", "estan?" });//Se pasa una coleccion como parametro
            Console.WriteLine("Cantidad de elemento en el ArrayList es {0}", palabras.Count);

            //Recorremos con ciclo for
            for (n = 0; n < palabras.Count; n++)
                Console.Write(" {0}", palabras[n]);
            Console.WriteLine();
            Console.WriteLine("------------");

            //Otra forma de adicionar elementos
            palabras.Add("Bien y tú?");

            //Recorremos con foreach
            foreach (string palabra in palabras)
                Console.Write(" {0}", palabra);
            Console.WriteLine();
            Console.WriteLine("------------");

            ArrayList valores = new ArrayList();
            valores.Add(5);
            valores.Add(7);
            valores.Add(4);

            for (n = 0; n < valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }
            Console.WriteLine("------------");

            //Vemos si existe un elemento en el ArrayList
            Console.WriteLine(valores.Contains(5));//Retorna True
            Console.WriteLine(valores.Contains(17));//Retorna False
            Console.WriteLine("------------");

            //Insertamos en un indice en particular
            valores.Insert(2, 55);

            for (n = 0; n < valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }
            Console.WriteLine("------------");

            //Removemos en un posicion
            valores.RemoveAt(0);
            for (n = 0; n < valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }
            Console.WriteLine("------------");
        }
    }

}
