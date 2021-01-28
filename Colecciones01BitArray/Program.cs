using System;
using System.Collections;

namespace Colecciones01BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray miArreglo = new BitArray(new byte[] { 1, 2, 4, 8, 16 });
            
            //Cantidad de elementos, 5 bytes*8 = 40bits
            Console.WriteLine(miArreglo.Count);
            MuestraArreglo(miArreglo);//De menos significativo a más significativo

            Console.WriteLine("---");

            //Obtenemos un bit en particular
            Console.WriteLine("El bit es: "+miArreglo.Get(3));//Devuelve el bit que se encuentra en el indice 3, 0=>False

            //Ponemos un bit en particular
            miArreglo.Set(3, true);
            MuestraArreglo(miArreglo);
            Console.WriteLine(miArreglo.Get(3));//Devuelve el bit que se encuentra en el indice 3, 1=>True

            //Clonamos el bitArray
            BitArray arreglo2 = (BitArray)miArreglo.Clone();//Retorna un object
            MuestraArreglo(arreglo2, "Arreglo2 ");

            //Invertimos el arreglo, NOT
            arreglo2.Not();//OJO: Los cambios de la inversion los hace sobre el mismo arreglo original
            MuestraArreglo(arreglo2, "Arreglo2 ");

            Console.WriteLine("---");

            //Creamos otro
            BitArray arreglo3 = new BitArray(new byte[] { 5, 7, 9, 13, 15 });
            MuestraArreglo(arreglo3, "arreglo3");
            Console.WriteLine("---");

            //Hacemos OR entre arreglos
            Console.WriteLine("====OR====");
            arreglo3.Or(miArreglo);
            MuestraArreglo(miArreglo, "miArreglo");
            MuestraArreglo(arreglo3, "arreglo3");

            //Hacemos el AND, arreglo 3 se modifica con el resultado
            Console.WriteLine("====AND====");
            arreglo3.And(miArreglo);
            MuestraArreglo(arreglo3, "arreglo3");

            //Hacemos XOR entre arreglos
            Console.WriteLine("====XOR====");//Regresa 1 cuando los 2 sean diferentes, Regresa 0 cuando sean iguales
            arreglo3 = new BitArray(new byte[] { 5, 7, 9, 13, 21 });
            MuestraArreglo(miArreglo, "miArreglo");
            MuestraArreglo(arreglo3, "arreglo3");

            arreglo3.Xor(miArreglo);
            MuestraArreglo(arreglo3, "arreglo3");
        
        }


        public static void MuestraArreglo(BitArray pArreglo, string pNombre="")//Parametro opcional pNombre
        {
            int c = 0;
            Console.Write("{0}\t",pNombre);

            foreach (bool b in pArreglo)
            {
                c++;
                if (b)
                    Console.Write("1");
                else
                    Console.Write("0");
                if (c % 8 == 0)
                    Console.Write(",");
            }
            Console.WriteLine();
        }

    }
}
