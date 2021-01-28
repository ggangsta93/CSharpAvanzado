using System;

namespace DelegadoGenerico01
{
    //Creamos el delegado generico
    public delegate void miDelegado<T>(T p);
    class Program
    {
        static void Main(string[] args)
        {
            //Registramos y usamos el string
            miDelegado<string> delCadena = new miDelegado<string>(HandlerString);
            delCadena("Hola a todos");

            //Registramos y usamos el double
            miDelegado<double> delDoble = new miDelegado<double>(HandlerDouble);
            delDoble(58.7);
        }


        //Handler para el caso string
        static void HandlerString(string p)
        {
            Console.WriteLine("Uso string como tipo y el valor es {0}",p);
        }

        static void HandlerDouble(double p)
        {
            Console.WriteLine("Uso double como tipo y el valor es {0}", p);
        }
    }
}
