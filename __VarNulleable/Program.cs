using System;

namespace __VarNulleable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion implicita de variables
            //Solo se permiten en variables locales
            //No se pueden usar en atributos
            //No se pueden usar como tipos de retorno
            //Se debe de colocar un valor en el momento de declaracion y no puede ser null
            //No confundir con var o Variant de otros lenguajes, es fuertemente tipificado
            //Se usan en LINQ donde un query puede dar un resultado dinamicamente creado

            var a = 5;
            var b = "Hola a todos";
            var c = 15.689;
            var d = false;

            //var e = null; //No puede ser null
            //d=58;//Aquí vemos que var lleva la parte de ser fuertemente tipificado
            var f = c;//Esto es valido siempre y cuando el valor tenga un valor asignado
            //Imprimimos
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            //Usamos reflecion para conocer el tipo
            Console.WriteLine("a es {0}", a.GetType().Name);
            Console.WriteLine("b es {0}", b.GetType().Name);
            Console.WriteLine("c es {0}", c.GetType().Name);
            Console.WriteLine("d es {0}", d.GetType().Name);
            Console.WriteLine("f es {0}->{1}", f.GetType().Name, f);

            Console.WriteLine("---------");

            //int valor = null

            //Los tipos nulleables pueden representar los mismos valores mas el valor de null
            //Son utiles en base de datos, pues podemos encontrar columnas no definidas
            //Para definirlo usamos ?
            //Pero realmente creamos una instancia de System.Nulleable<T>

            int? dato = 5;
            Console.WriteLine("dato {0}",dato);
            dato = null;
            Console.WriteLine("dato {0}", dato);

            double? precio = null;
            precio = 6.7;
            Console.WriteLine("dato {0}", precio);

            //El string no es nulleable ya que es un tipo por referencia
            //string? nombre="kevin";

            //Podemos saber si tiene o no tiene valor
            //precio = null;

            if (precio.HasValue)
                Console.WriteLine("Tiene valor {0}", precio.Value);
            else
                Console.WriteLine("No tiene valor");

            //El operador ?? nos permite asignar un valor en caso de tenga null
            double? numero = asignador() ?? 5.55;//Si asignador retorna un null el asigna el 5.55
            Console.WriteLine(numero);




        }

        public static double? asignador()
        {
            //return 4.5;
            return null;
        }
    }
}
