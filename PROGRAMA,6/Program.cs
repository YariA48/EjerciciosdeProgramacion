using System;

namespace PROGRAMA_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0, Num;
            Console.WriteLine("Ingresa un numero");
            Num = Convert.ToInt32(Console.ReadLine());
            for (int b = 1; b < (Num + 1); b++)
            {
                if (Num % b == 0)
                {
                    y++;
                }
            }
            if (y != 2)
            {
                Console.WriteLine("El numero ingresado no es primo");

            }
            else
            {
                Console.WriteLine("El numero ingresado  es primo");
            }
            Console.ReadKey();
        }
    }
}



