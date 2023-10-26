using System;

namespace Uzduotis_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Liepkite vartotojui įvesti bet kokį sveikąjį skaičių. 
             Išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5. Pvz.: 2 * 1 = 2 … 2 * 5 = 10*/

            Console.WriteLine("Iveskite bet koki sveikaji skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            int daugiklis = 1;
            Console.WriteLine($"Skaiciaus {skaicius} daugybos lentele:");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine();

            /* Liepkite vartotojui įvesti tris skaičius. Į ekraną išveskite šiuos skaičius ir jų vidurkį. Pvz.:
             Įvestų skaičių 4, 5, 8 vidurkis: 5,7.*/

            Console.WriteLine("Iveskite tris skaicius");
            int number1, number2, number3;
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Jus ivedete: {number1}, {number2}, {number3}");
            double average = (number1 + number2 + number3) / 3;
            Console.WriteLine($"average = {average}");
            Console.WriteLine();

            /*
            Liepkite įvesti tris skaičius. Išveskite įvestus skaičius, jų kvadratus, 
            juos pakeltus trečiuoju laipsniu, taip pat tuos skaičius, padalintus iš dviejų.*/

            Console.WriteLine($"Jus ivedete: {number1}, {number2}, {number3}");
            Console.WriteLine($" Skaicius {number1} kvadratu: {number1}^2 = {number1 * number1}");
            Console.WriteLine($" Skaicius {number2} kvadratu: {number2}^2 = {number2 * number2}");
            Console.WriteLine($" Skaicius {number3} kvadratu: {number3}^2 = {number3 * number3}");
            Console.WriteLine();

            Console.WriteLine($" Skaicius {number1} treciuoju laipsniu: {number1}^3 = {number1 * number1 * number1}");
            Console.WriteLine($" Skaicius {number2} treciuoju laipsniu: {number2}^3 = {number2 * number2 * number2}");
            Console.WriteLine($" Skaicius {number2} treciuoju laipsniu: {number2}^3 = {number3 * number3 * number3}");

            Console.WriteLine($"Skaiciai padalinti is 2: {number1}, {number2}, {number3} = {number1 / 2}, {number2 / 2}, {number3 /2}");
            Console.WriteLine();
        }
    }
}
