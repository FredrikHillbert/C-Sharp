using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    class Motorcykel : Vehicle
    {
        private int MaxFart { get; set; }

        public Motorcykel(string vehicleType, string modellNamn, string registeringsnummer, int matare, string registeringsdatum, int maxFart) : base(vehicleType, modellNamn, registeringsnummer, matare, registeringsdatum)
        {

            this.MaxFart = maxFart;

        }


        

        public static List<Motorcykel> motorcykels = new List<Motorcykel>();


        internal static void AddMotorcykel()
        {
            string userInputFordon, userInputModell, userInputRegnr, userInputDatum;
            int userInputMatare;
            int userInputAntal;
            Console.WriteLine("Stämmer det att det är en motorcykel du vill lägga til?");
            userInputFordon = Console.ReadLine();

            if (userInputFordon == "Ja")
            {

                userInputFordon = "Motorcykel";
            }

            else
            {

                //gå tillbaka
            }

            Console.WriteLine("vad är det för modell på motorcykeln?");
            userInputModell = Console.ReadLine();

            Console.WriteLine("vad är det för registeringsnummer på motorcykeln?");
            userInputRegnr = Console.ReadLine();

            Console.WriteLine("vad står mätaren på motorcykeln på i km?");
            userInputMatare = int.Parse(Console.ReadLine());

            Console.WriteLine("När registrerades motorcykeln (datum)?");
            userInputDatum = Console.ReadLine();

            Console.WriteLine("Vad är topphastigheten för motorcykeln?");
            userInputAntal = int.Parse(Console.ReadLine());




            motorcykels.Add(new Motorcykel(userInputFordon, userInputModell, userInputRegnr, userInputMatare, userInputDatum, userInputAntal));


        }



        internal static List<Motorcykel> ShowMotorcykel()
        {




            foreach (var item in motorcykels)
            {

                Console.WriteLine($"Detta är en motorcykel");

                Console.WriteLine($"Fordonet är av modellen {item.ModellNamn}");

                Console.WriteLine($"Milmätaren står på {item.Matare}");

                Console.WriteLine($"Fordonet registrerades {item.Registeringsdatum}");

                Console.WriteLine($"Fordonets registreringsnummer är: {item.Registeringsnummer}");

                Console.WriteLine($"Topphastigheten för hojjen är {item.MaxFart}km/h");
            }

            Console.WriteLine("\t----------------------");


            return motorcykels;


        }














    }
}
