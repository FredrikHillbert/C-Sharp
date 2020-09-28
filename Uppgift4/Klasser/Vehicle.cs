using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
   public class Vehicle
    {
        public object MaxFart;
        public object TowBar;
        public object MaxLast;
        public object antalPassagerare;

        public string VehicleType { get; set; }
        public string ModellNamn { get; set; }
        public string Registeringsnummer { get; set; }
        public int Matare { get; set; }
        public string Registeringsdatum { get; set; }
        

        public Vehicle(string vehicleType, string modellNamn, string registeringsnummer, int matare, string registeringsdatum)
        {

            this.ModellNamn = modellNamn;
            this.Registeringsdatum = registeringsdatum;
            this.Registeringsnummer = registeringsnummer;
            this.Matare = matare;
            this.VehicleType = vehicleType;


        }

        public Vehicle(string vehicleType)
        {
            this.VehicleType = vehicleType;
        }

        public Vehicle()
        {

        }


        public void VehicleStats()
        {

            if (VehicleType == VehicleType)
            {

                Bil anInstanceOfMyClass = new Bil();

                anInstanceOfMyClass.AddCarToList();

            }

            else if (VehicleType == VehicleType)
            {

                Motorcykel anInstanceOfMyClass = new Motorcykel();
                anInstanceOfMyClass.AddMotorCykelToList();

            }
            
            else if (VehicleType == VehicleType)
            {

                Lastbil anInstanceOfMyClass = new Lastbil();
                anInstanceOfMyClass.AddTruckToList();

            }

            else if (VehicleType == VehicleType)
            {


                Buss anInstanceOfMyClass = new Buss();
                anInstanceOfMyClass.AddBussToList();


            }
            else
            {
                Console.WriteLine("Du skrev inte in ett fordon");

            }


        }








    }
    






}

