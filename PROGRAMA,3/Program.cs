using System;

namespace PROGRAMA_3
{
    class Program
    {
       public static void Main(string[] args)
        {
            int hora, horasextra;
            double total1, total2, salario;
            Console.WriteLine("Ingrese las horas trabajadas");
            hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba sus horas extra tarabajadas");
            horasextra = int.Parse(Console.ReadLine());
            total1 = (hora - horasextra) * (16);
            total2 = horasextra * 20;
            salario = total1 + total2;
            if (hora <40)
            {
                Console.WriteLine("El salario es: \t" + total1);
            }
            else if (hora > 40)
            {
                Console.WriteLine("El salario total es:  \t" + salario);
            }
            Console.ReadKey();
        }
    }
}
