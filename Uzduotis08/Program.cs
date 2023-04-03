using System;
namespace Uzduotis08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu");
            double pirmas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            double antras = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu");
            double trecias = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Pirmas {pirmas}, antras {antras}, trecias {trecias}");
            Console.WriteLine($"Skaiciu kvadratai: pirmas {Math.Pow(pirmas,2)}, antras {Math.Pow(antras, 2)}, trecias {Math.Pow(trecias, 2)}");
            Console.WriteLine($"Skaiciu kubai: pirmas {Math.Pow(pirmas, 3)}, antras {Math.Pow(antras, 3)}, trecias {Math.Pow(trecias, 3)}");
            Console.WriteLine($"Skaicia padalinti is 2: pirmas {pirmas/2}, antras {antras/2}, trecias {trecias/2}");
            Console.WriteLine($"Siu skaiciu vidurkis yra: {(pirmas + antras + trecias) / 3}");
        }
    }
}
