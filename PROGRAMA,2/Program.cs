
using System;

namespace PROGRAMA_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            double cantidad;
            double total;
            const double descuento = 0.20;


            Console.WriteLine("Indique en numeros cuanto ha gastado en la compra \t");
            cantidad = Convert.ToDouble(Console.ReadLine());
            if (cantidad >= 300)
            {
                total = (cantidad * descuento);
                Console.WriteLine("El total de la compra es:  \t" + (cantidad - total));

            }
            else
                Console.WriteLine("El total a pagar es:  \t" + (cantidad));
            Console.ReadKey();
        }
    }
}



