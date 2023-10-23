using System;

namespace Uzuodis_04
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Susikurkite reikiamus kintamuosius užduočiai atlikti. 
             *Į ekraną išveskite: Automobilio {markė} {modelis} ({metai} m.) rida - {rida} km.
                Tarp {} nurodyti reikiami kintamieji, šiose vietose jų reikšmės turi būti įstatytos.
            */
            string marke = "Renault";
            String modelis = "Clio";
            int metai = 2010;
            int rida = 150000;
            Console.WriteLine($"Automobilio {marke} {modelis} {metai} m. {rida} km.");
        }
    }
}
