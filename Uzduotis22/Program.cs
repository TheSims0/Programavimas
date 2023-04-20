using System;
using System.Linq;
namespace Uzduotis22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Susikurkite savaitės temperatūrų rodmenų masyvą.Raskite:
            //žemiausią temperatūrą;
            //didžiausią temperatūrą;
            //vidurkį;
            //Temperatūrų, esančių žemiau už vidurkį, kiekį;
            //Temperatūrų, esančių aukščiau už vidurkį, kiekį.
            int[] temperatura = { 18, 16, 16, 15, 12, 13, 14 };
            int maziausia = temperatura.Min();
            //for (int i = 0; i < temperatura.Length; i++)
            //{
            //    if (temperatura[i] < maziausia)
            //    {
            //        maziausia = temperatura[i];
            //    }
            //}
            Console.WriteLine($"Maziausia savaites temp.: {maziausia}");
            Console.WriteLine();
            int didziausia = temperatura.Max();
            //for (int i = 0; i < temperatura.Length; i++)
            //{
            //    if (temperatura[i] > didziausia)
            //    {
            //        didziausia = temperatura[i];
            //    }
            //}
            Console.WriteLine($"Didziausia savaites temp.: {didziausia}");
            Console.WriteLine();
            int vidurkis = temperatura.Sum() / temperatura.Length;
            Console.WriteLine($"Temperatūros vidurkis: {vidurkis}");
            Console.WriteLine();
            int maziau = 0;
            for (int i = 0; i < temperatura.Length; i++)
            {
                if (temperatura[i] < vidurkis)
                {
                    maziau++;
                }
            }
            Console.WriteLine($"Temperaturu, esanciu zemiau uz vidurki, kiekis: {maziau}");
            Console.WriteLine();
            int daugiau = 0;
            for (int i = 0; i < temperatura.Length; i++)
            {
                if (temperatura[i] > vidurkis)
                {
                    daugiau++;
                }
            }
            Console.WriteLine($"Temperaturu, esanciu daugiau uz vidurki, kiekis: {daugiau}");
            Console.WriteLine();
            int vienodai = 0;
            for (int i = 0; i < temperatura.Length; i++)
            {
                if (temperatura[i] == vidurkis)
                {
                    vienodai++;
                }
            }
            Console.WriteLine($"Temperaturu, vienodu vidurkiui, kiekis: {vienodai}");
            Console.WriteLine();
            //Susikurkite studentų pažymių masyvą. Raskite:
            //geriausią pažymį;
            //kiek mokinių yra gavę dešimtukus;
            //kiek mokinių yra gavę neigiamą pažymį(žemiau nei 4);
            //pažymių vidurkį.
            int[] pazymiai = { 8, 7, 9, 10, 5, 2, 10 };
            int geriausias = pazymiai.Max();
            //for (int i = 0; i < pazymiai.Length; i++)
            //{
            //    if (pazymiai[i] > geriausias)
            //    {
            //        geriausias = pazymiai[i];
            //    }
            //}
            Console.WriteLine($"Geriausias pazymys: {geriausias}");
            Console.WriteLine();
            int puikuoliai = 0;
            for (int i = 0; i < pazymiai.Length; i++)
            {
                if (pazymiai[i] == 10)
                {
                    puikuoliai++;
                }
            }
            Console.WriteLine($"Puikiai besimokantys mokiniai (10): {puikuoliai}");
            Console.WriteLine();
            int kvailiai = 0;
            for (int i = 0; i < pazymiai.Length; i++)
            {
                if (pazymiai[i] < 4)
                {
                    kvailiai++;
                }
            }
            Console.WriteLine($"Kvailiai (<4): {kvailiai}");
            Console.WriteLine();
            int vidurkispaz = pazymiai.Sum() / pazymiai.Length;
            Console.WriteLine($"Pazymiu vidurkis: {vidurkispaz}");
        }
    }
}
