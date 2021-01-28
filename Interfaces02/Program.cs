using System;

namespace Interfaces02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arreglo de interfaces
            IElectronico[] teles = { new CTelevisor("Charp"), new CTelevisor("Zony"), new CRadio("RGB") };
            IElectronico aparatoCreado = null;

            for (int n = 0; n < teles.Length; n++)
                Console.WriteLine(teles[n]);

            Console.WriteLine("-------");

            //Uso de interfaces con metodos

            CTelevisor miTV = new CTelevisor("Charp TV");
            CRadio miRadio = new CRadio("RGB Radio");
            Muestra(miTV);
            Muestra(miRadio);
            Console.WriteLine("-------");

            //Metodos que regresa objeto que implementa la interfase
            aparatoCreado = CrearAparato();
            aparatoCreado.Encender(true);
            Console.WriteLine(aparatoCreado);

        }
        //Este metodo puede recibir a cualquier objeto que implemente IELectronico
        static void Muestra(IElectronico aparato)
        {
            if (aparato is CTelevisor)
                Console.WriteLine("El televisor es {0}",aparato);
            if (aparato is CRadio)
                Console.WriteLine("El radio es {0}", aparato);
        }

        //Este metodo puede regresar cualquier objeto que implemente a IElectronico
        static IElectronico CrearAparato()
        {
            IElectronico aparato = null;
            string dato = string.Empty;
            int opcion = 0;

            Console.WriteLine("Que deseas crear? 1-Tele, 2-Radio");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);
            if(opcion == 1)
            {
                Console.WriteLine("Dame la marca de la tele");
                dato = Console.ReadLine();
                aparato = new CTelevisor(dato);
            }
            if(opcion == 2)
            {
                Console.WriteLine("Dame la marca del radio");
                dato = Console.ReadLine();
                aparato = new CRadio(dato);
            }
            return aparato;
        }
    }
}
