using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {            /*
             * Susikurti žodžių sąrašą. 
             * 
             * Rasti trumpiausią ir ilgiausią žodžius, 
             * juos išvesti į ekraną, 
             * prie kiekvieno pasakant iš kiek raidžių jis yra sudarytas.
             *      Tip: string kintamasis iš tiesų yra char masyvas, 
             *      todėl galite naudoti zodis.Length
             */

            List<string> zodziuSarasas = new List<string>();
            zodziuSarasas.Add("žodis");
            zodziuSarasas.Add("šokoladas");
            zodziuSarasas.Add("pienas");
            zodziuSarasas.Add("akvariumas");
            zodziuSarasas.Add("du");

            int indeksasIlgiausio = -1;
            int ilgisIlgiausio = Int32.MinValue;
            int indeksasTrumpiausio = -1;
            int ilgisTrumpiausio = Int32.MaxValue;

            for (int i = 0; i < zodziuSarasas.Count; i++)
            {
                if (zodziuSarasas.ElementAt(i).Length > ilgisIlgiausio)
                {
                    indeksasIlgiausio = i;
                    ilgisIlgiausio = zodziuSarasas.ElementAt(i).Length;
                }
                else if (zodziuSarasas.ElementAt(i).Length < ilgisTrumpiausio)
                {
                    indeksasTrumpiausio = i;
                    ilgisTrumpiausio = zodziuSarasas.ElementAt(i).Length;
                }
            }

            Console.WriteLine($"Ilgiausias žodis: '{zodziuSarasas.ElementAt(indeksasIlgiausio)}', jo ilgis: '{zodziuSarasas.ElementAt(indeksasIlgiausio).Length}'");
            Console.WriteLine($"Trumpiausias žodis: '{zodziuSarasas.ElementAt(indeksasTrumpiausio)}', jo ilgis: '{zodziuSarasas.ElementAt(indeksasTrumpiausio).Length}'");
        }
    }
}
