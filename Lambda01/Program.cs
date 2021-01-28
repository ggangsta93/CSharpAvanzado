using System;
using System.Collections.Generic;

namespace Lambda01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo con delegados
            //System.Predicate<T> es un delegado generico que representa un metodo que
            //va a decir un criterio y dice si el objeto cumple o no con ese criterio
            //public List<T> FindAll<Predicate<T> match> Recorre los elementos de la lista y
            //los pasa como parametro al delegado,si este regresa true los pone en la lista de retorno

            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 5, 4, 8, 11 ,12, 3, 7, 20 });

            //Indicamos el delegado
            Predicate<int> delegado = new Predicate<int>(Pares);//Aquí se le cambia el otro método
            
            //Invocamos metodo
            List<int> numPares = numeros.FindAll(delegado);//Deja los que son true

            //Mostramos
            foreach (int n in numPares)
                Console.WriteLine(n);

            Console.WriteLine("-------------");
            numeros.RemoveAll(delegado);//Remueve los que son true

            foreach(int n in numeros)
                Console.WriteLine(n);
        }

        //Este es el delagado
        static bool Pares(int n)
        {
            if (n % 2 == 0)
                return true;
            return false;
        }

        static bool Rango(int n)
        {
            if (n >= 3 && n <= 7)
                return true;
            else
                return false;
        }
    }
}
