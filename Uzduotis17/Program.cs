using System;
namespace Uzduotis17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti teigiamą skaičių.Ciklo pagalba šį skaičių išvesti mažėjimo tvarka 
            //iki kol jis pasieks 0.Pvz.: 5 4 3 2 1.Kiekvieną kartą išvesti skirtingose eilutėse.
            Console.Write("Iveskite teigiama skaiciu: ");
            int teigiamas = Convert.ToInt32(Console.ReadLine());
            while (teigiamas > -1)
            {
                Console.WriteLine(teigiamas);
                teigiamas--;
            }
            Console.WriteLine();
            //Liepkite vartotojui įvesti neigiamą skaičių. Ciklo pagalba šį skaičių išvesti didėjimo tvarka 
            //iki kol jis pasieks 0, taip pat išvesti 0.Pvz.: -4 - 3 - 2 - 1 0.
            //Kiekvieną kartą išvesti toje pačioje eilutėje, skaičius atskiriant tarpais.
            Console.Write("Iveskite neigiama skaiciu: ");
            int neigiamas = Convert.ToInt32(Console.ReadLine());
            while (neigiamas < 1)
            {
                Console.Write(neigiamas + " ");
                neigiamas++;
            }
            Console.WriteLine();
            //Padarykite skaičiuotuvą. Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius.
            //Iš šių skaičių turi būti grąžinami visi sudėties, skirtumo, sandaugos ir dalmens atsakymai,
            //išvedant kartu ir atliekamus veiksmus.Pvz.:
            //5 + 4 = 9
            //5 - 4 = 1
            //Programa vykdoma tol, kol vartotojas nori atlikinėti skaičiavimus.
            string tesimas = "t";
            while (tesimas == "t") 
            {
                Console.WriteLine("Iveskite du skaicius.");
                Console.Write("Pirmas: ");
                double pirmas = Convert.ToDouble(Console.ReadLine());
                Console.Write("Antras: ");
                double antras = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"{pirmas} + {antras} = {pirmas + antras}");
                Console.WriteLine($"{pirmas} - {antras} = {pirmas - antras}");
                Console.WriteLine($"{pirmas} * {antras} = {pirmas * antras}");
                Console.WriteLine($"{pirmas} / {antras} = {pirmas / antras}");
                Console.WriteLine("Ar norite atlikti kita veiksma? (t/n)");
                tesimas = Console.ReadLine();
            }
        }
    }
}
