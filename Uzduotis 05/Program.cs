using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Threading;

namespace Uzduotis_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Išveskite į ekraną dviejų skaičių sumą, skirtumą, sandaugą ir dalmenį,
                kiekvieną kartą nurodant atliekamą veiksmą ir šių skaičių reikšmes. Pvz.: 4 + 5 = 9
                4 - 5 = -1
                   …
            */
            var a = 4;
            var b = 5;
            var suma = a + b;
            var skirtumas = a - b;
            var daugyba = a * b;
            var dalyba = a / b;
            Console.WriteLine("{0} + {1} = {2}", a, b, suma);
            Console.WriteLine("{0} - {1} = {2}", a, b, skirtumas);
            Console.WriteLine("{0} * {1} = {2}", a, b, daugyba);
            Console.WriteLine("{0} / {1} = {2}", a, b, dalyba);
            Console.WriteLine();

            /*
                2. Išveskite į ekraną pasirinktą skaičių, jo kvadratą ir jį pakeltą trečiuoju laipsniu.
            */

            int skaicius = 4;
            Console.WriteLine($"Uzduotys su skaiciumi: {skaicius}");
            Console.WriteLine($" Skaicius kvadratu: {skaicius}^2 = {skaicius * skaicius}");
            Console.WriteLine($" Skaicius treciuoju laipsniu: {skaicius}^3 = {skaicius * skaicius * skaicius}");
            Console.WriteLine();

            /*
                3. Išveskite į ekraną trijų skaičių sandaugą.
            */

            int skaicius1 = 3;
            int skaicius2 = 4;
            int skaicius3 = 5;
            Console.WriteLine($"Skaiciu {skaicius1}, {skaicius2} ir {skaicius3} sandauga:");
            Console.WriteLine($"{skaicius1} * {skaicius2} * {skaicius3} = {skaicius1 * skaicius2 * skaicius3}");
            Console.WriteLine();

        }
    }
}
