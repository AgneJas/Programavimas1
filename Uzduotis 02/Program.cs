using System;

namespace Uzduotis_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vertikalus = "-------------------";
            string emptyLine = "|                  |";
            string name = "Agne";
            Console.WriteLine(vertikalus);
            Console.WriteLine(emptyLine);
            Console.WriteLine(emptyLine);
            Console.WriteLine("|   Mano vardas    |");
            Console.WriteLine("|      " + name + "        |");
            Console.WriteLine(emptyLine);
            Console.WriteLine(emptyLine);
            Console.WriteLine(vertikalus);
            Console.WriteLine();
        }
    }
}
