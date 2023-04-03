using System;
namespace Uzduotis05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pradinis = 4;
            int pridedamasis = 5;
            int daugiklis = 2;
            Console.WriteLine($"{pradinis} + {pridedamasis} = {pradinis + pridedamasis}"  );
            Console.WriteLine($"{pradinis} - {pridedamasis} = {pradinis - pridedamasis}");
            Console.WriteLine($"{pradinis}, {Math.Pow(pradinis, 2)}, {Math.Pow(pradinis, 3)}.");
            Console.WriteLine($"{pradinis} * {pridedamasis} * {daugiklis} = {pradinis*pridedamasis*daugiklis}");
            Console.WriteLine($"-1 + 4 * 6 = {-1 + 4 * 6}");
            Console.WriteLine($"14 + -4 * 6 / 11 = {14 + -4 * 6 / 11}");
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {2 + 15 / 6 * 1 - 7 % 2}");
        }
    }
}
