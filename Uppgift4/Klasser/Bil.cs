using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Klasser
{
    class Bil : Vehicle
    {
        private bool towBar;

        public bool GetTowBar()
        {
            return towBar;
        }

        public void SetTowBar(bool value)
        {
            towBar = value;
        }

        public Bil(string vehicleType, string modellNamn, string registeringsnummer, int matare, string registeringsdatum, bool towbar) : base( vehicleType, modellNamn, registeringsnummer, matare, registeringsdatum)
        {

            this.SetTowBar(towbar);

        }

       private static List<Vehicle> vehicles = new List<Vehicle>();
        internal static void AddCar()
        {
            string userInputFordon, userInputModell, userInputRegnr, userInputDatum, userInputTowBarText = "";
            int userInputMatare;
            bool userInputTowbar = false;
            Console.WriteLine("Stämmer det att det är en bil du vill lägga til?");
            userInputFordon = Console.ReadLine();

                if (userInputFordon == "Ja")
            {

                userInputFordon = "Bil";
            }

            Console.WriteLine("vad är det för modell på bilen?");
            userInputModell = Console.ReadLine();

            Console.WriteLine("vad är det för registeringsnummer på bilen?");
            userInputRegnr = Console.ReadLine();

            Console.WriteLine("vad står mätaren på bilen på i km?");
            userInputMatare = int.Parse(Console.ReadLine());

            Console.WriteLine("När registrerades bilen (datum)?");
            userInputDatum = Console.ReadLine();

            Console.WriteLine("Har bilen en dragkrok?");
            userInputTowBarText = Console.ReadLine();

            if (userInputTowBarText =="Ja")
            {
                userInputTowbar = true;

            }
            else
            {
                userInputTowbar = false;

            }

            

            vehicles.Add(new Bil(userInputFordon, userInputModell, userInputRegnr, userInputMatare, userInputDatum, userInputTowbar));
            

        }

        



        }



        


    }
}
