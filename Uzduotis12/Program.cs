using System;
namespace Uzduotis12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite įvesti tris skirtingus skaičius.Suraskite, kuris iš šių skaičių yra didžiausias.
            Console.WriteLine("Iveskite 3 skaicius:");
            Console.Write("Pirmas skaicius:");
            int pirmas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Antras skaicius:");
            int antras = Convert.ToInt32(Console.ReadLine());
            Console.Write("Trecias skaicius:");
            int trecias = Convert.ToInt32(Console.ReadLine());
            int auksciausias = pirmas;
            if (antras > auksciausias)
            {
                auksciausias = antras;
            }
            if (trecias > auksciausias)
            {
                auksciausias = trecias;
            }
            Console.WriteLine($"Auksciausias skaicius:{auksciausias}");
            Console.WriteLine();
            //Liepkite įvesti egzamino rezultatą. Atlikite šiuos patikrinimus:
            //ar gautas rezultatas yra[8 - 10];
            //ar gautas rezultatas yra[5 - 8);
            //ar gautas rezultatas yra < 5.
            Console.WriteLine("Iveskite egzamino rezultata 0 - 10.");
            int rezultatas = Convert.ToInt32(Console.ReadLine());
            if (rezultatas >= 8 && rezultatas <= 10)
            {
                Console.WriteLine("Gautas rezultatas yra [8 - 10]");
            }
            else if (rezultatas >= 5 && rezultatas <= 7)
            {
                Console.WriteLine("Gautas rezultatas yra [5 - 7]");
            }
            else if (rezultatas < 5)
            {
                Console.WriteLine("Gautas rezultatas yra <5");
            }
            else
            {
                Console.WriteLine("Ivestas netinkamas skaicius.");
            }
            Console.WriteLine();
            //Liepkite įvesti du skaičius. Patikrinkite(naudojant 4 atskirus if’us):
            //ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;
            //ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;
            //ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;
            //ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.
            Console.WriteLine("Iveskite du skaicius");
            Console.Write("Pirmas skaicius:");
            int pirmasis = Convert.ToInt32(Console.ReadLine());
            Console.Write("Antras skaicius:");
            int antrasis = Convert.ToInt32(Console.ReadLine());
            if (pirmasis > antrasis || pirmasis == 0)
            {
                Console.WriteLine("Pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0");
            }
            if (antrasis > pirmasis || antrasis == 5)
            {
                Console.WriteLine("Antras skaičius yra didesnis už pirmąjį, arba yra lygus 5");
            }
            if (pirmasis > antrasis && pirmasis == 20)
            {
                Console.WriteLine("Pirmas skaičius yra didesnis už antrąjį ir yra lygus 20");
            }
            if (antrasis > pirmasis && antrasis < 100)
            {
                Console.WriteLine("Antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100");
            }
            Console.WriteLine();
        }
    }
}
