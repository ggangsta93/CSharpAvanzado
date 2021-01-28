using System;

namespace DisposableObjects02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Si deseamos que los recursos no administrados sean liberados
            //tan pronoto como sea posible en lugar de que lo haga el recolector de basura
            //podemos implementar la interfaz IDisposable
            //En este caso se toma que cuando el usuario deja de usar el objeto,
            //el usuario invoca Dispose(), se libera lo no administrado, 
            //pero el objecto sigue existiendo

            CPrueba objeto = new CPrueba(5);
            //Console.WriteLine(objeto);
            //objeto.Dispose();

            //Una mejor manera de hacerlo
            //if (objeto is IDisposable)
            //    objeto.Dispose();

            //Una forma de garantizar que Dispose es invocado
            //try
            //{
            //    Console.WriteLine(objeto);
            //}
            //finally
            //{
            //    objeto.Dispose();
            //}

            //Con esta tecnica Dispose es invocado automaticamente
            //Se puede listar varios objetos en el using
            using (CPrueba prueba2=new CPrueba(7))
            {
                Console.WriteLine(prueba2);
            }

        }
    }
}
