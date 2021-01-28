using System;
using System.Collections.Generic;
using System.Text;

//Creamos otro namespace

namespace Namespace03
{

    namespace LasClases
    {
        class Clase1
        {
            public Clase1()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saludo desde la Clase1 LasClases");
            }
        }

        class Clase2
        {
            public Clase2()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saludo desde la Clase2 LasClases");
            }
        }

        class Clase3
        {
            public Clase3()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saludo desde la Clase3 LasClases");
            }
        }
    }

    namespace OtrasClases
    {
        class Clase1
        {
            public Clase1()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Saludo desde la Clase1 OtrasClases");
            }
        }

        class Clase2
        {
            public Clase2()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Saludo desde la Clase2 OtrasClases");
            }
        }

        class Clase3
        {
            public Clase3()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Saludo desde la Clase3 OtrasClases");
            }
        }
    }
}
