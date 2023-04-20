using System;
using System.Linq;
namespace Uzduotis21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pazymiai = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] automobiliai = new string[4];
            automobiliai[0] = "Audi";
            automobiliai[1] = "BMW";
            automobiliai[2] = "Subaru";
            automobiliai[3] = "Toyota";
            Console.WriteLine(pazymiai.Length);
            Console.WriteLine(automobiliai.Length);
            Console.WriteLine();
            Console.WriteLine(pazymiai.First());
            Console.WriteLine(automobiliai.First());
            Console.WriteLine();
            Console.WriteLine(pazymiai.Last());
            Console.WriteLine(automobiliai.Last());
            Console.WriteLine();
            Console.WriteLine(pazymiai[pazymiai.Length - 1]);
            Console.WriteLine(automobiliai[automobiliai.Length - 1]);
        }
    }
}
