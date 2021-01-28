using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces04
{
    //Creamos la jerarquia de interfaces
    //Ahora ICalcular aparte de calculo tiene los metodos de IMostrar
    interface ICalcular:IMostrar
    {
        int Calculo(int a, int b);
    }
}
