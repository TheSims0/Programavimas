using System;
namespace Uzduotis07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo varda.");
            string vardas = Console.ReadLine();
            Console.WriteLine("Iveskite savo amziu.");
            string amzius = Console.ReadLine();
            Console.WriteLine($"Jusu vardas {vardas}, o amzius {amzius}m.");
            Console.WriteLine();
            Console.WriteLine("Iveskite betkoki skaiciu.");
            string kubas = Console.ReadLine();
            Console.WriteLine($"{kubas}{kubas}{kubas}");
            Console.WriteLine($"{kubas}{kubas}{kubas}");
            Console.WriteLine($"{kubas}{kubas}{kubas}");
            Console.WriteLine();
            Console.WriteLine("Iveskite betkoki skaiciu.");
            double kvadratas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Pow(kvadratas, 3));
            Console.WriteLine();
            Console.WriteLine("Iveskite pirma skaiciu");
            double pirmas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            double antras = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu");
            double trecias = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{pirmas} + {antras} + {trecias} = {pirmas + antras + trecias}");
        }
    }
}
