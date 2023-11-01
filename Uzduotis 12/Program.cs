using System;

namespace Uzduotis_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Liepkite įvesti du skaičius. Patikrinkite (naudojant 4 atskirus if’us):
            ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;
            ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;
            ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;
            ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.*/

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            /*Liepkite įvesti tris skirtingus skaičius. Suraskite, kuris iš šių skaičių yra didžiausias.*/

            Console.WriteLine("Iveskite pirma skaiciu: ");
            string ivedimas = Console.ReadLine();
            int skaicius1 = Convert.ToInt32(ivedimas);

            Console.WriteLine("Iveskite antra skaiciu: ");
            ivedimas = Console.ReadLine();
            int skaicius2 = Convert.ToInt32(ivedimas);

            Console.WriteLine("Iveskite trecia skaiciu: ");
            ivedimas = Console.ReadLine();
            int skaicius3 = Convert.ToInt32(ivedimas);

            Console.WriteLine("Įvesti skaičiai: '{0}', '{1}' ir '{2}'", skaicius1, skaicius2, skaicius3);

            if (skaicius1 > skaicius2 && skaicius1 > skaicius3)
            {
                Console.WriteLine("Pirmas skaičius ({0}) yra didžiausias", skaicius1);
            }
            else if (skaicius2 > skaicius1 && skaicius2 > skaicius3)
            {
                Console.WriteLine("Antras skaičius ({0}) yra didžiausias", skaicius2);
            }
            else if (skaicius3 > skaicius1 && skaicius3 > skaicius2)
            {
                Console.WriteLine("Trečias skaičius ({0}) yra didžiausias", skaicius3);
            }
            Console.WriteLine();


            /*Liepkite įvesti egzamino rezultatą. Atlikite šiuos patikrinimus:
       ar gautas rezultatas yra [8-10];
       ar gautas rezultatas yra [5-8);
       ar gautas rezultatas yra < 5.*/
            {
                Console.WriteLine("Iveskite egzamino rezultata: ");
                int rezultatas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Jus ivedete {rezultatas}");
                if (rezultatas >= 8 && rezultatas <= 10)
                {
                    Console.WriteLine("Puikiai!");
                }
                else if (rezultatas >= 5 && rezultatas < 8)
                {
                    Console.WriteLine("Patenkinamai");
                }
                else if (rezultatas < 5 && rezultatas >= 0)
                {
                    Console.WriteLine("Neišlaikyta");
                }
                Console.WriteLine();

                /*Liepkite įvesti du skaičius. Patikrinkite (naudojant 4 atskirus if’us):
                ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;
                ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;
                ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;
                ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.*/

                Console.WriteLine("Iveskite pirma skaiciu: ");
                ivedimas = Console.ReadLine();

                Console.WriteLine("Iveskite antra skaiciu: ");
                ivedimas = Console.ReadLine();

                if (skaicius1 > skaicius2 || skaicius1 == 0)
                {
                    Console.WriteLine("Pirma sąlyga tenkinama");
                }

                if (skaicius2 > skaicius1 || skaicius2 == 5)
                {
                    Console.WriteLine("Antra sąlyga tenkinama");
                }

                if (skaicius1 > skaicius2 && skaicius1 == 20)
                {
                    Console.WriteLine("Trečia sąlyga tenkinama");
                }

                if (skaicius2 > skaicius1 && skaicius2 < 100);


            }
        }
    }
}
            
    
  