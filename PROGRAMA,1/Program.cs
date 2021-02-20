using System;

namespace PROGRAMA_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string y;
            Console.WriteLine("Porfavor escriba una letra .");
            y = Console.ReadLine();
            if (y == "A" || y == "B" || y==  "C" || y == "D" || y == "E" ||
                y == "F" || y == "G" || y == "H" || y == "I" || y == "J" ||
                y == "K" || y == "L" || y == "M" || y == "N" || y == "Ñ" ||
                y == "O" || y == "P" || y == "Q" || y == "R" || y == "S" ||
                y == "T" || y == "U" || y == "V" || y == "W" || y == "X" ||
                y == "Y" || y == "Z")
            { 
                Console.WriteLine("La letra seleccionada es mayuscula");
            }
            else
            {
                Console.WriteLine("La letra seleccionada es minuscula");

            }
        }
    }
}
