using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {            /* Paprašyti įvesti vartotojo vardą.
            
             * Sukurti string tipo metodą 
             * kuris gražina frazę pvz „Sveiki, Mantas“.
             
             * Išvesti šią frazę į konsolę.
             */

            Console.Write("Įveskite savo vardą: ");
            string vardas = Console.ReadLine();

            string zinute = Pasisveikinimas(vardas);
            Console.WriteLine(zinute);
        }

        private static string Pasisveikinimas(string vardas)
        {
            return $"Sveiki, {vardas}";
        }
    }
    }
}
