using System;
namespace Uzduotis16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Raskite visų skaičių nuo 1 iki 100 sumą.
            int suma = 0;
            for (int i = 1; i < 101; i++)
            {
                suma += i;
            }
            Console.WriteLine($"Bendra visų skaičių nuo 1 iki 100 suma = {suma}");
            Console.WriteLine();
            //Raskite visų lyginių skaičių nuo 20 iki 40 sumą.
            int suma2 = 0;
            for (int i = 20; i < 41; i++)
            {
                if (i % 2 == 0) 
                suma2 += i;
            }
            Console.WriteLine($"Visu lyginiu skaiciu nuo 20 iki 40 suma: {suma2}");
            Console.WriteLine();
            //Raskite visų nelyginių skaičių nuo 30 iki 60 sumą.
            int suma3 = 0;
            for (int i = 30; i < 61; i++)
            {
                if (i % 2 != 0) 
                suma3 += i;
            }
            Console.WriteLine($"Visu nelyginiu skaiciu nuo 30 iki 60 suma: {suma3}");
            Console.WriteLine();
            //Rasti visų skaičių, žemesnių už 1000 ir didesnių už 0 bei kurie dalinasi iš 3 arba
            //5, sumą, turite gauti 233168 atsakymą.
            int suma4 = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) 
                suma4 += i;
            }
            Console.WriteLine("Skaičių, žemesnių už 1000 ir didesnių už 0, kurie dalinasi iš 3 arba 5 suma");
            Console.WriteLine($"Teisingas ats. 233168, gautas ats.: {suma4}");
        }
    }
}
