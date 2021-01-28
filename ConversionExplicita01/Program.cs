using System;

namespace ConversionExplicita01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversion custom de tipo
            CComplejo comp1 = new CComplejo(2, 3);

            //no se puede
            //CReal real1 = comp1;

            //Tampoco se puede hasta que coloquemos el explicit
            CReal real2 = (CReal)comp1;
            Console.WriteLine(real2);
        }
    }
}
