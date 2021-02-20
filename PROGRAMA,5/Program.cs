using System;

namespace PROGRAMA_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;
            Console.WriteLine("Ingrese un dia de la semana");
            dia = Console.ReadLine();
            switch (dia)
            {
                case "LUNES":
                    Console.WriteLine("DIA LABORAL");
                    break;
                case "MARTES":
                    Console.WriteLine("DIA LABORAL");
                    break;
                case "MIERCOLES":
                    Console.WriteLine("DIA LABORAL");
                    break;
                case "JUEVES":
                    Console.WriteLine("DIA LABORAL");
                    break;
                case "VIERNES":
                    Console.WriteLine("DIA LABORAL");
                    break;
                case "SABADO":
                    Console.WriteLine("NO ES DIA LABORAL");
                    break;
                case "DOMINGO":
                    Console.WriteLine("NO ES DIA LABORAL");
                    break;




            }
        }

    }
}
