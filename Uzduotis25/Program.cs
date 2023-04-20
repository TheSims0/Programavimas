using System;
using System.Linq;
namespace Uzduotis25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepti vartotojui įvesti 5 pažymius VIENOJE eilutėje atskiriant tarpu. Rasti didžiausią pažymį.
            Console.Write("Iveskite 5 pazymius VIENOJE eiluteje atskiriant tarpu: ");
            string ivestis1 = Console.ReadLine();
            string[] reiksme1 = ivestis1.Split(' ');
            int[] pazymiai1 = new int[reiksme1.Length];
            for (int i = 0; i < reiksme1.Length; i++)
            {
                pazymiai1[i] = Convert.ToInt32(reiksme1[i]);
            }
            Console.WriteLine(pazymiai1.Max());
            Console.WriteLine();
            //Liepti vartotojui įvesti 5 pažymius VIENOJE eilutėje atskiriant kableliu. Rasti maziausia pažymį.
            Console.Write("Iveskite 5 pazymius VIENOJE eiluteje atskiriant kableliu: ");
            string ivestis2 = Console.ReadLine();
            string[] reiksmes2 = ivestis2.Split(',');
            int[] pazymiai2 = new int[reiksmes2.Length];
            for (int i = 0; i < reiksmes2.Length; i++)
            {
                pazymiai2[i] = Convert.ToInt32(reiksmes2[i]);
            }
            Console.WriteLine(pazymiai2.Min());
            Console.WriteLine();
        }
    }
}
