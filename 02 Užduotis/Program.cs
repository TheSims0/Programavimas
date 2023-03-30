using System;
namespace _02_Užduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pats sugalvojau taip
            Console.WriteLine("----------------------------------- \n" +
                              "|                                 |\n" +
                              "|           Mano vardas           |\n" +
                              "|             Simonas             |\n" +
                              "|                                 |\n" +
                              "-----------------------------------");
            //O čia su ChatGPT pagalba pavyko rezultata pagerint taip kad lentelės kraštai neišsilygiuotu ir tekstas visada būtu centruotas
            string name1 = "Mano vardas";
            string name2 = "Simonas";
            int totalWidth = 50;
            int nameWidth = name1.Length;
            Console.WriteLine(new string('-', totalWidth));
            Console.WriteLine($"|{new string(' ', totalWidth - 2)}|");
            Console.WriteLine($"|{new string(' ', (totalWidth - nameWidth - 2) / 2)}{name1}{new string(' ', (totalWidth - nameWidth - 1) / 2)}|");
            Console.WriteLine($"|{new string(' ', (totalWidth - name2.Length - 2) / 2)}{name2}{new string(' ', (totalWidth - name2.Length - 1) / 2)}|");
            Console.WriteLine($"|{new string(' ', totalWidth - 2)}|");
            Console.WriteLine(new string('-', totalWidth));
        }
    }
}
