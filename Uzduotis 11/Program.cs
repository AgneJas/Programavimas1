using System;
using System.Diagnostics.Eventing.Reader;

namespace Uzduotis_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Liepkite vartotojui įvesti tris skaičius, parašyti šią patikrinimo sąlygą, naudojant else if dalis:
            ar pirmas skaičius didesnis už antrą;
            ar antras skaičius didesnis už trečią;
            ar trečias skaičius didesnis už pirmą;
            ar pirmi du skaičiai lygūs;*/

            Console.WriteLine("Iveskite tris skaicius");
            int number1, number2, number3;
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Jus ivedete: {number1}, {number2}, {number3}");

            if (number1 > number2)
                Console.WriteLine($"Pirmas skaičius yra didesnis už antrą");
            else
                Console.WriteLine($"Pirmas skaičius nėra didesnis už antrą");

            if (number2 > number3)
                Console.WriteLine($"Antras skaičius yra didesnis už trečią");
            else
                Console.WriteLine($"Antras skaičius nėra didesnis už trečią");

            if (number3 > number1)
                Console.WriteLine($"Trecias skaičius yra didesnis už pirma");
            else
                Console.WriteLine($"Trecias skaičius nėra didesnis už pirma");

            /*ar pirmi du skaičiai lygūs;*/
            if (number1 == number2)

            Console.WriteLine($"Pirmas ir antras skaiciai yra lygus");
            else
                Console.WriteLine($"Pirmas ir antras skaiciai nera lygus");

            /*Liepkite vartotojui įvesti šios dienos oro temperatūrą, atlikite šiuos patikrinimus:
            ar temperatūra < 0 - išvesti “žiauriai šalta”;
            ar temperatūra < 10 - išvesti “labai šalta”;
            ar temperatūra < 20 - išvesti “šalta”;
            ar temperatūra < 30 - išvesti “normali temperatūra”;
            ar temperatūra < 40 - išvesti “karšta”;
            ar temperatūra >= 40 - išvesti “visiškai degina”;*/

            Console.WriteLine("Iveskite sios dienos oro temperatura");
            int temperatura;
            temperatura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Jus ivedete: {temperatura}");

            if (temperatura < 0)
                Console.WriteLine($"Ziauriai salta");



        }
        }
    }

