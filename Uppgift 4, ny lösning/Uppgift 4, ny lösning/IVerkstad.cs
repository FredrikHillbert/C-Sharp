using System;
using System.Collections.Generic;
using System.Text;
using Vehicles;

namespace Uppgift_4__ny_lösning
{
    interface IVerkstad
    {

        public void AddVehicle(Fordon vehicle);

        public void DeleteVehicle(Fordon vehicle);


        List<Fordon> ShowVehicles();





    }
}
