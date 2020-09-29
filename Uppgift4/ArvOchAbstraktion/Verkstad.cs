using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Klasser;
namespace ArvOchAbstraktion
{

        class Verkstaden : IMyInterface
        {
            string userInputText;

            // för att kunna nå mina vehicle klasser. 
            public Vehicle vehicle = new Vehicle(vehicleType: "", modellNamn: "", registeringsnummer: "", matare: 0, registeringsdatum: "");

            public void AddVehicle()
            {
            Vehicle vehicle = new Vehicle();

            Vehicle.AddSpecificVehicle();

            }
            public void DeleteVehicle()
            {

                Vehicle.DeleteSpecificVehicle();

            }


        public void ShowVehicle()
        {


            Vehicle.ShowVehicles();


        }



        }


    }

