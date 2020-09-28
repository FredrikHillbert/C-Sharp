using Klasser;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    interface IMyInterface
    {

        

        void AddVehicle();

        void DeleteVehicle();

        void ShowVehicle();
        List<Vehicle> ShowVehicleList();
    }
}
