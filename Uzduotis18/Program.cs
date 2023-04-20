using System;
namespace Uzduotis18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Tikslas:
            //    Suskaičiuoti, kiek duonos kepalų kepykla sugebės iškepti per dieną.
            //    Patikrinti, ar kepykla spės iškepti visus tos dienos užsakymus, jei ne, suskaičiuoti, kiek kepalų nespės iškepti.
            //    Suskaičiuoti, kiek kepykla uždirbs pelno iš visų tą dieną iškeptų duonos kepalų.
            //Iš anksto žinoma informacija:
            //    Darbo valandų per dieną -8 val.
            //Vartotojo įvedama informacija:
            //    Kiek darbuotojas gali iškepti kepalų per valandą.
            //    Kiek darbuotojų turi kepykla.
            //    Vieno kepalo savikaina.
            //    Vieno kepalo pardavimo kaina.
            //    Kiek kepykla turi tą dieną iškepti kepalų(užsakymai).
            Console.WriteLine("Kepykla dirba 8h per dieną.");
            Console.Write("Įveskite kiek kepalų vienas darbuotojas gali iškepti per valandą: ");
            int valandinis = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite kiek darbuotojų turi kepykla: ");
            int darbuotojai = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite vieno kepalo savikainą: ");
            int savikaina = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite vieno kepalo pardavimo kainą; ");
            int pardavimas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Įveskite kiek kepykla turi iškepti kepalų šiandien: ");
            int uzsakymai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            double dieninis = valandinis * darbuotojai * 8;
            Console.WriteLine($"Per dieną kepykla gali iškepti [{dieninis}] kepalų.");
            if ( dieninis < uzsakymai )
            {
                Console.WriteLine($"Kepykla nespės iškepti visų užsakymų, trūksta [{uzsakymai - dieninis}] kepalų");
                Console.WriteLine($"Potencialus pelnas [{(dieninis * pardavimas) - (dieninis * savikaina)}]Eur");
            }
            Console.WriteLine($"Pelnas pilnai įvykdžius užsakymą [{(uzsakymai * pardavimas) - (uzsakymai * savikaina)}]Eur");
        }
    }
}
