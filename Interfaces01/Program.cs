using System;

namespace Interfaces01
{
    class Program
    {
        /* 3 métodos los cuales nosotros podemos saber si determinado
         * objeto esta implementando una interfaz en particular
        */
        static void Main(string[] args)
        {
            //Como reconocer si un objeto implementa a determinada interfaz

            CTelevisor miTele = new CTelevisor("Sharpy");
            Cpelota miPelota = new Cpelota("Grande");
            IElectronico objeto = null;

            //Metodo 1,por excepcion

            try
            {
                Console.WriteLine("Probamos la tele");
                objeto = (IElectronico)miTele;
                objeto.Encender(true);
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("Probamos la pelota");
                objeto = (IElectronico)miPelota;
                objeto.Encender(true);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);

            }

            Console.WriteLine("-----Metodo 2---------");
            //Metodo2, por as (puede ser tratado como)
            Console.WriteLine("Probamos la tele");
            objeto = miTele as IElectronico;

            if (objeto != null)
                objeto.Encender(true);
            else
                Console.WriteLine("No implementa IElectronico");

            Console.WriteLine("Probamos la pelota");
            objeto = miPelota as IElectronico;

            if (objeto != null)
                objeto.Encender(true);
            else
                Console.WriteLine("No implementa IElectronico");

            Console.WriteLine("-----Metodo 3---------");
            //Metodo3, por is (es p es compatible con)
            Console.WriteLine("Probamos la tele");

            if (miTele is IElectronico)
                miTele.Encender(true);
            else
                Console.WriteLine("No implementa IElectronico");

            Console.WriteLine("Probamos la pelota");

            if (miPelota is IElectronico)
                //miPelota.Encender(true);
                Console.WriteLine("Wow tienes una pelota electronica");
            else
                Console.WriteLine("No implementa IElectronico");




        }
    }
}
