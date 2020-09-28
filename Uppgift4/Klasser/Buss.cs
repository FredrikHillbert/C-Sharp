using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    class Buss : Vehicle
    {


        public int AntalPassagerare { get; set; }

        public Buss (string vehicleType, string modellNamn, string registeringsnummer, int matare, string registeringsdatum, int antalPassagerare) : base(vehicleType, modellNamn, registeringsnummer, matare, registeringsdatum)
        {

            this.AntalPassagerare = antalPassagerare;

        }

        public Buss()
        {


        }


        public void AddBussToList()
        {
            List<Vehicle> listOfVehicles = new List<Vehicle>();


            Console.WriteLine("Skriv in regnummer för bussen: ");
            string userInput = Console.ReadLine();
            userInput = Registeringsnummer;

            Console.WriteLine("Skriv in hur långt bussen har gått i km: ");
            int userInputNumber = int.Parse(Console.ReadLine());
            userInputNumber = Matare;

            Console.WriteLine("Skriv in regdatum för bussen: ");
            userInput = Console.ReadLine();
            userInput = Registeringsdatum;

            Console.WriteLine("Skriv in max antal passagerare för bussen: ");
            int userInputNumber2 = int.Parse(Console.ReadLine());
            userInputNumber2 = AntalPassagerare;





            listOfVehicles.Add(new Buss(VehicleType, ModellNamn, Registeringsnummer, Matare, Registeringsdatum, AntalPassagerare));



        }







    }
}
