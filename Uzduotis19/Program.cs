using System;
namespace Uzduotis19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parašyti For ciklą, kuris suskaičiuotų, kiek skaičių intervale[0 – 1000) dalinasi iš 16.
            int sesiolika = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 16 == 0)
                sesiolika++;
            }
            Console.WriteLine($"skaičių intervale[0 – 1000) dalinasi iš 16 = {sesiolika}");
            Console.WriteLine();
            //Liepkite vartotojui įvesti teigiamą skaičių.While ciklo viduje skaičių kelkite vis
            //didesniu laipsniu ir jį išveskite į ekraną, kol skaičius netaps didesnis už 1500.
            Console.Write("Iveskite teigiama skaiciu: ");
            double skaicius = Convert.ToDouble(Console.ReadLine());
            int kelimas = 2;
            while (Math.Pow(skaicius, kelimas) < 1500)
            {
                Console.WriteLine(Math.Pow(skaicius, kelimas));
                kelimas++;
            }
        }
    }
}
