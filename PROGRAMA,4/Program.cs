using System;

namespace PROGRAMA_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un año");
            int ano = Convert.ToInt32(Console.ReadLine());
            bool Multiplode4 = (ano % 4 == 0);
            bool Multiplode100 = (ano % 100 == 0);
            bool Multiplode400 = (ano % 400 == 0);

            bool bisiesto = Multiplode400 || (Multiplode4 && !Multiplode100);
            if (bisiesto)
            {
                Console.WriteLine("El ano es bisiesto");
            }
            else
            {
                Console.WriteLine("El ano no es bisiesto");
            }
            Console.ReadLine();
        }
    }
}
