using Klasser;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    class UserInput
    {

        private static string CreateName(string whatToType)
        {

            string name;

            bool creatingName = true;

            do
            {

                Console.WriteLine(whatToType);
                name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {

                    Console.WriteLine("Du måste skriva något");
                }

                else
                    creatingName = false;


            } while (creatingName);

            return name;


        }


        private static string CreateLicensePlate(string whatToWrite)
        {
            string licenseplate;
            bool creatingLicensePlate = true;

            do
            {
                Console.WriteLine(whatToWrite);
                licenseplate = Console.ReadLine().ToUpper();

                if (string.IsNullOrEmpty(licenseplate))
                {

                    Console.WriteLine("Du måste skriva in något");
                }


                else
                    creatingLicensePlate = false;



            } while (creatingLicensePlate);


            return licenseplate;



        }

        

        private static bool ReadBoolean(string whatToTurnTrueOrFalse)
        {
            
            bool isTrue = true;
            bool settingBool = true;

            do
            {
                Console.WriteLine(whatToTurnTrueOrFalse);

                string userInput = Console.ReadLine().ToLower();

                if (string.IsNullOrEmpty(userInput)) 
                {

                    Console.WriteLine("Du måste skriva något");
                }




                else
                {
                    isTrue = (userInput == "j");
                    settingBool = false;
                }


            } while (settingBool);

            return isTrue;

         

        }



        private static int ReadInt (string whatToWrite)
        {
            int userValue = 0;
            bool settingInt = true;

            do
            {

                Console.WriteLine(whatToWrite);

                if (!int.TryParse(Console.ReadLine(), out userValue))
                {

                    Console.WriteLine("Du måste skriva in ett heltal");
                }

                else if (userValue < 0)
                {

                    Console.WriteLine("Du måste skriva in ett tal som är större eller lika med noll");
                }

                else
                {

                    settingInt = false;
                }




            } while (settingInt);


            return userValue;


        }


        public static Vehicle AddCar()
        {
            var bil = new Bil();
            bool isAddingNewCar = true;

            while (isAddingNewCar)
            {

                Console.Clear();



                bil.ModellNamn = CreateName("Skriv in modellnamnet");
                bil.Registeringsnummer = CreateLicensePlate("Skriv in registreringsnummer");
                bil.Registeringsdatum = DateTime.Now.ToString("yyyy/MM/dd");
                bil.HaveTowBar = ReadBoolean("Har bilen en dragkrok j/n?");
                bil.Matare = ReadInt("Hur långt har bilen gått i km?");

                bil.ShowVehicles();

                bool userAnswer = true;

                do
                {

                    Console.WriteLine("\n Stämmer dessa uppgifter? j/n");
                    string userInput = Console.ReadLine().ToLower();
                    if (userInput == "j")
                    {

                        isAddingNewCar = false;
                        userAnswer = false;
                        break;


                    }

                    else if (string.IsNullOrEmpty(userInput))

                    {
                        Console.WriteLine("Du måste svara på frågan");
                    }

                    
                    



                } while (userAnswer);
            }

            return bil;

        }




        public static Vehicle AddMotorcykel()
        {
            var motorcykel = new Motorcykel();
            bool isAddingBike = true;


            while (isAddingBike)
            {
                Console.Clear();


                motorcykel.ModellNamn = CreateName("Skriv in modellnamn:");
                motorcykel.Registeringsdatum = DateTime.Now.ToString("yyyy/MM/dd");
                motorcykel.Registeringsnummer = CreateLicensePlate("Skriv in regnummer");
                motorcykel.Matare = ReadInt("Vad står milmätaren på i KM");
                motorcykel.MaxFart = ReadInt("Vad är maxfarten för hojjen?");


                motorcykel.ShowVehicles();

               

                bool userAnswer = true;

                do
                {

                    Console.WriteLine("Stämmer dessa uppgifter? j/n ");
                    string userInput = Console.ReadLine();

                    if (userInput.ToLower() == "j")
                    {

                        isAddingBike = false;
                        userAnswer = false;
                        break;


                    }

                    else if (userInput.ToLower() == "n")
                    {

                        
                        Console.WriteLine("Du valde att detta var fel info, testa att lägga till motorcykeln igen, du behöver inte lägga till alla andra.");
                        isAddingBike = false;
                        userAnswer = false;
                        Vehicle.Clear();

                        
                        break;
                    }


                    else if (string.IsNullOrEmpty(userInput))
                    {
                        Console.WriteLine("Du måste antingen skriva 'j' eller 'n'");
                    }


                } while (userAnswer);

            }
            return motorcykel;






        }















    }
}
