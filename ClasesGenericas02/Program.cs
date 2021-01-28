using System;

namespace ClasesGenericas02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ver l clase COperaciones, no es posible compilar
            //Usamos Dynamic para resolver, el tipo se checa en ejecución y no en compilación

            COperaciones<int> miOperacion = new COperaciones<int>();
            COperaciones<string> miOperacionS = new COperaciones<string>();

            Console.WriteLine(miOperacion.Suma(5,4));
            Console.WriteLine(miOperacionS.Suma("Hola", " a todos"));
        }
    }
}
