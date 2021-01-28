using System;

namespace Interfaces03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Forma de implementar dos interface con el mismo nombre de metodo
            CCuadrado cuadro = new CCuadrado(5);

            ((IPerimetro)cuadro).Calcular();
            ((IArea)cuadro).Calcular();

        }
    }
}
