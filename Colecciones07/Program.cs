using System;
using System.Collections.ObjectModel;//NO OLVIDAR

namespace Colecciones07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coleccion observable
            ObservableCollection<CPunto> puntos = new ObservableCollection<CPunto>()
            {
                new CPunto(4,55),
                new CPunto(17,22)
            };

            //Adicionamos el handler
            puntos.CollectionChanged += puntos_ColecctionChanged;
            puntos.Add(new CPunto(2, 3));

            CPunto miPunto = new CPunto(5,5);
            puntos.Add(miPunto);
            puntos.Remove(miPunto);

        }

        //Este es el handler que se invoca cuando cambia la coleccion
        static void puntos_ColecctionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //Vemos el tipo de evento que ocurrió
            Console.WriteLine("El evento es {0}",e.Action);

            //Si la accion es adicionar
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Elementos nuevos");
                foreach (CPunto p in e.NewItems)
                    Console.WriteLine(p.ToString());
            }
            //Si la accion es remover
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Elementos afectados por el cambio");
                foreach (CPunto p in e.OldItems)
                    Console.WriteLine(p.ToString());
                Console.WriteLine();

            }
        }
    }
}
