﻿using System;

namespace tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("ingrese un numero");
            numero = int.Parse(Console.ReadLine());
            if ((numero % 2)== 0)
            {
                Console.WriteLine("el numero ingresado es par");
            }
            else {
                Console.WriteLine("el numero es impar");
            }
            Console.ReadKey();

        }
    }
}
