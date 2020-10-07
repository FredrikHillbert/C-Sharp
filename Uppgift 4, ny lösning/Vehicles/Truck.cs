using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Fordon
    {
        public int MaxLast { get; set; }


        public Truck()
        {



        }



        public override void PrintOutVehicle()
        {
            base.PrintOutVehicle();

            Console.WriteLine($"Maxlastet för lastbilen är: {MaxLast}");

        }








    }
}
