using System;

namespace Uzduotis_07
{
    internal class Program
    {
        static void Main(string[] args)


        /*Liepkite vartotojui įvesti savo vardą ir amžių.Į ekraną išveskite: 
        * “Jūsų vardas { vardas }, o amžius { amžius }. */

        {
            Console.Write("Iveskite savo varda: ");
            var vardas = Console.ReadLine();
            Console.Write("Iveskite savo amziu: ");
            var amzius = Console.ReadLine();
            Console.WriteLine($"Jusu vardas {vardas}, o amzius {amzius}.");
            Console.WriteLine();

            /*Liepkite vartotojui įvesti bet kokį simbolį.Atspausdinkite 3x3 kvadratą iš to
                          simbolio.*/
              

            Console.WriteLine("Simbolio ivedimas");
            Console.WriteLine("Iveskite bet koki simboli: ");
            int simbolisAscii = Console.Read();
            char simbolis = Convert.ToChar(simbolisAscii);
            Console.WriteLine($"Jusu ivestas simbolis: {simbolis}");
            string ivedimas = Console.ReadLine();

            string blokas = "***\n***\n***";
            Console.WriteLine(blokas);
            Console.WriteLine();

            double skaicius;


            /*Liepkite vartotojui įvesti bet kokį skaičių. Išveskite į ekraną šio skaičiaus kvadratą.*/
            Console.WriteLine("Iveskite bet koki skaiciu: ");
            skaicius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Jusu ivestas skaicius: {skaicius}");
            Console.WriteLine($" Skaicius kvadratu: {skaicius}^2 = {skaicius * skaicius}");


            /*Liepkite vartotojui įvesti tris skaičius.Išveskite visų šių skaičių sumą, skirtumą, sandaugą ir dalmenį, nurodant atliekamus veiksmus ir šių skaičių reikšmes ekrane. Pvz.:
            5 + 3 + 8 = 16
            5 - 3 - 8 = -6*/

            Console.WriteLine("Iveskite tris skaicius per kableli: ");
            skaicius = Convert.ToDouble(Console.ReadLine());

            int Skaicius = Console.Read();
            Console.WriteLine($"Iveskite tris skaicius: {Skaicius} {Skaicius} {Skaicius}");
        }
    }
}
