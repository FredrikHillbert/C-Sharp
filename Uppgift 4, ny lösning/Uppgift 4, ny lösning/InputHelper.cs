using System;
using System.Collections.Generic;
using System.Text;
using Vehicles;

namespace Uppgift_4__ny_lösning
{
    class InputHelper
    {

        private static string ReadString(string userInput)
        {
            string name;

            bool isAddingName = true;

            do
            {

                Console.WriteLine(userInput);
                name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {

                    Console.WriteLine("Skriv in ett svar");
                }

                else
                {
                    isAddingName = false;
                    break;

                }




            } while (isAddingName);


            return name;

        }

        private static int ReadInt(string userInput)
        {

            int userInt;
            bool isAdding = true;

            do
            {

                Console.WriteLine(userInput);
            


                if(!int.TryParse(Console.ReadLine(), out userInt))
                {

                    Console.WriteLine("Du måste skriva in ett tal.");

                }

                else
                {
                    isAdding = false;
                    break;

                }








            } while (isAdding);

            return userInt;





        }

        private static bool ReadBoolean(string userInput)
        {

            bool isTrueOrFalse = true;
            bool isAdding = true;

            do
            {

                Console.WriteLine(userInput);
                string userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == "n")
                {
                    isTrueOrFalse = false;
                    isAdding = false;
                    break;
                    
                }

                else if (userAnswer.ToLower() == "j")
                {
                    isTrueOrFalse = true;
                    isAdding = false;
                    break;


                }

                else
                {

                    Console.WriteLine("Du måste skriva in antingen 'j' eller 'n'");
                }

            } while (isAdding);


            return isTrueOrFalse;
        }



        public static Fordon AddCar()
        {
            var car = new Car();
            Console.Clear();
            car._typeOfVehicle = "Bil";
            car.ModellNamn = ReadString("Skriv in modellnamnet");
            car.RegNummer = ReadString("Skriv in Regnumret");
            car.RegTime = DateTime.Now;
            car.Matare = ReadInt("Vad står milmätaren på i KM?");
            car.HaveTowBar = ReadBoolean("Har bilen en dragkrok?");


            car.PrintOutVehicle();

            bool valueIsTrue = false;

            do
            {

                Console.WriteLine("Stämmer dessa uppgifter? j/n");
                string userInput = Console.ReadLine();

                if(userInput.ToLower() == "j")
                {

                    valueIsTrue = true;
                    break;

                    
                    

                }

                else if (userInput.ToLower() == "n")
                {

                    AddCar();
                    
                }

                else
                {
                    Console.WriteLine("Du måste svara antingen 'j' eller 'n'");
                }




            } while (!valueIsTrue);



            return car;
        }


        public static Fordon AddBike()
        {
            var bike = new Bike();

            bike._typeOfVehicle = "Motorcykel";
            bike.ModellNamn = ReadString("Skriv in modellnamnet");
            bike.RegNummer = ReadString("Skriv in Regnumret");
            bike.RegTime = DateTime.Now;
            bike.Matare = ReadInt("Vad står milmätaren på i KM?");
            bike.MaxFart = ReadInt("Vad är topphastigheten för motorcykeln?");

            bike.PrintOutVehicle();

            bool valueIsTrue = false;

           
            do
            {
                Console.WriteLine("Stämmer dessa uppgifter? j/n");
                string userInput = Console.ReadLine();



                if (userInput.ToLower() == "j")
                {

                    valueIsTrue = true;
                    break;




                }

                else if (userInput.ToLower() == "n")
                {

                    AddBike();

                }

                else
                {
                    Console.WriteLine("Du måste svara antingen 'j' eller 'n'");
                }
            } while (!valueIsTrue);

            return bike;
        }


        public static Fordon AddBus()
        {
            var bus = new Bus();

            Console.Clear();

            bus._typeOfVehicle = "Bus";
            bus.ModellNamn = ReadString("Skriv in modellnamnet");
            bus.RegNummer = ReadString("Skriv in Regnumret");
            bus.RegTime = DateTime.Now;
            bus.Matare = ReadInt("Vad står milmätaren på i KM?");
            bus.AntalPassagare = ReadInt("Hur många passagerare får det plats?");


            bus.PrintOutVehicle();

            bool valueIsTrue = false;

            do
            {
                Console.WriteLine("Stämmer dessa uppgifter? j/n");
                string userInput = Console.ReadLine();



                if (userInput.ToLower() == "j")
                {

                    valueIsTrue = true;
                    break;
                }

                else if (userInput.ToLower() == "n")
                {

                    AddBus();

                }

                else
                {
                    Console.WriteLine("Du måste svara antingen 'j' eller 'n'");
                }

            }while(!valueIsTrue);

            return bus;
        }

        public static Fordon AddTruck()
        {
            var truck = new Truck();
            truck._typeOfVehicle = "Motorcykel";
            truck.ModellNamn = ReadString("Skriv in modellnamnet");
            truck.RegNummer = ReadString("Skriv in Regnumret");
            truck.RegTime = DateTime.Now;
            truck.Matare = ReadInt("Vad står milmätaren på i KM?");
            truck.MaxLast = ReadInt("Vad är maxlastet för lastbilen?");

            truck.PrintOutVehicle();

            bool valueIsTrue = false;

            do
            {
                Console.WriteLine("Stämmer dessa uppgifter? j/n");
                string userInput = Console.ReadLine();



                if (userInput.ToLower() == "j")
                {

                    valueIsTrue = true;
                    break;
                }

                else if (userInput.ToLower() == "n")
                {

                    AddTruck();

                }

                else
                {
                    Console.WriteLine("Du måste svara antingen 'j' eller 'n'");
                }

            } while (!valueIsTrue);


            return truck;

        }


     
        

        





    }
}
