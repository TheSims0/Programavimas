using System;
namespace Uzduotis10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius % 2 == 0)
            {
                Console.WriteLine($"Jusu skaicius {skaicius} ir jis pakeltas 5 laipsniu {Math.Pow(skaicius,5)}");
            }
            if (skaicius % 4 != 0)
            {
                Console.WriteLine("Iveskite antra skaiciu");
                int antras = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Skaiciu sandauga {skaicius * antras}, o suma {skaicius + antras}");
            }
        }
    }
}
