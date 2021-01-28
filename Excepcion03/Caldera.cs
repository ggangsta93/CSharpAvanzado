using System;
using System.Collections.Generic;
using System.Text;

namespace Excepcion03
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


        //V1
        public void Trabajar(int pAumento)
        {
            //Aquí colocamos una excepcion para argumento invalido
            if (pAumento < 0)
                throw new ArgumentOutOfRangeException("Aumento", "El aumento no puede ser negativo");

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

                    CalderaExcepcion ex = new CalderaExcepcion(string.Format("La caldera {0} se ha sobrecalentado", marca),"Ha trabajado demasiado tiempo",DateTime.Now);

                    ex.HelpLink = "https//www.nicosio.com";
                    throw ex;
                }
            }
        }

        
    }//Finaliza la clase caldera

    //V1
    public class CalderaExcepcion : ApplicationException
    {
        private string mensaje = "";
        private DateTime momento;
        private string causa;
        public DateTime Momento { get => momento; set => momento = value; }
        public string Causa { get => causa; set => causa = value; }

        public CalderaExcepcion(string pMensaje, string pCausa, DateTime pMomento)
        {
            mensaje = pMensaje;
            causa = pCausa;
            momento = pMomento;
        }

        //Hacemos un override a la propiedad Exception.Message
        public override string Message
        {
            get
            {
                return string.Format("Mensaje de la excepcion => {0}", mensaje);
            }
        }
    }

    
}
