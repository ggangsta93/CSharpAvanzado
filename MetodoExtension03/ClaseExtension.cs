using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoExtension03
{
    //La clase donde se guarda las extensiones debe ser estatica
    static class ClaseExtension
    {
        //El metodo que extiende debe ser estatico
        //El primer paramtro lleva this y representa al tipo que estamos
        //extendiendo

        public static bool EsPar(this int i)
        {
            if (i % 2 == 0)
                return true;
            else
                return false;
        }

        //Este extiende a un doble
        public static double Dobletea(this double d)
        {
            return d * 2.0;
        }

        //Este extiende solo a las clases que implementen ISaludador
        public static void Sonido(this ISaludador s)
        {
            Console.Beep();
        }

        //Este aumenta metodo a la clase comun y corriente
        public static void Despedida(this MiInt s)
        {
            Console.WriteLine("Hasta luego joven.");
        }

    }
}
