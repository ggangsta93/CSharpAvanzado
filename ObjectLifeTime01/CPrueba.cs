using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectLifeTime01
{
    class CPrueba
    {
        private int a;

        public CPrueba(int pA)
        {
            a = pA;
        }

        public override string ToString()
        {
            return string.Format("El valor es {0}",a);
        }

        //TIPOS FINALIZABLES
        //Object tiene un metodo virtual Finalize()
        //Cuando se hace el override de Finalize tenemos un lugar donde llevar a cabo
        //la limepiza para la clase
        //No se puede invocar directamente, porque es un metodo protegido
        //Lo invoca el recolector de basura antes de eliminar el objeto de la memoria
        //No se puede hacer override de tipo estructura
        //Practicamente nunca haremos esto salvo que tengamos recursos no administrados
        //Que necesiten ser eliminados manualmente: PInvoke, COM, memoria no administrada

        //No hacemos uso de override
        //Se utiliza el detructor para esto
        ~CPrueba()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Aqui liberamos recursos no administrados");
            Console.Beep(600,50);
        }
    }
}
