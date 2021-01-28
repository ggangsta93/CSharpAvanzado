using System;

namespace ClasesGenericas01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para PuntoI, T trabaja como int
            CPunto<int> puntoI = new CPunto<int>(3,4);

            //Para  puntoD, T trabaja como double
            CPunto<double> puntoD = new CPunto<double>(2.56, 1.87);

            //Para  puntoF, T trabaja como double
            CPunto<float> puntoF = new CPunto<float>(8.98f, 7.69f);

            Console.WriteLine(puntoI);
            Console.WriteLine(puntoD);
            Console.WriteLine(puntoF);

            //Colocamos el valor de dafault
            Console.WriteLine("--------Colocamos el valor por default--------");
            puntoI.Reset();
            Console.WriteLine(puntoI);

            //Verificamos si está trabajando como entero
            puntoI.EncuentraTipo();
            puntoD.EncuentraTipo();





        }
    }
}
