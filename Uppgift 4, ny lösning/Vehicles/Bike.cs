using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
   public class Bike : Fordon
    {

        public int MaxFart { get; set; }



        public Bike()
        {


        }


        public override void PrintOutVehicle()
        {
            base.PrintOutVehicle();

            Console.WriteLine($"Maxfarten för motorcykeln är: {MaxFart}");

        }






    }
}
