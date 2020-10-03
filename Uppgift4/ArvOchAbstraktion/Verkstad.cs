using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Klasser;
namespace ArvOchAbstraktion
{

        class Verkstaden : IMyInterface
        {
          
    
        public void AddVehicle()
            {
            Vehicle vehicle = new Vehicle();
           
            vehicle.AddSpecificVehicle();

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

