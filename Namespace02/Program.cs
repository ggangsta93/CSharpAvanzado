using System;





//usamos los dos namespaces
//using LasClases;
//using  OtrasClases;

//Creamos un alias a las clases que nos den conflicto
using principal = LasClases.Clase1;
using secunndaria = OtrasClases.Clase1;

namespace Namespace01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos de un alias para corregir problemas de colision de nombre
            principal bj1 = new principal();
            secunndaria ob2 = new secunndaria();
        }
    }
}
