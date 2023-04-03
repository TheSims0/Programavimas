using System;
namespace Uzduotis06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daugiklis = 0;
            Console.Write("Įveskite norima skaičių: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine();
            int dvizenklis = 25;
            int liekana = dvizenklis % 10;
            int sveikas = (dvizenklis - liekana) / 10;
            Console.WriteLine($"{liekana} * {sveikas} = {liekana * sveikas}");
        }
    }
}
