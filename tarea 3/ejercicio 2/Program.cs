  using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double angulo = 0;
            double pi = 3.1416;
            double radianes = 0;
            double grados = 0;
            int seleccion;
            Console.WriteLine("****QUE ES LO QUE QUIERE CONVERTIR****");
            Console.WriteLine("1. grados a radianes: \n2. radianes a grados\n");  
            seleccion = int.Parse(Console.ReadLine());
            
            switch (seleccion)
            {
                case 1: Console.WriteLine("ingrese los grados que quiere convertir a radianes");angulo = Convert.ToDouble(Console.ReadLine());
                    radianes = angulo * (pi / 180);
                    Console.WriteLine("{0}grados es {1} radianes", angulo, radianes);
                    break;
                case 2: Console.WriteLine("ingrese los radianes que quiere convertir a grados"); angulo = Convert.ToDouble(Console.ReadLine());
                    grados = angulo * (180 / pi);
                    Console.WriteLine("{0} radianes es {1}grados", angulo, grados);
                    break;
                default:Console.WriteLine("error");
                        break; }
            Console.ReadKey();
            
           
                
           
            }
        }
    }

