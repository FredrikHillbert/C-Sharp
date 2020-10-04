using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    class Lastbil : Vehicle
    {
        public int MaxLast { get; private set; }


        public Lastbil (string vehicleType, string modellNamn, string registeringsnummer, int matare, string registeringsdatum, int maxLast) : base(vehicleType, modellNamn, registeringsnummer, matare, registeringsdatum)
        {

            this.MaxLast = maxLast;


        }



        public static List<Lastbil> lastbilar = new List<Lastbil>();


        internal static void AddLastbil()
        {
            string userInputFordon, userInputModell, userInputRegnr, userInputDatum;
            int userInputMatare;
            int userInputAntal;
            Console.WriteLine("Stämmer det att det är en lastbil du vill lägga til?");
            userInputFordon = Console.ReadLine();

            if (userInputFordon.ToLower() == "Ja")
            {

                userInputFordon = "Lastbil";
            }

            else
            {

                //AddSpecificVehicle();
            }
            Console.Clear();

            Console.WriteLine("vad är det för modell på lastbilen?");
            userInputModell = Console.ReadLine();

            Console.WriteLine("vad är det för registeringsnummer på lastbilen?");
            userInputRegnr = Console.ReadLine();

            Console.WriteLine("vad står mätaren på lastbilen på i km?");
            userInputMatare = int.Parse(Console.ReadLine());

            Console.WriteLine("När registrerades lastbilen (datum)?");
            userInputDatum = Console.ReadLine();

            Console.WriteLine("Vad är maxlastet på lastbilen?");
            userInputAntal = int.Parse(Console.ReadLine());




            lastbilar.Add(new Lastbil(userInputFordon, userInputModell, userInputRegnr, userInputMatare, userInputDatum, userInputAntal));


        }



        internal static List<Lastbil> ShowLastbil()
        {




            foreach (var item in lastbilar)
            {

                Console.WriteLine($"Detta är en lastbil");

                Console.WriteLine($"Fordonet är av modellen {item.ModellNamn}");

                Console.WriteLine($"Milmätaren står på {item.Matare}");

                Console.WriteLine($"Fordonet registrerades {item.Registeringsdatum}");

                Console.WriteLine($"Fordonets registreringsnummer är: {item.Registeringsnummer}");

                Console.WriteLine($"Maxlastet för den här lastbilen är {item.MaxLast}kg");
            }

            Console.WriteLine("\t----------------------");


            return lastbilar;


        }














    }
}
