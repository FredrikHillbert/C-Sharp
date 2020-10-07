using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Klasser;
namespace ArvOchAbstraktion
{

    class Verkstaden : IMyInterface
    {
        private List<Vehicle> _vehicles;
        public List<Vehicle> Vehicles 
        
        
        
        {
            get
            {
                if (_vehicles == null)
                {
                    _vehicles = new List<Vehicle>();

                }
                return _vehicles;
            }
           
            set
            {
                _vehicles = value;
            }
        }
        
        public bool AddVehicle(Vehicle vehicle)
        {
            bool vehicleAdded = true;
            Vehicles.Add(vehicle);

            return vehicleAdded;
            

        }

        public void DeleteVehicle(Vehicle vehicle)
        {

            Vehicles.Remove(vehicle);

            Console.WriteLine($"Fordon {vehicle.TypeOfVehicle()} "
                +$"med registreringsnumret {vehicle.Registeringsnummer}" +
                $"togs bort från listan");
        }

        public List<Vehicle> ShowVehicle()
        {

            return Vehicles;

        }

        













    }


    }

