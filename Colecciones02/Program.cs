using System;
using System.Collections.Generic;

namespace Colecciones02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>();
            int n = 0;
            int r = 0;

            valores.Add(7);
            valores.Add(5);
            valores.Add(4);
            valores.Add(3);
            valores.Add(8);
            valores.Add(9);

            //Recorremos con ciclo for
            for (n = 0; n < valores.Count; n++)
            {
                //No hay necesidad de type cast
                r = valores[n];
                Console.WriteLine(r);
            }


            //Vamos si contiene a determinado elemento
            Console.WriteLine("---Contains(5)----");
            Console.WriteLine("---Contains(17)----");
            Console.WriteLine(valores.Contains(5));
            Console.WriteLine(valores.Contains(17));

            for (n = 0; n < valores.Count; n++)
            {
                r = valores[n];
                Console.WriteLine(r);
            }

            //Obtenemos indice de un elemento
            Console.WriteLine("---IndexOf(54)----");
            Console.WriteLine(valores.IndexOf(54));//Si retorna -1 no existe el elemento

            //Insertamos elemento en un indice
            Console.WriteLine("---Insert(2,55)----");
            valores.Insert(2, 55);

            foreach(int valor in valores)
                Console.WriteLine(valor);

            //Eliminacion elemento en un indice
            Console.WriteLine("---RemoveAt(3)----");
            valores.RemoveAt(3);
            foreach (int valor in valores)
                Console.WriteLine(valor);

            //Eliminamos la primera ocurrencia de un valor
            Console.WriteLine("---Remove(8)----");
            valores.Remove(8);

            foreach (int valor in valores)
                Console.WriteLine(valor);


            //La lista se coloca en sentido contrario
            Console.WriteLine("---Reverse()----");
            valores.Reverse();

            foreach (int valor in valores)
                Console.WriteLine(valor);

            //Mandamos a ordenar la lista
            Console.WriteLine("---Sort()----");
            valores.Sort();
            foreach (int valor in valores)
                Console.WriteLine(valor);


            //Creamos una lista para nuestra clase
            Console.WriteLine("---SE CREA UNA CLASE CPUNTO----");
            List<CPunto> listaPuntos = new List<CPunto>();
            listaPuntos.Add(new CPunto(5, 3));
            listaPuntos.Add(new CPunto(7, 8));
            listaPuntos.Add(new CPunto(12, 5));
            listaPuntos.Add(new CPunto(6, 2));

            foreach (CPunto punto in listaPuntos)
                Console.WriteLine(punto);

            //listaPuntos.Sort();<--No funciona porque no implementa el medoto IComparable

        }
    }
}
