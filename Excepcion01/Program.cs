using System;
using System.Collections;

namespace Excepcion01
{
    class Program
    {
        static void Main(string[] args)
        {
            Caldera miCaldera = new Caldera("Matic-o",20);

            //V1
            //for (int i = 0; i < 10; i++)
            //    miCaldera.Trabajar(20);

            //V2
            //try
            //{
            //    for (int i = 0; i < 10; i++)
            //        miCaldera.Trabajar2(20);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("\nSucedió la excepción");
            //    //Informacion que nos provee la excepcion
            //    Console.WriteLine("En este metodo: {0}",e.TargetSite);
            //    Console.WriteLine("Con este mensaje de error: {0}", e.Message);
            //    Console.WriteLine("Fuente: {0}", e.Source);
            //    Console.WriteLine("Clase donde ocurrió: {0}",e.Source);
            //    Console.WriteLine("Tipo de miembro: {0}",e.TargetSite.MemberType);
            //    Console.WriteLine("Stack: {0}",e.StackTrace);
            //}

            //V3
            try
            {
                for (int i = 0; i < 10; i++)
                    miCaldera.Trabajar3(20);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nSucedió la excepción");
                //Informacion que nos provee la excepcion
                Console.WriteLine("En este metodo: {0}", e.TargetSite);
                Console.WriteLine("Con este mensaje de error: {0}", e.Message);
                Console.WriteLine("Fuente: {0}", e.Source);
                Console.WriteLine("Clase donde ocurrió: {0}", e.Source);
                Console.WriteLine("Tipo de miembro: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Stack: {0}", e.StackTrace);

                Console.WriteLine("Help Link: {0}",e.HelpLink);
                Console.WriteLine("-----------Mostramos los datos propios-----------");
                if(e.Data != null)
                {
                    //Imprimios los datos extra propios
                    foreach (DictionaryEntry dato in e.Data)
                        Console.WriteLine("{0} {1}",dato.Key, dato.Value);
                }
            }


        }
    }
}
