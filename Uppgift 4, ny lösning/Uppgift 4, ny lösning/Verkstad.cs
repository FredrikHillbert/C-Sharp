using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Vehicles;

namespace Uppgift_4__ny_lösning
{
    class Verkstad : IVerkstad
    {
        public List<Fordon> Vehicles { get; set; }
       
        public Verkstad()
        {

            Vehicles = new List<Fordon>();
        }


        public void AddVehicle(Fordon vehicle)
        {
          Vehicles.Add(vehicle);

            

        }


        public void DeleteVehicle(Fordon vehicle)
        {
            Vehicles.Remove(vehicle);
            
        }


        public List<Fordon> ShowVehicles()
        {

            return Vehicles;

        }



    }
}
