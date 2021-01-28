using System;

namespace TiposAnonimos04
{
    class Program
    {
        /*Motivación:
         * Cuando no se quiere utilizar una clase para tan sólo utilizar sus atributos 
         * Desventajas: Sellada, de solo lectura, no tiene un nombre por tanto no se puede hacer herencia tampoco implementa interfaces.
         * No tiene muchos usos en C#, excepto en LINQ
         */
        static void Main(string[] args)
        {
            //Creamos tipos anonimos
            //Crea un tipo temporal con atributos, propiedades, ToString

            //Creamos el tipo anonimo
            var miCompu = new { Procesador="i7", Memoria=16, Graficos="Intel"};

            //Imprimimos la variable
            Console.WriteLine(miCompu);//Se imprime a la implementación que desciende de object

            //Imprimimos un atributo
            Console.WriteLine("La compu {0} de memoria",miCompu.Memoria);

            //No podemos modificar el atributo, es de solo lectura
            //miCompu.Graficos = "nVidia";
        }
    }
}
