using System;

namespace Apuntadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apuntadores
            //Es necesario poner el proyecto en unsafe ->Proyecto->Compilar->Permitir "Codigo no seguro"

            unsafe
            {
                int valor = 5;

                //Creo apuntador
                int* p;//Se lee, apuntador ó apunta a 

                //Hago que apunte a la direccion de valor
                p = &valor;//Se lee, dirección de

                Console.WriteLine(*p);

                Console.WriteLine("-----Cambiamos el valor-----");
                *p = 67;
                Console.WriteLine(*p);
                Console.WriteLine(valor);
            }
            //Aquí codigo duera de unsafe
            Console.WriteLine("--Haremos un swap---");

            int a = 3;
            int b = 8;

            Console.WriteLine("a={0}, b={1}",a,b);

            //Invocamos el metodo que usa apuntadores
            unsafe
            {
                swap(&a, &b); 
            }
            Console.WriteLine("a={0}, b={1}", a, b);
        }

        //Creacion de un metodo que usa apuntadores
        unsafe public static void swap(int* n, int* m)
        {
            int temp = *m;
            *m = *n;
            *n = temp;
        }
    }
}
