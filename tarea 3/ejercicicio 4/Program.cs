using System;

namespace ejercicicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            Console.WriteLine("ingrese un numero del 1 al 7");
            dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:Console.WriteLine("el día es Lunes"); break;
                case 2: Console.WriteLine("el día es Martes"); break;
                case 3: Console.WriteLine("el día es Miercoles"); break;
                case 4: Console.WriteLine("el día es Jueves"); break;
                case 5: Console.WriteLine("el día es Viernes"); break;
                case 6: Console.WriteLine("el día es Sabado"); break;
                case 7: Console.WriteLine("el día es Domingo"); break;
                default:Console.WriteLine("el numero ingresado no se encuentra entre el rango especificado");break;
            }
            Console.ReadKey();
        }
    }
}
