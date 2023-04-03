using System;
namespace Uzduotis09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite savo amziu: ");
            int amzius = Convert.ToInt16(Console.ReadLine());
            if (amzius >= 18)
            {
                Console.WriteLine("Jus galite balsuoti!");
            }
            Console.WriteLine("Iveskite pirma skaiciu");
            double pirmas = Convert.ToDouble(Console.ReadLine());
            if (pirmas < 0)
            {
                Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            }
            else if (pirmas > 0)
            {
                Console.WriteLine("Puikiai atlikta uzduotis");
            }
            if (pirmas % 2 == 0)
            {
                Console.WriteLine("Puiku, skaicius lyginis!");
            }
            if (pirmas % 4 == 0)
            {
                Console.WriteLine("Puiku, skaicius dalinais is 4!");
            }
            if (pirmas > 10)
            {
                Console.WriteLine("Puiku, skaicius didesnis uz 10!");
            }
            Console.Write("Iveskite pirma pazymi: ");
            int matematika = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite antra pazymi: ");
            double lietuviu = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Vidurkis: {(matematika + lietuviu) / 2} ");
            if ((matematika + lietuviu) / 2 >= 5)
            {
                Console.WriteLine("VALIO!");
            }
            else
                    {
                Console.WriteLine(":(");
            }
        }
    }
}
