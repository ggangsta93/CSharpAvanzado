using System;
using System.Collections;


namespace Colecciones01SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList miSLista = new SortedList();

            //Adicionamos
            miSLista.Add(754, "Honda");
            miSLista.Add(123, "Volvo");
            miSLista.Add(587, "Nissan");
            miSLista.Add(323, "Fiat");

            //Iteramos
            foreach (DictionaryEntry elemento in miSLista)
                Console.WriteLine("({0},{1})", elemento.Key, elemento.Value);

            Console.WriteLine("-------");

            //Cantidad de elementos
            Console.WriteLine(miSLista.Count);

            //Contiene elemento
            Console.WriteLine(miSLista.Contains(123));//True
            Console.WriteLine(miSLista.Contains(678));//False

            Console.WriteLine(miSLista.ContainsKey(587));
            Console.WriteLine(miSLista.ContainsValue("Volvo"));

            Console.WriteLine("-------");

            //Obtenemos elemento por indice
            Console.WriteLine(miSLista.GetKey(2));//Obtiene la llave del indice 2
            Console.WriteLine(miSLista.GetByIndex(2));//Obtiene el valor del indice 2
        }
    }
}
