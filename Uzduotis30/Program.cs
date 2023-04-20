using System;
namespace Uzduotis30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite du skaicius. Pirmas skaicius: ");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Antras skaicius: ");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            Suma(skaicius1, skaicius2);
            Skirtumas(skaicius1, skaicius2);
            Sandauga(skaicius1, skaicius2);
            Dalyba(skaicius1, skaicius2);
        }
        private static void Suma(int skaicius1, int skaicius2)
        {
            Console.WriteLine($"Suma = {skaicius1 + skaicius2}");
        }
        private static void Skirtumas(int skaicius1, int skaicius2)
        {
            Console.WriteLine($"Skirtumas = {skaicius1 - skaicius2}");
        }
        private static void Sandauga(int skaicius1, int skaicius2)
        {
            Console.WriteLine($"Sandauga = {skaicius1 * skaicius2}");
        }
        private static void Dalyba(int skaicius1, int skaicius2)
        {
            Console.WriteLine($"Dalyba = {skaicius1 / skaicius2}");
        }
    }
}
