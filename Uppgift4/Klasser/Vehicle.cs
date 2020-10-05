using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Klasser
{
    public class Vehicle
    {
        public static List<Vehicle> vehicles = new List<Vehicle>();
        
       
        public string ModellNamn { get; set; }
        public string Registeringsnummer { get; set; }
        public int Matare { get; set; }
        public string Registeringsdatum { get; set; }

        protected string _userInputFordon;
        

        public Vehicle(string vehicleType, string modellNamn, string registeringsnummer, int matare, string registeringsdatum)
        {
            this._userInputFordon = vehicleType;
            this.ModellNamn = modellNamn;
            this.Registeringsdatum = registeringsdatum;
            this.Registeringsnummer = registeringsnummer;
            this.Matare = matare;
           

        }

        public Vehicle()
        {
        }

        public  void DeleteSpecificVehicle()
        {



        }


       

        //public void AddVehicle()
        //{
        //    string userInputFordonType, userInputModelType, userInputRegnummer, userInputDate, userInputTowBar;
        //    int userInputMatare, userInputToppFart, userInputMaxLast, userInputAntalPass;
        //    bool haveTowBar = true;

        //    bool addingVehicle = true;
        //    while (addingVehicle)
        //    {

        //        Console.WriteLine($"Du har valt att lägga till en {_userInputFordon}, stämmer det j/n");
        //        userInputFordonType = Console.ReadLine();
        //        if (userInputFordonType.ToLower() == "n")
        //        {
        //            Console.WriteLine("Klicka enter för att gå tillbaka till första sidan");
        //            Console.ReadKey();
        //            break;


        //        }

        //        Console.WriteLine($"Vad är det för modell på din {_userInputFordon}: ");
        //        userInputModelType = Console.ReadLine();
        //        Console.WriteLine($"Vad har din {_userInputFordon} för registreringsnummer?: ");
        //        userInputRegnummer = Console.ReadLine();
        //        Console.WriteLine($"Vilket datum registerades din {_userInputFordon}");
        //        userInputDate = Console.ReadLine();
        //        Console.WriteLine($"Vad står milmätare på, på din {_userInputFordon}");
        //        int.TryParse(Console.ReadLine(), out userInputMatare);

        //        if (_userInputFordon == "bil")
        //        {

        //            Console.WriteLine("Har din bil en dragkrok? j/n");
        //            userInputTowBar = Console.ReadLine();
        //            if (userInputTowBar == "j")
        //            {



        //                haveTowBar = true;

        //                vehicles.Add(new Bil(_userInputFordon, userInputModelType, userInputRegnummer, userInputMatare, userInputDate, haveTowBar));

        //            }

        //            else if (userInputTowBar == "n")
        //            {

        //                haveTowBar = false;

        //                vehicles.Add(new Bil(_userInputFordon, userInputModelType, userInputRegnummer, userInputMatare, userInputDate, haveTowBar));


        //            }
        //        }





        //        if (_userInputFordon == "motorcykel")
        //        {

        //            Console.WriteLine("Vad har motorcykeln för topphastighet");
        //            int.TryParse(Console.ReadLine(), out userInputToppFart);
        //            vehicles.Add(new Motorcykel(_userInputFordon, userInputModelType, userInputRegnummer, userInputMatare, userInputDate, userInputToppFart));
        //        }

        //        if (_userInputFordon == "lastbil")
        //        {

        //            Console.WriteLine("Vad är maxlasten för lastbilen");
        //            int.TryParse(Console.ReadLine(), out userInputMaxLast);

        //            vehicles.Add(new Lastbil(_userInputFordon, userInputModelType, userInputRegnummer, userInputMatare, userInputDate, userInputMaxLast));

        //        }

        //        if (_userInputFordon == "buss")
        //        {
        //            Console.WriteLine("Hur många antal platser tar bussen");
        //            int.TryParse(Console.ReadLine(), out userInputAntalPass);

        //            vehicles.Add(new Buss(_userInputFordon, userInputModelType, userInputRegnummer, userInputMatare, userInputDate, userInputAntalPass));

        //        }


        //    }


           
            
















        //}



        public virtual void ShowVehicles()
        {



            Console.WriteLine($"Detta är en {_userInputFordon}");
            Console.WriteLine($"Den var registrerad {Registeringsdatum}");
            Console.WriteLine($"Den har registreringsnumret: {Registeringsnummer}");
            Console.WriteLine($"Milmätaren står på: {Matare}");


        }


        public string TypeOfVehicle()
        {

            return _userInputFordon;
        }


        










   
        
          








    }
}







//public  List<Vehicle> ShowVehicles()
//    {

//    foreach (var item in vehicles)
//        {


//         Console.WriteLine($"Detta är en {item.UserInputFordon}");

//        Console.WriteLine($"Fordonet är av modellen {item.ModellNamn}");

//        Console.WriteLine($"Milmätaren står på {item.Matare}");

//        Console.WriteLine($"Fordonet registrerades {item.Registeringsdatum}");

//        Console.WriteLine($"Fordonets registreringsnummer är: {item.Registeringsnummer}");


//            if (item.UserInputFordon == "bil")
//            {
//                Bil bil = new Bil(true);
//                if (bil.HaveTowBar)
//                {
//                    Console.WriteLine("Bilen har en dragkrok");
//                }





//            }




//                if (item.UserInputFordon == "motorcykel")
//                {
//                    Motorcykel motorcykel = new Motorcykel(maxFart:40);

//                    Console.WriteLine($"Topphastigheten för hojjen är: {motorcykel.MaxFart}");

//                }













//            //Testa att göra if här också för varje olika grejer du vill få fram 
//            //inom if satsen kan jag kalla Bil bil = new bil()


//            Console.WriteLine("\t----------------------");
//        }



//    return vehicles;

//}









