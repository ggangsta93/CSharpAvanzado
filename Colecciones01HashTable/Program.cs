using System;
using System.Collections;

namespace Colecciones01HashTable
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable miTtabla = new Hashtable();

            miTtabla.Add(123, "Hola");
            miTtabla.Add(234, "Saludos");
            miTtabla.Add(45, "Adios");
            miTtabla.Add(567, "C#");
            miTtabla.Add(12763, "Programacion");

            //Mostramos los elementos
            foreach (DictionaryEntry elemento in miTtabla)
                  Console.WriteLine("({0},{1})", elemento.Key, elemento.Value);

            //Intentamos coloca un elemento con llave repetida
            //miTtabla.Add(123,"Otro Mas");

            Console.WriteLine("---");

            //Cantidad de elementos
            Console.WriteLine(miTtabla.Count);

            Console.WriteLine("---");

            //Obtenemos el elemento de determinada llave
            Console.WriteLine(miTtabla[567]);//Retorna-> C#
            //Console.WriteLine(miTtabla[445]);

            Console.WriteLine("---");

            //Colocamos elemento en una lista
            miTtabla[45] = "Avanzado";
            miTtabla[300] = "Colecciones";//Esto tambien adiciona

            foreach (DictionaryEntry elemento in miTtabla)
            {
                Console.WriteLine("({0},{1})", elemento.Key, elemento.Value);
            }

            Console.WriteLine("---");

            //Verificamos si hay un elemento
            Console.WriteLine(miTtabla.Contains(567));//Retorna True o False
            Console.WriteLine(miTtabla.Contains(335));

            Console.WriteLine("---");

            //Eliminar un elemento
            miTtabla.Remove(234);

            foreach (DictionaryEntry elemento in miTtabla)
            {
                Console.WriteLine("({0},{1})", elemento.Key, elemento.Value);
            }

            Console.WriteLine("---");

            foreach (int llave in miTtabla.Keys)
                Console.WriteLine("({0})",llave);

            Console.WriteLine("---");
            
            foreach (String valor in miTtabla.Values)
                Console.WriteLine("({0})", valor);
        }
    }
}
