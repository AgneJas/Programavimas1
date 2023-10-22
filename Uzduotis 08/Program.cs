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
            int daugiklis = 0;
            Console.WriteLine($"Skaiciaus {skaicius} daugybos lentele:");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine();








           /* Liepkite vartotojui įvesti tris skaičius. Į ekraną išveskite šiuos skaičius ir jų vidurkį. Pvz.:
Įvestų skaičių 4, 5, 8 vidurkis: 5,7.
Liepkite įvesti tris skaičius. Išveskite įvestus skaičius, jų kvadratus, juos pakeltus trečiuoju laipsniu, taip pat tuos skaičius, padalintus iš dviejų.*/
           

        }
    }
}
