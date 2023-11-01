using System;

namespace Uzduotis_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Liepkite vartotojui įvesti tris skaičius. Su switch patikrinkite pirmąjį skaičių:
            ar jis lygus 1: išveskite visų trijų skaičių sumą;
            ar jis lygus 2: išveskite pirmo ir trečio skaičių skirtumą;
            ar jis lygus 3: išveskite antro ir trečio skaičių sandaugą.*/

            Console.WriteLine("Iveskite pirma skaiciu");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite antra skaiciu");
            int skaicius2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite antra skaiciu");
            int skaicius3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Įvesti skaičiai: '{0}', '{1}' ir '{2}'", skaicius1, skaicius2, skaicius3);
            switch (skaicius1)
            {
                case 1:
                    Console.WriteLine("Pirmas skaičius yra lygus 1");
                    Console.WriteLine("Visų skaičių suma: '{0}'", skaicius1 + skaicius2 + skaicius3);
                    break;
                case 2:
                    Console.WriteLine("Pirmas skaičius yra lygus 2");
                    Console.WriteLine("Pirmo ir trečio skaičių skirtumas: '{0}'", skaicius1 - skaicius2);
                    break;
                case 3:
                    Console.WriteLine("Pirmas skaičius yra lygus 3");
                    Console.WriteLine("Antro ir trečio skaičių sandauga: '{0}'", skaicius2 * skaicius3);
                    break;
            }
            Console.WriteLine();

            /*            Liepkite vartotojui įvesti gyvūno rūšį. Su switch patikrinkite:
            ar įvestas gyvūnas yra šuo;
            ar įvestas gyvūnas yra katė;
            ar įvestas gyvūnas yra žiurkėnas.
            */

            Console.WriteLine("Iveskite gyvunu rusi");
            string rusis = Console.ReadLine();

            switch (rusis)
            {
                case "suo":
                    Console.WriteLine("Gyvūno rūšis yra suo");
                    break;
                case "kate":
                    Console.WriteLine("Gyvūno rūšis yra kate");
                    break;
                case "ziurkenas":
                    Console.WriteLine("Gyvūno rūšis yra ziurekenas");
                    break;
            }
        }
    }
}
