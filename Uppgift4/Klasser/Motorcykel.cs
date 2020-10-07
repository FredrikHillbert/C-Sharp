using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Motorcykel : Vehicle
    {
        public int MaxFart { get; set; }

       
        public Motorcykel()
        {

            _userInputFordon = "Motorcykel";

        }



        public override void ShowVehicles()
        {


            base.ShowVehicles();

            Console.WriteLine($"{MaxFart}");



        }

        
    }
}
