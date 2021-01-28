using System;

namespace MetodoExtension03
{
    class Program
    {
        /*MOTIVACION:
         * Es una tecnica por medio de la cual podemos adicionar un comportamiento, un método a una clase
         * a la que nosotros no tenemos acceso al código o que no nos convenga modificar.
         * Si queremos hacer un cambio en una clase donde dañemos una cadena de herencia
        */
        static void Main(string[] args)
        {
            //Este programa muestra el uso de metodos de extension

            //Extension de int
            int numero = 55;

            bool par = numero.EsPar();//Aqui encontramos la extension
            Console.WriteLine("{0} es {1}",numero,par);
            Console.WriteLine("---------");
            
            //Extension de double
            double valor = 55.18;
            Console.WriteLine(valor.Dobletea());
            Console.WriteLine("---------");

            //Extension ISaludador
            MiInt entero = new MiInt(7);
            entero.Sonido();//Este se agraga a todas las clases que implementan dicha interfaz
            entero.Despedida();//Este solo se agrega a esta clase en particular




        }

    }
}
