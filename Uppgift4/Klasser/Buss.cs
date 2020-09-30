using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    class Buss : Vehicle
    {


        public int AntalPassagerare { get; private set; }

        public Buss (string vehicleType, string modellNamn, string registeringsnummer, int matare, string registeringsdatum, int antalPassagerare) : base(vehicleType, modellNamn, registeringsnummer, matare, registeringsdatum)
        {

            this.AntalPassagerare = antalPassagerare;

        }



        public static List<Buss> bussar = new List<Buss>();


        internal static void AddBuss()
        {
            string userInputFordon, userInputModell, userInputRegnr, userInputDatum;
            int userInputMatare;
            int userInputAntal;
            Console.WriteLine("Stämmer det att det är en Buss du vill lägga til?");
            userInputFordon = Console.ReadLine();

            if (userInputFordon == "Ja")
            {

                userInputFordon = "Buss";
            }

            else
            {

                //gå tillbaka
            }

            Console.WriteLine("vad är det för modell på bussen?");
            userInputModell = Console.ReadLine();

            Console.WriteLine("vad är det för registeringsnummer på bussen?");
            userInputRegnr = Console.ReadLine();

            Console.WriteLine("vad står mätaren på bussen på i km?");
            userInputMatare = int.Parse(Console.ReadLine());

            Console.WriteLine("När registrerades bussen (datum)?");
            userInputDatum = Console.ReadLine();

            Console.WriteLine("Hur många plaster har bussen?");
            userInputAntal = int.Parse(Console.ReadLine());




            bussar.Add(new Buss(userInputFordon, userInputModell, userInputRegnr, userInputMatare, userInputDatum, userInputAntal));


        }



        internal static List<Buss> ShowBuss()
        {




            foreach (var item in bussar)
            {

                Console.WriteLine($"Detta är en buss");

                Console.WriteLine($"Fordonet är av modellen {item.ModellNamn}");

                Console.WriteLine($"Milmätaren står på {item.Matare}");

                Console.WriteLine($"Fordonet registrerades {item.Registeringsdatum}");

                Console.WriteLine($"Fordonets registreringsnummer är: {item.Registeringsnummer}");

                Console.WriteLine($"I den här bussen får det plats {item.AntalPassagerare} passagerare");
            }

            Console.WriteLine("\t----------------------");


            return bussar;


        }





    }
}
