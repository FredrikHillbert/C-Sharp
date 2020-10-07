using System;

namespace Vehicles
{
    public class Fordon
    {

        public string ModellNamn { get; set; }
        public string RegNummer { get; set; }
        public int Matare { get; set; }

        public DateTime RegTime { get; set; }

        public string _typeOfVehicle;



        public Fordon()
        {



        }



        public virtual void PrintOutVehicle()
        {
            Console.WriteLine($"Det här är en {_typeOfVehicle}");
            Console.WriteLine($"Fordonet är av modellen: {ModellNamn}");
            Console.WriteLine($"Mätaren står på: {Matare}");
            Console.WriteLine($"Regnumret är: {RegNummer}");
            Console.WriteLine($"Fordonet registrerades {RegTime}");

        }





        public string GetVehicleName()
        {

            return _typeOfVehicle;
        }






    }
}
