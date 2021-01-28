using System;

namespace Excepcion02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excepciones de aplicaciones
            //Necesitamos de cuatro entidades
            //Una clase que represente los detalles de la excepcion
            //Un miembro que lanza una instancia de la excepcion
            //Un bloque de codigo que invoca el codigo que puede generar la excepcion
            //Un bloque que va a cachar o procesar la excepcion si es que ocurre

            //V1, V2, V3
            Caldera miCaldera = new Caldera("Matic-O", 20);
            Random rnd = new Random();

            while (miCaldera.Funciona)
            {
                try
                {
                    miCaldera.Trabajar(rnd.Next(10));
                }
                //catch(Exception e)
                //{
                //    Console.WriteLine("El mensaje: {0}",e.Message);
                //    Console.WriteLine("\n"+((CalderaExcepcion)e).Causa);
                //}

                //Codigo para atrapar nuestra propia excepcion
                catch (CalderaExcepcion e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.Momento);
                    Console.WriteLine(e.Causa);
                }
            }
        }
    }
}
