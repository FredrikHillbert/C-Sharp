using Klasser;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
   public interface IMyInterface
    {


        bool AddVehicle(Vehicle vehicle);

        void DeleteVehicle(Vehicle vehicle);

        List<Vehicle> ShowVehicle();

       
    }
}
