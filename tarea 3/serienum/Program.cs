using System;

namespace serienum
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a, b, c;
            long d;
            double r = 0;
            string linea;
            Console.Write("ingrese un numero "); linea = Console.ReadLine();
            a = byte.Parse(linea);
            for (b = 1; b <= a; b++)
            {
                d = 1;
                for (c = 1; c <= b; c++)
                {
                    d = d * c;
                }
                r = r + (b / d);
            }
            Console.WriteLine("la serie es: " + r);
            Console.ReadKey();
        }
    }
}
