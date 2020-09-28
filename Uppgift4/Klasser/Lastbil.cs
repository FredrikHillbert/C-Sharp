using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    class Lastbil : Vehicle
    {
        private int maxLast;

        public int GetMaxLast()
        {
            return maxLast;
        }

        public void SetMaxLast(int value)
        {
            maxLast = value;
        }

        public Lastbil (string vehicleType, string modellNamn, string registeringsnummer, int matare, string registeringsdatum, int maxLast) : base(vehicleType, modellNamn, registeringsnummer, matare, registeringsdatum)
        {

            this.SetMaxLast(maxLast);


        }

        public Lastbil()
        {
        }

        public void AddTruckToList()
        {
            List<Vehicle> listOfVehicles = new List<Vehicle>();


            Console.WriteLine("Skriv in regnummer för lastbilen: ");
            string userInput = Console.ReadLine();
            userInput = Registeringsnummer;

            Console.WriteLine("Skriv in hur långt lastbilen har gått i km: ");
            int userInputNumber = int.Parse(Console.ReadLine());
            userInputNumber = Matare;

            Console.WriteLine("Skriv in regdatum för lastbilen: ");
            userInput = Console.ReadLine();
            userInput = Registeringsdatum;

            Console.WriteLine("Skriv in maxlastet för lastbilen i kg: ");
            int userInputNumber2 = int.Parse(Console.ReadLine());
            userInputNumber2 = GetMaxLast();





            listOfVehicles.Add(new Lastbil(VehicleType, ModellNamn, Registeringsnummer, Matare, Registeringsdatum, GetMaxLast()));



        }


        }
}
