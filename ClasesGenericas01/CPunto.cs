using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ClasesGenericas01
{
    //T representa al tipo con el que se trabaja en un momento dado
    class CPunto<T>
    {
        //Creamos variables de tipo T
        private T x;
        private T y;

        //Podemos recibir parametros de tipo T
        public CPunto(T x, T y)
        {
            this.x = x;
            this.y = y;
        }


        public override string ToString()
        {
            return string.Format("X={0}, Y={1}",x ,y);
        }

        public void Reset()
        {
            //Colocamos el valor de default para el tipo T
            //Numerico 0
            //Referencias null
            x = default(T);
            y = default(T);//El valor por defecto de un Int es 0
        }

        public void EncuentraTipo()
        {
            if (typeof(T) == typeof(int))
                Console.WriteLine("Trabajo como entero");
            else
                Console.WriteLine("Soy de otro tipo");
        }
    }
}
