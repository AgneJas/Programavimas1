using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_uzduotis
{
    internal class Program
    {
        /*Paklausti vartotojo, kiek duomenų nori įvesti į masyvą  Pagal tai sukursime tokio dydžio masyvą
        Iš konsolės įvesti duomenis į masyvą
        Surasti 2 sumas:
        Suma1 – kai masyvo elementas yra lyginis skaičius  
        Suma2 – kai masyvo indeksas nėra lyginis skaičius
        */

        static void Main(string[] args)
        {
            Console.Write("Kiek skaičių norite įvesti?: ");
            int kiekis = Convert.ToInt32(Console.ReadLine());

            int[] skaiciai = new int[kiekis];

            for (int i = 0; i < kiekis; i++)
            {
                Console.Write($"Įveskite {i + 1} skaičių: ");
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }

            int suma1 = 0;
            int suma2 = 0;

            for (int i = 0; i < kiekis; i++)
            {
                if (skaiciai[i] % 2 == 0)
                {
                    suma1 += skaiciai[i];
                }
                if (i % 2 != 0)
                {
                    suma2 += skaiciai[i];
                }
            }

            Console.WriteLine($"Suma1 – kai masyvo elementas yra lyginis skaičius: {suma1}");
            Console.WriteLine($"Suma2 – kai masyvo indeksas nėra lyginis skaičius: {suma2}");
        }
    }
    }
