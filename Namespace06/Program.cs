using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Usamos este namespace
using System.Configuration;

namespace Namespace06
{
    class Program
    {
        /*MOTIVACIÓN:
         * El namespace System.Configuration;
         * Contiene tipos que nos permite leer los archivos *.config, cuyos archivos
         * que hemos estados usando para configurar los assemblies.
         * Podemos colocar informacion propia adentro de los archivos de configuracion y 
         * posteriormente dentro de nuestra propia aplicacion leer la información y 
         * hacer algo útil con ella.
        */
        static void Main(string[] args)
        {
            //Editamos App.config y lo leemos desde la aplicacion

            //Creamos el objeto lector
            AppSettingsReader lector = new AppSettingsReader();

            //Leemos los datos con el type cast correcto
            string nombre = (string)lector.GetValue("Nombre",typeof(string));
            int edad = (int)lector.GetValue("edad", typeof(int));

            Console.WriteLine("{0} tiene {1} de edad",nombre,edad);
        }
    }
}
