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
            Console.WriteLine("Ivestas skaicius " + skaicius);
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

            Console.WriteLine("Iveskite tris skaicius: ");
            var p1 = Convert.ToInt32(Console.ReadLine());
            var p2 = Convert.ToInt32(Console.ReadLine());
            var p3 = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (p1 + p2 + p3) / 3;
            Console.WriteLine("Pazymiu vidurkis: " + vidurkis);

            /*Liepkite įvesti tris skaičius. Išveskite įvestus skaičius, jų kvadratus, juos pakeltus trečiuoju laipsniu, taip pat tuos skaičius, padalintus iš dviejų.*/

            Console.WriteLine("Iveskite tris skaicius: "); //????????????

        }
    }
}
