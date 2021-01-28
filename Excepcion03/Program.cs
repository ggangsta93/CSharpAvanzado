using System;

namespace Excepcion03
{
    class Program
    {
        //Multiples excepciones
        //V1
        static void Main(string[] args)
        {
            Caldera miCaldera = new Caldera("Matic-O", 20);
            try
            {
                //Forzamos una excepcion de argumento fuera de rango
                miCaldera.Trabajar(-10);
            }
            catch (CalderaExcepcion e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)//<-------Toco poner las excepciones de la más particular a las más general
            {
                Console.WriteLine(e.Message);
            }
        }

        //V4 Atrapamiento generico
        //static void Main(string[] args)
        //{
        //    Caldera miCaldera = new Caldera("Matic-O", 20);
        //    try
        //    {
        //        //Forzamos una excepcion de argumento fuera de rango
        //        miCaldera.Trabajar(-10);
        //    }
        //    catch //El catch no lleva referencia alguna a excepcion
        //    {
        //        Console.WriteLine("Algo salio mal, pero no sabemos que");
        //    }
        //}

        //V5 Se pueden tener excepciones anidadas
        //static void Main(string[] args)
        //{
        //    Caldera miCaldera = new Caldera("Matic-O", 20);
        //    try
        //    {
        //        //Forzamos una excepcion de argumento fuera de rango
        //        miCaldera.Trabajar(-10);
        //        //Anidamos las excepciones
        //        try
        //        {
        //            miCaldera.Trabajar(300);
        //        }
        //        catch(CalderaExcepcion e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //    }
        //    catch(ArgumentOutOfRangeException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}

        ////V6 Uso de Finally
        //static void Main(string[] args)
        //{
        //    Caldera miCaldera = new Caldera("Matic-O", 20);
        //    try
        //    {
        //        //Forzamos una excepcion de argumento fuera de rango
        //        miCaldera.Trabajar(-10);
        //    }
        //    catch (CalderaExcepcion e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    catch (ArgumentOutOfRangeException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    catch (Exception e)//<-------Toco poner las excepciones de la más particular a las más general
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Este es el codigo comun de finally");//Se ejecuta si paso por algun catch o no
        //    }
        //}

        //V7 Esto pasa cuando no manejamos las excepciones
        //static void Main(string[] args)
        //{
        //    Caldera miCaldera = new Caldera("Matic-O", 20);      
        //    //Forzamos una excepcion de argumento fuera de rango
        //    miCaldera.Trabajar(-10);   
        //}

    }
}
