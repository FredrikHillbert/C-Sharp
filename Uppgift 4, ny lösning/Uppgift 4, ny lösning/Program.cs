using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using Vehicles;

namespace Uppgift_4__ny_lösning
{
    class Program
    {
        static void Main(string[] args)
        {

            IVerkstad verkstad = new Verkstad();
            bool programIsRunning = true;



            while (programIsRunning)
            {


                MainMenu();
                int.TryParse(Console.ReadLine(), out int userInput);

                switch (userInput)
                {


                    case 1:
                        AddNewVehicles();

                        int.TryParse(Console.ReadLine(), out userInput);



                        Console.Clear();
                        bool addingVehicle = true;


                        while (addingVehicle)
                        {


                            switch (userInput)
                            {
                                case 1:
                                    var car = InputHelper.AddCar();
                                    verkstad.AddVehicle(car);
                                    addingVehicle = false;
                                    Console.WriteLine("En ny bil är tillagt, klicka på enter för att fortsätta");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    var bike = InputHelper.AddBike();
                                    verkstad.AddVehicle(bike);
                                    addingVehicle = false;
                                    Console.WriteLine("En ny motorcykel är tillagt, klicka på enter för att fortsätta");
                                    Console.ReadKey();
                                    break;

                                case 3:
                                    var truck = InputHelper.AddTruck();
                                    verkstad.AddVehicle(truck);
                                    addingVehicle = false;
                                    Console.WriteLine("En ny lastbil är tillagt, klicka på enter för att fortsätta");
                                    Console.ReadKey();
                                    break;

                                case 4:
                                    var bus = InputHelper.AddBus();
                                    verkstad.AddVehicle(bus);
                                    addingVehicle = false;
                                    Console.WriteLine("En ny buss är tillagt, klicka på enter för att fortsätta");
                                    Console.ReadKey();
                                    break;

                                case 5:
                                    addingVehicle = false;
                                    break;

                            }

                        }

                        break;







                    case 2:


                        //    // leta efter reg numret i showvehicles (listan) 

                        //    verkstad.DeleteVehicle()

                        Console.WriteLine("Skriv in regnumret på det fordon du vill ta bort");
                        var regNummerToMatch = Console.ReadLine();

                        Fordon fordonToRemove = null;

                        foreach (var fordon in verkstad.ShowVehicles())
                        {
                            if (regNummerToMatch == fordon.RegNummer)


                                fordonToRemove = fordon;


                        }
                        if (fordonToRemove != null)
                        {

                            verkstad.DeleteVehicle(fordonToRemove);
                            Console.WriteLine($"Ett fordon med regnumret {regNummerToMatch} har tagits bort");

                        }
                        else
                        {

                            Console.WriteLine($"Ett fordon med regnumret {regNummerToMatch} kunde inte hittas.");
                        }





                        break;

                    case 3:


                        Console.Clear();
                        foreach (var item in verkstad.ShowVehicles())

                        {

                            item.PrintOutVehicle();
                            Console.WriteLine("------------------");

                        }
                        break;


                    case 4:
                        programIsRunning = false;
                        break;













                }










            }
        }


        private static void MainMenu()
        {
            Console.WriteLine("\n Hej och välkommen till Fredriks verkstad!");
            Console.WriteLine();
            Console.WriteLine("1) Lägg till ett nytt fordon");
            Console.WriteLine("2) Ta bort ett befintligt fordon");
            Console.WriteLine("3) Se alla fordon i en lista");
            Console.WriteLine("4) Avsluta programmet");

        }



        private static void AddNewVehicles()
        {
            Console.Clear();
            Console.WriteLine("\n Vad är det för fordon du vill lägga till?");
            Console.WriteLine("1) Bil");
            Console.WriteLine("2) Motorcykel");
            Console.WriteLine("3) Lastbil");
            Console.WriteLine("4) Buss");
            Console.WriteLine("5) Gå tillbaka.");

        }



       


    }

}










   