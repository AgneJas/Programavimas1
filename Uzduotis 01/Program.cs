﻿using System;

namespace Uzduotis_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string name = "Agne";
            Console.WriteLine("Labas, " + name);
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
             * Susikurkite skaičiaus kintamąjį, kurį išveskite 
             penkis kartus toje pačioje
            eilutėje su tarpais tarp šių skaičių 
            (skaičius - 25, rezultatas - 25 25 25 25 25).
            */

            int skaicius = 25;
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.Write(skaicius);
            Console.WriteLine(skaicius);

            Console.WriteLine($"{skaicius} {skaicius} {skaicius} {skaicius}");
            Console.WriteLine();
        }
    }
}
 
