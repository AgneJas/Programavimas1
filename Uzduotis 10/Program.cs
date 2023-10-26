using System;

namespace Uzduotis_10
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          * Liepkite vartotojui įvesti savo amžių. Jei amžius yra 18 arba daugiau, tuomet į ekraną išveskite, kad “jūs galite balsuoti”.*/

            Console.WriteLine("Iveskite savo amziu");
            int amzius;
            amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Jus ivedete savo amziu: {amzius}");

            if (amzius >= 18)
            {
                Console.WriteLine("Jus galite balsuoti");
            }

            /*Liepkite vartotojui įvesti bet kokį skaičių Parašykite šias atskiras if sąlygas:

            Patikrinti, ar skaičius neigiamas, jei taip - aprėkti vartotoją :)
            Patikrinti, ar skaičius teigiamas, jei taip - pasveikinti vartotoją;
            Patikrinti, ar skaičius lyginis, jei taip - išvesti “taip, skaičius yra lyginis”;
            Patikrinti, ar skaičius dalinasi iš 4, jei taip - išvesti “taip, dalinasi iš 4”;
            Patikrinti, ar skaičius yra didesnis nei 10, jei taip - išvesti “taip, skaičius yra didesnis už 10”.
            .*/
              
                Console.WriteLine("Iveskite bet koki skaiciu");
            int skaicius;
            skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Jus ivedete skaiciu: {skaicius}");

            if (skaicius < 0)
            {
                Console.WriteLine("BLOGAI!");
            }

            if (skaicius > 0)
            {
                Console.WriteLine("Sveikiname");
            }

            if (skaicius % 2==0)
            {
                Console.WriteLine("Taip, skaicius yra lyginis");
            }

            if (skaicius /4 == 0)
            {
                Console.WriteLine("Taip, dalinasi iš 4");
            }

            if (skaicius > 10)
            {
                Console.WriteLine("Taip, skaičius yra didesnis už 10");
            }

            /*Liepkite vartotojui įvesti du savo pažymius,
             raskite šių pažymių vidurkį, patikrinkite, ar vidurkis yra lygus arba didesnis už 5, jei taip, išveskite “Valio!!!”*/

            Console.WriteLine("Iveskite 2 savo pazymius");
            int number1, number2;
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Jus ivedete: {number1}, {number2}");
            double average = (number1 + number2 / 2);
            Console.WriteLine($"average = {average}");
            Console.WriteLine();

            if (average >= 5)
            {
                Console.WriteLine("Valio!!!");
            }

        }
        }
    }

