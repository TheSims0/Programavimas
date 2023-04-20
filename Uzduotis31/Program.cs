using System;
namespace Uzduotis31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program programa = new Program();
            int skaicius1 = 10;
            int skaicius2 = 20;
            int skaicius3 = 30;
            Console.WriteLine(programa.Suma(skaicius1, skaicius2, skaicius3));
            Console.WriteLine(programa.Dalyba(skaicius1, skaicius2));
        }
        private int Suma(int skaicius1, int skaicius2, int skaicius3)
        {
            return skaicius1 + skaicius2 + skaicius3;
        }
        private double Dalyba(int skaicius1, int skaicius2)
        {
            return Convert.ToDouble(skaicius1) / Convert.ToDouble(skaicius2);
        }
    }
}
