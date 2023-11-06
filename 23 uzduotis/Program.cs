using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Susikurkite kintamąjį, kuris pasakytų kiek automobilis vidutiniškai sunaudoja  degalų 100 – ui km. Susikurkite masyvą, kuriame saugotumėte skirtingose
            kelionėse nuvažiuotų kilometrų rodmenis. Raskite:
            trumpiausią kelionę;
            ilgiausią kelionę;
            kiek kuro sąnaudų sunaudojo automobilis (skaičiavimui reikės rasti visus  nuvažiuotus km).
            */

            double sanaudosSimtuiKm = 5;
            int[] keliones = { 10, 4988, 16, 497, 2 };

            double sanaudosVisuKelioniu = sanaudosSimtuiKm * keliones.Sum() / 100;

            Console.WriteLine($"Trumpiausia kelionė: {keliones.Min()}");
            Console.WriteLine($"Ilgiausia kelionė: {keliones.Max()}");
            Console.WriteLine($"Nuvažiuota kilometrų: {keliones.Sum()}");
            Console.WriteLine($"Kuro sąnaudos: {sanaudosVisuKelioniu}");
        }
    }
}
