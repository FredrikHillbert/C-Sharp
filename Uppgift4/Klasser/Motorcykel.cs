using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    class Motorcykel : Vehicle
    {
        private int maxFart;

        public int GetMaxFart()
        {
            return maxFart;
        }

        public void SetMaxFart(int value)
        {
            maxFart = value;
        }

        public Motorcykel (string vehicleType, string modellNamn, string registeringsnummer, int matare, string registeringsdatum, int maxFart ) : base(vehicleType,modellNamn, registeringsnummer, matare, registeringsdatum)
        {

            this.SetMaxFart(maxFart);

        }

        public Motorcykel()
        {
        }

        public void AddMotorCykelToList()
        {
            List<Vehicle> listOfVehicles = new List<Vehicle>();


            Console.WriteLine("Skriv in regnummer för motorcykeln: ");
            string userInput = Console.ReadLine();
            userInput = Registeringsnummer;

            Console.WriteLine("Skriv in hur långt motorcykeln har gått i km: ");
            int userInputNumber = int.Parse(Console.ReadLine());
            userInputNumber = Matare;

            Console.WriteLine("Skriv in regdatum för motorcykeln: ");
            userInput = Console.ReadLine();
            userInput = Registeringsdatum;

            Console.WriteLine("Skriv in maxfarten för hojjen: ");
            int userInputNumber2 = int.Parse(Console.ReadLine());
            userInputNumber2 = GetMaxFart();
            

            


            listOfVehicles.Add(new Motorcykel(VehicleType, ModellNamn, Registeringsnummer, Matare, Registeringsdatum, GetMaxFart()));




        }
















    }
}
