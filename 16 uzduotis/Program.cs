using System;

namespace _16_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Raskite visų skaičių nuo 1 iki 100 sumą.*/

            int suma = 0;
            for (int i = 0; i <= 100; i++)
            {
                suma += i;
            }
            /* Raskite visų lyginių skaičių nuo 20 iki 40 sumą.*/

            suma = 0;
            Console.WriteLine($"Lyginių skaičių tarp 20 ir 40 suma: '{suma}'");
            Console.WriteLine();

            /*Raskite visų nelyginių skaičių nuo 30 iki 60 sumą.*/
            for (int i = 30; i <= 60; i++)
            {
                if (i % 2 != 0)
                {
                    suma += i;
                }
            }

            /*Raskite visų nelyginių skaičių nuo 30 iki 60 sumą.*/
          

            /*
            Rasti visų skaičių, žemesnių už 1000 ir didesnių už 0 bei kurie dalinasi iš 3 arba
            5, sumą.
            Pavyzdys:
            Visi skaičiai mažesni už 10 ir kurie dalinasi iš 3 arba 5 yra: 3, 5, 6, 9.
            Šių skaičių suma yra 23.
            Turite gauti 233168 atsakymą.
            */
        }
    }
}
