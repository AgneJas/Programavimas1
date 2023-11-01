using System;

namespace _20_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Įveskite iš konsolės 2 skaičius (stataus trikampio statinių ilgius).
            Suraskite įžambinę ir ją išveskite į ekraną.
            Tip: Pitagoro teorema teigia, jog stataus trikampio statinių kvadratų suma yra
            lygi įžambinės kvadratui.

            Jau žinome, jog Math.Pow(skaicius, laipsnis) – kintamąjį skaičius pakelia laipsniu.  Jei norime ištraukti kvadratinę šaknį, reiktų kelti 0.5 laipsniu.
            Arba naudoti šaknies funkciją Math.Sqrt(z)
            */
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Įveskite pirmo trikampio statinio ilgį: ");
            double statinis1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Įveskite antro trikampio statinio ilgį: ");
            double statinis2 = Convert.ToDouble(Console.ReadLine());

            double izambine = Math.Sqrt(Math.Pow(statinis1, 2) + Math.Pow(statinis2, 2));
            Console.WriteLine($"Trikampio įžambinės ilgis: '{izambine}'");
        }
    }
}
