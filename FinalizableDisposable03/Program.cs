using System;

namespace DisposableObjects03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos objetos
            CPrueba objeto1 = new CPrueba(5);
            CPrueba objeto2 = new CPrueba(7);

            Console.WriteLine(objeto1);
            Console.WriteLine(objeto2);

            //Hacemos dispose de objeto1
            objeto1.Dispose();

            Console.WriteLine("---Fin del programa---");

        }
    }
}
