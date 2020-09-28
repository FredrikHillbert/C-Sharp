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

        public Bil()
        {
        }

        public void AddCarToList()
        {
            List<Vehicle> listOfVehicles = new List<Vehicle>();


            Console.WriteLine("Skriv in regnummer för bilen: ");
            string userInput = Console.ReadLine();
            userInput = Registeringsnummer;

            Console.WriteLine("Skriv in hur långt bilen har gått i km: ");
             int userInputNumber = int.Parse (Console.ReadLine());
            userInputNumber = Matare;           

            Console.WriteLine("Skriv in regdatum för bilen: ");
             userInput = Console.ReadLine();
            userInput = Registeringsdatum;

            Console.WriteLine("Har bilen en dragkrok? (Ja/Nej): ");
             userInput = Console.ReadLine();
             

            if (userInput == "Ja" || userInput == "ja")
            {

                SetTowBar(true);

                
            }
            else
            {

                SetTowBar(false);
               
            }


            listOfVehicles.Add(new Bil(VehicleType, ModellNamn, Registeringsnummer, Matare, Registeringsdatum, GetTowBar()));



            
        }

        


    }
}
