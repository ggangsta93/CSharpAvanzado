using System;

namespace MetodoAnonimo03
{
    class Program
    {
        static void Main(string[] args)
        {
            CPunto miPunto = new CPunto(5,6);

            //Creamos el metodo anonimo para el delegado
            miPunto.mensaje += delegate ()
            {//Esto es lo que conocemos como un método Anonimo
                Console.WriteLine("Estoy desde el método anonimo");
            };

            Console.WriteLine(miPunto.ToString());

            //Invocamos
            miPunto.mensaje();

            //Adicionamos otro
            miPunto.mensaje += delegate ()
            {//Esto es lo que conocemos como un método Anonimo
                Console.WriteLine("Este es otro método anonimo");
            };

            miPunto.mensaje();
        }
    }
}
