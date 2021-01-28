using System;
using System.Collections.Generic;

namespace Lambda02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacemos lo mismo que en el ejemplo anterior "Lambda01" pero con expresion lambda
            //Solo se pueden usar donde se haga uso de un metodo anonimo o un delegado
            //fuertemente tipificado

            //lista de parametros  => instrucciones a realizar
            //El tipo de los parametros puede ser implicito o explicito (int i)

            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10});

            //Hacemos uso de la expresion lambda
            List<int> numPares = numeros.FindAll(i=>(i%2) ==0);//i=>(i%2) ==0   <- Expresion lambda
            
            //Mostramos los numeros
            foreach (int n in numPares)
                Console.WriteLine(n);

        }

    }
}
