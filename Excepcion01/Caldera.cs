using System;
using System.Collections.Generic;
using System.Text;

namespace Excepcion01
{
    class Caldera
    {
        private int tempMax = 120;
        private int tempActual = 0;
        private string marca = "";
        private bool funciona = true;

        public Caldera(string pMarca, int pTemp)
        {
            tempActual = pTemp;
            marca = pMarca;
        }

        public int TempMax { get => tempMax; set => tempMax = value; }
        public int TempActual { get => tempActual; set => tempActual = value; }
        public bool Funciona { get => funciona; set => funciona = value; }

        //Hacemos trabajar la caldera, sin usar excepciones
        //V1
        public void Trabajar(int pAumento)
        {
            if (funciona == false)
                Console.WriteLine("La caldera {0} está descompuesta.",marca);
            else
            {
                tempActual += pAumento;
                Console.WriteLine("La temperatura actual es de {0}",tempActual);

                if (tempActual > TempMax)
                {
                    Console.WriteLine("{0} superó la tempratura, tiene {1}",marca, tempActual);
                    tempActual = TempMax;
                    funciona = false;
                }
            }
        }

        //V2
        //Levantaremos una excepcion cuando sucede el problema
        public void Trabajar2(int pAumento)
        {
            if (funciona == false)
                Console.WriteLine("La caldera {0} está descompuesta.", marca);
            else
            {
                tempActual += pAumento;
                Console.WriteLine("La temperatura actual es de {0}", tempActual);

                if (tempActual > TempMax)
                {
                    Console.WriteLine("{0} superó la tempratura, tiene {1}", marca, tempActual);
                    tempActual = TempMax;
                    funciona = false;

                    //Lanzamos la excepcion
                    throw new Exception(string.Format("La caldera {0} se sobrecalienta", marca));
                }
            }
        }

        //V3
        public void Trabajar3(int pAumento)
        {
            if (funciona == false)
                Console.WriteLine("La caldera {0} está descompuesta.", marca);
            else
            {
                tempActual += pAumento;
                Console.WriteLine("La temperatura actual es de {0}", tempActual);

                if (tempActual > TempMax)
                {
                    Console.WriteLine("{0} superó la tempratura, tiene {1}", marca, tempActual);
                    tempActual = TempMax;
                    funciona = false;

                    //Lanzamos la excepcion
                    //y tenemos una variable para la instancia
                    Exception ex =new Exception(string.Format("La caldera {0} se sobrecalienta", marca));
                    ex.HelpLink = "https//www.nicosio.com";

                    //Adicionamos datos propios a la excepcion
                    ex.Data.Add("Momento: ",string.Format("Ocurrió en {0}",DateTime.Now));
                    ex.Data.Add("Temperatura actual: ", string.Format("{0} grados", tempActual));
                    ex.Data.Add("Incremento dado: ", string.Format("{0} grados",pAumento));
                    throw ex;
                }
            }
        }
    }
}
