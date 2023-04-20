using System;
namespace Uzduotis13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            //Liepkite vartotojui įvesti tris skaičius.Su switch patikrinkite pirmąjį skaičių:
            //ar jis lygus 1: išveskite visų trijų skaičių sumą;
            //ar jis lygus 2: išveskite pirmo ir trečio skaičių skirtumą;
            //ar jis lygus 3: išveskite antro ir trečio skaičių sandaugą.
            Console.WriteLine("Iveskite 3 skaicius:");
            Console.Write("Pirmas skaicius:");
            int pirmas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Antras skaicius:");
            int antras = Convert.ToInt32(Console.ReadLine());
            Console.Write("Trecias skaicius:");
            int trecias = Convert.ToInt32(Console.ReadLine());
            switch (pirmas)
            {
                case 1:
                    Console.WriteLine(pirmas + antras + trecias);
                    break;
                case 2:
                    Console.WriteLine(pirmas - trecias);
                    break;
                case 3:
                    Console.WriteLine(antras * trecias);
                    break;
                default:
                    Console.WriteLine("Bandykite dar kartą.");
                    break;
            }
            //Liepkite vartotojui įvesti gyvūno rūšį.Su switch patikrinkite:
            //ar įvestas gyvūnas yra šuo;
            //ar įvestas gyvūnas yra katė;
            //ar įvestas gyvūnas yra žiurkėnas
            Console.WriteLine("Įveskite gyvūno rūšį:");
            string gyvunas = Console.ReadLine();
            switch (gyvunas)
            {
                case "šuo":
                    Console.WriteLine("Įvestas gyvūnas yra šuo");
                    break;
                case "katė":
                    Console.WriteLine("Įvestas gyvūnas yra katė");
                    break;
                case "žiurkėnas":
                    Console.WriteLine("Įvestas gyvūnas yra žiurkėnas");
                    break;
                default: 
                    Console.WriteLine("Tokio gyvūno sistemoje nėra.");
                    break;
            }
        }
    }
}
