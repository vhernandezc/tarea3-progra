using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado, medida, p,eleccion;
            double area, perimetro;
            Console.WriteLine("ingrese los lados de su poligono regular");
            lado = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la medida de los lados de su poligono regular");
            medida = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el apotema de su poligono regular");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("¿QUE DESEA CALCULAR?");
            Console.WriteLine("1. area\n2.perimetro\n");
            eleccion = int.Parse(Console.ReadLine());
            switch (eleccion)
            {
                case 1: area = (lado * medida) * p / 2;
                    Console.WriteLine("el area del poligono es:" + area);break;
                case 2: perimetro = lado * medida;
                    Console.WriteLine("el perimetro del poligono es:" + perimetro);break;
                default: Console.WriteLine("error");break;
            }
            Console.ReadKey();


        }
    }
}
