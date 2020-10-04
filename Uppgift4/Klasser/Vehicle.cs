using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Klasser
{
    public class Vehicle
    {
        public List<Vehicle> vehicles = new List<Vehicle>();
       public string VehicleType { get; set; }
        public string ModellNamn { get; set; }
        public string Registeringsnummer { get; set; }
        public int Matare { get; set; }
        public string Registeringsdatum { get; set; }

        public string _userInputFordon;

        public Vehicle(string vehicleType, string modellNamn, string registeringsnummer, int matare, string registeringsdatum)
        {

            this.ModellNamn = modellNamn;
            this.Registeringsdatum = registeringsdatum;
            this.Registeringsnummer = registeringsnummer;
            this.Matare = matare;
           

        }

        public Vehicle()
        {


        }



        public static void DeleteSpecificVehicle()
        {



        }





        public static void ShowVehicles()
        {

            Bil.ShowCar();

            Buss.ShowBuss();

            Lastbil.ShowLastbil();

            Motorcykel.ShowMotorcykel();




        }



        public void AddSpecificVehicle()
        {
            Console.Clear();

            
            Console.WriteLine("Vad är det för fordon? ");
            Console.WriteLine("1) Bil");
            Console.WriteLine("2) Motorcykel");
            Console.WriteLine("3) Lastbil");
            Console.WriteLine("4) Buss");
            Console.WriteLine("5) Gå tillbaka till första sidan");

           
            int.TryParse(Console.ReadLine(), out int userInput);


            switch (userInput)
            {


                case 1:
                    _userInputFordon = "bil";
                    AddVehicle();

                    break;
                   
                case 2:
                    _userInputFordon = "motorcykel";
                    AddVehicle();

                    break;

                case 3:
                    _userInputFordon = "lastbil";
                    AddVehicle();

                    break;

                case 4:
                    _userInputFordon = "buss";
                    AddVehicle();

                    break;

                case 5:
                    break;

                 
            }





        }

        public void AddVehicle()
        {
            Console.WriteLine($"Du har valt att lägga till en {_userInputFordon}, stämmer det j/n");
            string userInputFordonType = Console.ReadLine();
            if (userInputFordonType.ToLower() == "n")
            {

                AddSpecificVehicle();

            }


             
            Console.WriteLine($"Vad är det för modell på din {_userInputFordon}: ");
            string userInputModelType = Console.ReadLine();


            // Gör så för alla vanliga frågor 

            // säg sedan if _userInputFordon och gör det specifika valen för det olika 

            // lägg sedan allt i en och samma lista vehicals och sedan skriv ut den :D 

            // Allt kan då vara i samma lista :DDDDDDD
            
















        }










        private static void AddCar()
        {

            List<Vehicle> vehicles = new List<Vehicle>();
            string userInputFordon, userInputModell, userInputRegnr, userInputDatum, userInputTowBarText = "";
            int userInputMatare;
            bool userInputTowbar = false;
            Console.WriteLine("Stämmer det att det är en bil du vill lägga til?");
            userInputFordon = Console.ReadLine();

            if (userInputFordon.ToLower() == "Ja")
            {

                userInputFordon = "Bil";
            }

            else if(userInputFordon.ToLower() == "nej")
            {

                //AddSpecificVehicle();
            }
            Console.Clear();
            Console.WriteLine("vad är det för modell på bilen?");
            userInputModell = Console.ReadLine();

            Console.WriteLine("vad är det för registeringsnummer på bilen?");
            userInputRegnr = Console.ReadLine();

            Console.WriteLine("vad står mätaren på bilen på i km?");
            userInputMatare = int.Parse(Console.ReadLine());

            Console.WriteLine("När registrerades bilen (datum)?");
            userInputDatum = Console.ReadLine();

            Console.WriteLine("Har bilen en dragkrok?");
            userInputTowBarText = Console.ReadLine();

            if (userInputTowBarText == "Ja")
            {

                userInputTowbar = true;


            }
            else
            {
                userInputTowbar = false;
            }

           

            vehicles.Add(new Bil(userInputFordon, userInputModell, userInputRegnr, userInputMatare, userInputDatum, userInputTowbar));


        }










    }
}
    








