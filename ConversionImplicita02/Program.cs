using System;

namespace ConversionExplicita02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversion custom de tipo
            CComplejo im1 = new CComplejo(2, 3);

            //no se puede
            //CReal real1 = im1;

            //Tampoco se puede hasta que coloquemos el explicit
            CReal real2 = (CReal)im1;
            Console.WriteLine(real2);

            Console.WriteLine("--------Conversion implicita----------");
            //Aqui la conversion implicita
            CReal r3 = new CReal(3.5);
            CComplejo im2 = r3;
            Console.WriteLine(im2);
        }
    }
}
