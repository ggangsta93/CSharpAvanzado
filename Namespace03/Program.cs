using System;





//Usamos el namespace anidado
using Namespace03.LasClases;

//Hacemos un alias con el namespace anidado
using otras = Namespace03.OtrasClases;

namespace Namespace03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Namespaces anidados
            Clase1 miObjeto = new Clase1();
            otras.Clase1 otroObjeto = new otras.Clase1();
        }
    }
}
