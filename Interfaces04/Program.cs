using System;

namespace Interfaces04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jerarquia de interfaces
            CSuma miSuma = new CSuma();

            //Metodo debido a ICalcular
            miSuma.Calculo(5,3);

            //Metodo debido a la jerarquia en ICalcular
            miSuma.MostrarDatos();
        }
    }
}
