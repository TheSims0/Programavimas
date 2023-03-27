using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIsvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");


            //Kintamuju isvedimas
            int amzius = 24;
            float ugis = 1.98f;
            Console.WriteLine($"{amzius}");
            Console.WriteLine("Mano amzius: {0}, o ugis: {1}",amzius, ugis);
            Console.WriteLine($"Mano amzius: {amzius}, o ugis: {ugis}");

            Console.Write("Labas");
            Console.WriteLine("Labas");
            Console.Write("Labas");
        }
    }
}
