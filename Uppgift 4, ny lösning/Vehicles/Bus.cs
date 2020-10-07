using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Fordon
    {

        public int AntalPassagare { get; set; }


        public Bus()
        {


        }

        public override void PrintOutVehicle()
        {
            base.PrintOutVehicle();

            Console.WriteLine($"Bussen kan ta {AntalPassagare} antal passagerare");



        }









    }
}
