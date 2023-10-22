using System;

namespace Uzduotis01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Parašykite programą, kuri išvestų žodį “Labas” ir jūsų vardą toje pačioje eilutėje.
             */

            string name = "Agne";
            Console.WriteLine("Labas" + name);
            Console.WriteLine();

            /*
             * Susikurkite kintamąjį žmogaus amžiui nusakyti, išveskite į ekraną tekstą su
 šiuo amžiumi: “Įvestas amžius: {amžius}”. Tarp {} nurodytas kintamasis, kurio
 reikšmė toje vietoje turi būti įstatyta.
             */
            int amzius = 35;
            Console.WriteLine("Ivestas amzius: " + amzius);
            Console.WriteLine();

            /*
              Susikurkite skaičiaus kintamąjį, kurį išveskite 
            penkis kartus toje pačioje eilutėje be tarpų tarp 
            šių skaičių (skaičius - 25, išvedimas - 2525252525).
            */

            int skaicius = 25;
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.WriteLine(skaicius);

            /*
             * Susikurkite skaičiaus kintamąjį, kurį išveskite 
             penkis kartus toje pačioje
            eilutėje su tarpais tarp šių skaičių 
            (skaičius - 25, rezultatas - 25 25 25 25 25).
            */

            Console.WriteLine($"{skaicius} {skaicius} {skaicius} {skaicius}");
            Console.WriteLine();

        }
    }
}
