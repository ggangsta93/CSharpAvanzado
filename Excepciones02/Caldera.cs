using System;
using System.Collections.Generic;
using System.Text;

namespace Excepcion02
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
            if (funciona == false)
                Console.WriteLine("La caldera {0} está descompuesta.", marca);
            else
            {
                tempActual += pAumento;
                Console.WriteLine("La temperatura actual es de {0}", tempActual);

                //Verificamos si se supera la temperatura maxima
                if (tempActual > TempMax)
                {
                    Console.WriteLine("{0} superó la tempratura, tiene {1}", marca, tempActual);
                    tempActual = TempMax;
                    funciona = false;
                    //throw new Exception("Exception de prueba");

                    //Primera version de la excepcion propia
                    //Creamos una instancia de nuestra clase de excepcion
                    CalderaExcepcion ex = new CalderaExcepcion(string.Format("La caldera {0} se ha sobrecalentado", marca),"Ha trabajado demasiado tiempo",DateTime.Now);
                    
                    //Colocamos un link de ayuda
                    ex.HelpLink = "https//www.nicosio.com";

                    //Lanzamos la excepcion
                    throw ex;
                }
            }
        }

        
    }//Finaliza la clase caldera

    //V1 de la clase excepcion
    //Todas las clases de excepcion propias deben tener acceso publico
    //public class CalderaExcepcion : ApplicationException
    //{
    //    private string mensaje = "";
    //    private DateTime momento;
    //    private string causa;
    //    public DateTime Momento { get => momento; set => momento = value; }
    //    public string Causa { get => causa; set => causa = value; }

    //    public CalderaExcepcion(string pMensaje, string pCausa, DateTime pMomento)
    //    {
    //        mensaje = pMensaje;
    //        causa = pCausa;
    //        momento = pMomento;
    //    }

    //    //Hacemos un override a la propiedad Exception.Message
    //    public override string Message
    //    {
    //        get
    //        {
    //            return string.Format("Mensaje de la excepcion => {0}",mensaje);
    //        }
    //    }
    //}

    //V2 de la clase excepcion
    //No es necesario hacer override de Message si pasamos a la clase padre la info
    //en el constructor
    //public class CalderaExcepcion : ApplicationException
    //{
    //    private DateTime momento;
    //    private string causa;
    //    public DateTime Momento { get => momento; set => momento = value; }
    //    public string Causa { get => causa; set => causa = value; }

    //    public CalderaExcepcion(string pMensaje, string pCausa, DateTime pMomento):base(pMensaje)
    //    {
    //        causa = pCausa;
    //        momento = pMomento;
    //    }

    //}

    //V3
    //Excepcion completa de acuerdo con las reglas de .NET
    //Derivar de Exception/ApllicacionException
    //Usar [System.Serializable]
    //Definir constructor de default
    //Definir constructor que coloca Message en la herencia
    //Definir constructor que maneja excepciones internas
    //Definir constructor que maneja la serializacion del 

    [Serializable]
    public class CalderaExcepcion : ApplicationException
    {
        public CalderaExcepcion() { }
        public CalderaExcepcion(string pMensaje) : base(pMensaje) { }
        public CalderaExcepcion(string pMensaje, System.Exception inner) : base(pMensaje, inner) { }

        protected CalderaExcepcion(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        //Aquí propiedades adicionales
        private DateTime momento;
        private string causa;

        public DateTime Momento { get => momento; set => momento = value; }
        public string Causa { get => causa; set => causa = value; }

        public CalderaExcepcion(string pMensaje, string pCausa, DateTime pMomento) : base(pMensaje)
        {
            causa = pCausa;
            momento = pMomento;
        }

    }
}
