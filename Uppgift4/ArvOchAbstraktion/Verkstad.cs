using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Klasser;
namespace ArvOchAbstraktion
{
    class Verkstad : IMyInterface
    {
        
        // för att kunna nå mina vehicle klasser. 
        public Vehicle vehicle = new Vehicle(vehicleType: "",modellNamn: "", registeringsnummer: "", matare: 0, registeringsdatum: "");
        
        List<Vehicle> listOfVehicles = new List<Vehicle>();

        

        public void AddVehicle()
        {
            // här ska jag adda ett nytt fordon 
            string userInput;
            Console.WriteLine("Vad är det för fordon?");

            Console.WriteLine("Bil, Motorcykel, Lastbil eller Buss?");
            userInput = Console.ReadLine();

           
            if (userInput == "Bil")
            {
                // lägg till fordon Bil till listan
                listOfVehicles.Add(new Vehicle(vehicleType: userInput));
                
                // Kalla sedan en metod för att få ut resten av värdena.
                
                var anInstanceOfMyClass = new Vehicle();
                anInstanceOfMyClass.VehicleStats();

            }

            if (userInput == "Motorcykel")
            {

                //lägg till fordon Motorcykel till listan
                listOfVehicles.Add(new Vehicle(vehicleType: userInput));
                // Kalla sedan en metod för att få ut resten av värdena.
                var anInstanceOfMyClass = new Vehicle();
                anInstanceOfMyClass.VehicleStats();

            }

            if (userInput == "Lastbil")
            {
                //lägg till fordon Lastbil till listan
                listOfVehicles.Add(new Vehicle(vehicleType: userInput));
                // Kalla sedan en metod för att få ut resten av värdena.
                var anInstanceOfMyClass = new Vehicle();
                anInstanceOfMyClass.VehicleStats();

            }

            if (userInput == "Buss")
            {
                //lägg till fordon Buss till listan
                listOfVehicles.Add(new Vehicle(vehicleType: userInput));
                // Kalla sedan en metod för att få ut resten av värdena.

                var anInstanceOfMyClass = new Vehicle();
                anInstanceOfMyClass.VehicleStats();


            }




        }

        public void DeleteVehicle()
        {
            // här ska jag ta bort ett existernade fordon 
        }

        public void ShowVehicle()
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> ShowVehicleList()
        {

            // här ska jag visa existerande fordon

            foreach (var item in listOfVehicles)
            {
                Console.WriteLine($"Detta är en: {item.VehicleType}");
                Console.WriteLine($"Modellnamnet är: {item.ModellNamn}");
                Console.WriteLine($"Registreringsnumret är: {item.Registeringsnummer}");
                Console.WriteLine($"Registreringsdatumet är: {item.Registeringsdatum}");
                Console.WriteLine($"Kilometer mätaren står på: {item.Matare}");

                  if (item.VehicleType == "Motorcykel")
                {
                    Vehicle anInstaceOfMyClass = new Vehicle();
                    Console.WriteLine($"Det här är hojjens maxhastighet: {item.MaxFart}");

                    return (List<Vehicle>)item.MaxFart;
                }


               else if (item.VehicleType == "Bil")
                {
                    Vehicle anInstaceOfMyClass = new Vehicle();
                    Console.WriteLine($"Det finns en dragkrok på bilen: {item.TowBar}");

                    return (List<Vehicle>)item.TowBar;

                }

                  
                else if (item.VehicleType == "Lastbil")
                {
                    Vehicle anInstaceOfMyClass = new Vehicle();
                    Console.WriteLine($"maxlastet för lastbilen är: {item.MaxLast}");

                    return (List<Vehicle>)item.MaxLast;

                }

                else if (item.VehicleType == "Buss")
                {
                    Vehicle anInstaceOfMyClass = new Vehicle();
                    Console.WriteLine($"antal passagerare som får plats är: {item.antalPassagerare}");
                    return (List<Vehicle>)item.antalPassagerare;
                    

                }

                return listOfVehicles;

            }

        }

        
    }
}
