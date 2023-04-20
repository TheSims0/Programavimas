using System;
namespace Uzduotis29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite savo varda: ");
            string vardas = Console.ReadLine();
            Console.Write("Iveskite savo amziu: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite savo megstamiausia hobi: ");
            string hobis = Console.ReadLine();
            Asmenybe(vardas, amzius,hobis);
        }
        private static void Asmenybe(string vardas, int amzius, string hobis)
        {
            Console.WriteLine($"Labas, {vardas} ({amzius}).");
            Console.WriteLine($"Tavo hobis: {hobis}");
        }
    }
}
