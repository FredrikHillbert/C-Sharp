using System;
using System.ComponentModel;
using Klasser;
namespace ArvOchAbstraktion
{
    class Program
    {


        static void Main(string[] args)
        {
            IMyInterface verkstaden = new Verkstaden();
            bool programRunning = true;



            while (programRunning) {


                MainMeny(verkstaden);
                int.TryParse(Console.ReadLine(), out int userInputNum);


                switch (userInputNum)
                {

                    case 1:

                        bool userAddingVehicle = true;


                        while (userAddingVehicle)
                        {

                            AddSpecificVehicle();


                            int.TryParse(Console.ReadLine(), out int userInput);


                            switch (userInput)
                            {


                                case 1:

                                    var addCar = UserInput.AddCar();

                                    verkstaden.AddVehicle(addCar);

                                    Console.WriteLine("En bil är tillagd i verkstaden!");
                                    Console.WriteLine("Klicka på enter för att gå vidare.");
                                    Console.ReadKey();
                                   
                                    break;

                                case 2:

                                    //motorcykel


                                    break;

                                case 3:

                                    //lastbil

                                    break;

                                case 4:
                                    // buss

                                    break;

                                case 5:

                                    userAddingVehicle = false;
                                    break;


                            }
                        }
                            break;





                     
                case 2:
                        //verkstaden.DeleteVehicle();
                        break;



                case 3:

                        foreach (var item in verkstaden.ShowVehicle())
                        {

                            item.ShowVehicles();

                        }

                        Console.ReadKey();


                        break;


                    case 4:
                        Console.WriteLine("Avslutar programmet");
                        programRunning = false;
                        break;
                }


            }
        }
    
        private static void MainMeny(IMyInterface verkstaden)
        {

            Console.Clear();

                Console.WriteLine("Hej och välkommen till verkstaden!");

                Console.WriteLine("-----------");

                Console.WriteLine("1) Lägg till en nytt fordon");
                Console.WriteLine("2) Ta bort ett existerande fordon");
                Console.WriteLine("3) Visa alla fordon i en lista");
                Console.WriteLine("4) Avsluta programmet");





            
        }
        private static void AddSpecificVehicle()
        {
            Console.Clear();


            Console.WriteLine("Vad är det för fordon? ");
            Console.WriteLine("1) Bil");
            Console.WriteLine("2) Motorcykel");
            Console.WriteLine("3) Lastbil");
            Console.WriteLine("4) Buss");
            Console.WriteLine("5) Gå tillbaka till första sidan");








        }

    }

    

       
           



  














       




    }












        
    
