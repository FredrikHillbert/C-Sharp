using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Klasser
{
    public class Vehicle
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
       public string VehicleType { get; set; }
        public string ModellNamn { get; set; }
        public string Registeringsnummer { get; set; }
        public int Matare { get; set; }
        public string Registeringsdatum { get; set; }

        internal bool _haveTowBar;

        public Vehicle(string vehicleType, string modellNamn, string registeringsnummer, int matare, string registeringsdatum)
        {

            this.ModellNamn = modellNamn;
            this.Registeringsdatum = registeringsdatum;
            this.Registeringsnummer = registeringsnummer;
            this.Matare = matare;
           

        }

        public Vehicle()
        {


        }



        public static void AddSpecificVehicle()
        {
            string userInput;
            Console.WriteLine("Vad är det för fordon? ");
            userInput = Console.ReadLine();

            if (userInput == "Bil")
            {

                Bil.AddCar();

            }


            if (userInput == "Motorcykel")
            {

                Motorcykel.AddMotorcykel();

            }


            if (userInput == "Lastbil")
            {

                Lastbil.AddLastbil();

            }


            if (userInput == "Buss")
            {

                Buss.AddBuss();

            }
        }


        public static void DeleteSpecificVehicle()
        {



        }





        public static void ShowVehicles()
        {

            Bil.ShowCar();

            Buss.ShowBuss();

            Lastbil.ShowLastbil();

            Motorcykel.ShowMotorcykel();




        }








    }
}
    








