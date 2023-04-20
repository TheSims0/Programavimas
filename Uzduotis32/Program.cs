using System;
namespace Uzduotis32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            Console.Write("Iveskite savo varda: ");
            string vardas = Console.ReadLine();
            Console.WriteLine(prog.Pasisveikinimas(vardas));
        }
        private string Pasisveikinimas(string vardas)
        {
            return $"Sveiki, {vardas}!";
        }
    }
}
