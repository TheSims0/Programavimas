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
            Console.WriteLine("{0}{0}{0}{0}{0}", amzius);
            Console.WriteLine("{0} {0} {0} {0} {0}", amzius);
        }
    }
}
