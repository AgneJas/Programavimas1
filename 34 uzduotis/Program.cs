using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Įveskite pirmą sveikąjį skaičių: ");
            string ivedimas = Console.ReadLine();
            int skaicius1 = Convert.ToInt32(ivedimas);

            Console.Write("Įveskite antrą sveikąjį skaičių: ");
            ivedimas = Console.ReadLine();
            int skaicius2 = Convert.ToInt32(ivedimas);

            Console.Write("Kokį veiksmą norite atlikti? (daugyba / dalyba): ");
            ivedimas = Console.ReadLine();

            if (ivedimas == "daugyba")
            {
                Console.WriteLine($"Sandauga: {Daugyba(skaicius1, skaicius2)}");
            }
            else if (ivedimas == "dalyba")
            {
                Console.WriteLine($"Dalyba: {Dalyba(skaicius1, skaicius2)}");
            }
            else
            {
                Console.WriteLine($"veiksmo '{ivedimas}' nėra!");
            }
        }

        private static double Dalyba(int skaicius1, int skaicius2)
        {
            return (double)skaicius1 / skaicius2;
        }

        private static int Daugyba(int skaicius1, int skaicius2)
        {
            return skaicius1 * skaicius2;
        }
    }
}
