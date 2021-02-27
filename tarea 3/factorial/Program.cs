using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
           do
            {
                Console.Write("ingrese un numero ");
                a = int.Parse(Console.ReadLine());
                verificar(a);
            } while (a < 0);
            factorial(a);
            Console.ReadKey();
        }
        static void verificar(int n)
        {
            if (n < 0)
            {
                Console.Write("no se puede calcular el factorial de un numero negativo\n");
            }
        }
        static void factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("\nEl Factorial de " + n + " es: " + fact);
            Console.ReadKey();
        }
    }
}
