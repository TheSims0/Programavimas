using System;
namespace Uzduotis20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Įveskite iš konsolės 2 skaičius(stataus trikampio statinių ilgius).
            //Suraskite įžambinę ir ją išveskite į ekraną.
            Console.WriteLine("Iveskite trikampio statiniu ilgius.");
            Console.Write("Pirma statine:");
            int statine1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Antra statine:");
            int statine2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Trikampio izambine yra:{Math.Sqrt(Math.Pow(statine1,2)+Math.Pow(statine2,2))}");
        }
    }
}
