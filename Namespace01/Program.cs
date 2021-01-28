using System;

//Agregamos estos namespace para poder uso los tipos definidos ahí
using LasClases;
using  OtrasClases;
namespace Namespace01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explica uso de namespace

            //La clase solo se puede instancias si usamos el namespace
            //Si tenemos los dos using el compilados no sabe cual usar
            //Clase1 ob1 = new Clase1();

            //O si usamos el nombre totalmente calificado
            //comentar el namespace
            //esto si estan en el mismo proyecto
            //LasClases.Clase2 ob2 = new LasClases.Clase2();

            //Adicionamos el otro namespace
            //Hay conflicto si en los dos namespaces se tinen clases con el mismo nombre
            LasClases.Clase1 obj1 = new LasClases.Clase1();
            OtrasClases.Clase1 obj2 = new OtrasClases.Clase1();
        }
    }
}
