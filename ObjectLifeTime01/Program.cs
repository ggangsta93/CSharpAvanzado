using System;

namespace ObjectLifeTime01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtenemos la cantidad de byte en el heap
            long bytesHeap = GC.GetTotalMemory(false);
            Console.WriteLine("El heap usa {0} bytes", bytesHeap);

            //Obtenemos la cantidad de generaciones, basada en 0 por eso +1
            int maximaGeneracion = GC.MaxGeneration +1;
            Console.WriteLine("Se tiene {0} generaciones", maximaGeneracion);

            //Creamos una instancia
            CPrueba prueba1 = new CPrueba(5);


            bytesHeap = GC.GetTotalMemory(false);
            Console.WriteLine("El heap usa {0} bytes", bytesHeap);

            //Obtenemos la generacion de la instancia
            int generacionIntancia = GC.GetGeneration(prueba1);
            Console.WriteLine("La generacion de la instancia es {0}",generacionIntancia);

            //Forzar la recoleccion de basuta
            //Solo hacerlo en situaciones especiales
            //Cuando la aplicacion entre un bloque de codigo que no debe ser
            //interrumpido por la recoleccion
            //La aplicacion cre una gran cantidad de instancias y necesita
            //liberar la mayor cantidaad de memoria posible

            //GC.Collect();
            //GC.WaitForPendingFinalizers();

            //Para recolectar de una generacion en particular
            //GC.Collect(0);
            //GC.WaitForPendingFinalizers();
        }
    }
}
