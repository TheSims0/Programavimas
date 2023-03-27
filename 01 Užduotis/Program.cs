using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Užduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Labas, aš Simonas");
            int amzius = 24;
            Console.WriteLine($"Įvestas amžius: {amzius}");
            Console.WriteLine();
            Console.WriteLine($"{amzius}{amzius}{amzius}{amzius}{amzius}");
            Console.WriteLine($"{amzius} {amzius} {amzius} {amzius} {amzius}");
            Console.WriteLine();
            Console.WriteLine();

            //Ir ChatGPT variantas
            string repeatedString = "";
            for (int i = 0; i < 5; i++)
            {
                repeatedString += amzius;
            }
            Console.WriteLine(repeatedString);
            Console.WriteLine();
            string concatenatedStrings = "";
            for (int i = 0; i < 5; i++)
            {
                concatenatedStrings += amzius + " ";
            }
            Console.WriteLine(concatenatedStrings);


        }
    }
}
