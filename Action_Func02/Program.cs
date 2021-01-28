using System;

namespace Action_Func02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Action -----------------------");
            //Action nos permite crear delegados en el momento, para un maximo de 16 parametros
            //pero el tipo de retorno debe ser void
            int n = 5;
            string m = "Hola a todos";

            //Usamos action para registrar el handler con el delegado
            Action<string, int> delAction = new Action<string, int>(RepiteMensaje);
            //invocamos el delegado
            delAction(m,n);

            Console.WriteLine("----------Func -----------------------");
            //Func funciona similiar a Action,per permite tipo de retorno
            int x = 5;
            int y = 9;

            //Definimos el delegado , el último tipo listado es siempre el tipo de retorno
            Func<int, int, int> delFunc = new Func<int, int, int>(Suma);//El último tipo "int" es el tipo de retorno

            //Invocamos e imprimimos el resultado
            Console.WriteLine(delFunc(x,y));
  
        }

        static void RepiteMensaje(string pMensaje, int pVeces)
        {
            int n = 0;
            for (n = 0; n < pVeces; n++)
                Console.WriteLine(pMensaje);
        }

        static int Suma(int a, int b)
        {
            int r = 0;
            r = a + b;
            return r;
        }
    }
}
