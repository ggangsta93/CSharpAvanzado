using System;
using System.Collections.Generic;
using System.Text;

namespace DisposableObjects03
{
    //V1
    //class CPrueba:IDisposable//Se implementa IDisposable por ser una clase desechable
    //{
    //    private int a;

    //    public CPrueba(int pA)
    //    {
    //        a = pA;
    //    }

    //    public override string ToString()
    //    {
    //        return string.Format("El valor es {0}",a);
    //    }
    //    ~CPrueba()//Como es finalizable se necesita poner el destructor
    //    {
    //        Console.WriteLine("Estamos en destructor, aquí liberamos lo no administrado {0}",a);
    //    }

    //    public void Dispose()
    //    {
    //        Console.WriteLine("Estamos en Dispose, aqui liberamos lo no administrado {0}", a);

    //        //Si se uso dispose no debemos de usar el destructor
    //        GC.SuppressFinalize(this);
    //    }
    //}

    //V2
    class CPrueba : IDisposable//Se implementa IDisposable por ser una clase desechable
    {
        private bool usoDispose = false;
        private int a;

        public CPrueba(int pA)
        {
            a = pA;
        }

        public override string ToString()
        {
            return string.Format("El valor es {0}", a);
        }
        ~CPrueba()//Como es finalizable se necesita poner el destructor
        {
            //Invocamos el metodo de limpieza
            limpieza();
        }

        public void Dispose()
        {
            //Invocamos el metodo de limpieza
            //se coloca true por que se hace uso de Dispose
            limpieza();

            //Como usamos dispose indicamos que no se use destructor
            GC.SuppressFinalize(this);
        }

        public void limpieza()
        {
            if (usoDispose == false)
            {
                //Codigo de milpiza comun
                Console.WriteLine("Estamos en limpieza, aquí liberamos no administrado {0}",a);
            }
            usoDispose = true;
        }
    }

    
}
