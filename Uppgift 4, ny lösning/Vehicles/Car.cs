using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Vehicles
{
    public class Car : Fordon
    {

        public bool HaveTowBar { get; set; }


        public Car()
        {

        }



        public override void PrintOutVehicle()
        {
            base.PrintOutVehicle();

            if (HaveTowBar == true)
            {
                Console.WriteLine("Bilen har en dragkrok");
            }

            else if(HaveTowBar == false)
            {

                Console.WriteLine("Bilen har inte en dragkrok");
            }


        }










    }
}
