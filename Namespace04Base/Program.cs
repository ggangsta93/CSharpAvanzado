using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Despues de colocar la referencia ponemos el namespace
using Aritmetica;


namespace Namespace04Base
{
    class Program
    {
        /*Assembly private. Se creó un carpeta Bibliotecas y se pasó la Aritmetica.dll y se modificó App.config*/
        static void Main(string[] args)
        {
            //Creamos el objeto de la biblioteca
            MisMates mates = new MisMates(5,3);

            Console.WriteLine("El resultado de la suma es: "+mates.suma());
            mates.multi();
            Console.WriteLine("El resultado de la multiplicacion es: " + mates.R);
            Console.ReadKey();
        }
    }
}
