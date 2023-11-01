using System;

namespace _18_uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Tikslas:
            Suskaičiuoti, kiek duonos kepalų kepykla sugebės iškepti per dieną.
            Patikrinti, ar kepykla spės iškepti visus tos dienos užsakymus, jei ne, suskaičiuoti, kiek kepalų nespės iškepti.
            Suskaičiuoti, kiek kepykla uždirbs pelno iš visų tą dieną iškeptų duonos kepalų.
            Iš anksto žinoma informacija:

            Vartotojo įvedama informacija:
            Kiek darbuotojas gali iškepti kepalų per valandą.
            Kiek darbuotojų turi kepykla.
            Vieno kepalo savikaina.
            Vieno kepalo pardavimo kaina.
            Kiek kepykla turi tą dieną iškepti kepalų (užsakymai).*/

            //     Darbo valandų per dieną - 8 val.
            int darboValandosPerDiena = 8;

            // Įvedimas
            Console.WriteLine("Iveskite kiek kepalu vienas darbuotojas gali iskepti per vieną valanda:");
            string ivedimas = Console.ReadLine();
            double kepalaiPerValandaDarbuotojo = Convert.ToDouble(ivedimas);

            Console.WriteLine("Iveskite kiek darbuotoju yra kepykloje");
            ivedimas = Console.ReadLine();
            int darbuotojuSkaicius = Convert.ToInt32(ivedimas);

            Console.WriteLine("Iveskite vieno kepalo savikaina:");
            ivedimas = Console.ReadLine();
            double kepaloSavikaina = Convert.ToDouble(ivedimas);

            Console.WriteLine("Iveskite vieno kepalo pardavimo kaina:");
            ivedimas = Console.ReadLine();
            double kepaloKaina = Convert.ToDouble(ivedimas);

            Console.WriteLine("Iveskite dienos uzsakymu skaiciu:");
            ivedimas = Console.ReadLine();
            int uzsakymai = Convert.ToInt32(ivedimas);

            // Skaičiavimai
            double kepalaiPerDiena = kepalaiPerValandaDarbuotojo * darboValandosPerDiena * darbuotojuSkaicius;
            double pajegumuIrPoreikioSkirtumas = kepalaiPerDiena - uzsakymai;

            // Paskaičiuojamas įmanomas patenkinti poreikis
            double imanomasPatenkintiPoreikis;
            if (pajegumuIrPoreikioSkirtumas < 0)
            {
                imanomasPatenkintiPoreikis = kepalaiPerDiena;
            }
            else
            {
                imanomasPatenkintiPoreikis = uzsakymai;
            }

            double kepaloPelnas = kepaloKaina - kepaloSavikaina;
            double bendrasPelnas = kepaloPelnas * imanomasPatenkintiPoreikis;

            // Išvedimas
            Console.WriteLine();
            Console.WriteLine("Kepyklos pajėgumai:");
            Console.WriteLine($"   Darbuotojų skaičius - {darbuotojuSkaicius}");
            Console.WriteLine($"   Darbo valandos      - {darboValandosPerDiena}");
            Console.WriteLine($"   Kepėjų greitis      - {kepalaiPerValandaDarbuotojo} (kepalų per valandą)");
            Console.WriteLine($"   Kepalai per dieną   - {kepalaiPerDiena}");
            Console.WriteLine();

            Console.WriteLine("Poreikio patenkinimas:");
            Console.WriteLine($"   Įmanoma pagaminti kepalų per dieną  - {kepalaiPerDiena}");
            Console.WriteLine($"   Kepalų užsakymų skaičius per dieną  - {uzsakymai}");
            if (pajegumuIrPoreikioSkirtumas < 0)
            {
                Console.Write($"   Trūkumas poreikiui patenkinti       - ");
            }
            else
            {
                Console.Write($"   Neišpildomi pajėgumai               - ");
            }
            Console.WriteLine(Math.Abs(pajegumuIrPoreikioSkirtumas));
            Console.WriteLine();

            Console.WriteLine("Pelningumas:");
            Console.WriteLine($"   Kepalų užsakymų skaičius per dieną  - {uzsakymai}");
            Console.WriteLine($"   Įmanomas patenkinti poreikis        - {imanomasPatenkintiPoreikis}");
            Console.WriteLine($"   Kepalo savikaina                    - {kepaloSavikaina}");
            Console.WriteLine($"   Kepalo pardavimo kaina              - {kepaloKaina}");
            Console.WriteLine($"   Vieno kepalo pelnas                 - {kepaloPelnas}");
            Console.WriteLine($"   Bendras pelnas                      - {bendrasPelnas}");
            Console.WriteLine();
        }
    }
}
