using System;
using System.ComponentModel;
using Klasser;
namespace ArvOchAbstraktion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hej och välkommen till verkstaden, börja med att klicka på enter och välj sedan om du vill lägga till ett fordon eller ta bort ett existerande fordon");

            Console.ReadLine();


            IMyInterface verkstaden = new Verkstad();




            bool UserInputTrue = true;


            while (UserInputTrue)
            {


                Console.Clear();

                int userInput;

                Console.WriteLine("1) Välj att skapa ett nytt fordon");

                Console.WriteLine("2) Välj att ta bort ett befintligt fordon");

                Console.WriteLine("3) Välj att se alla existerande fordon i verkstaden");

                Console.WriteLine("4) Avsluta programmet");

                userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        verkstaden.AddVehicle();

                        break;

                    case 2:
                        verkstaden.DeleteVehicle();
                        break;
                    case 3:
                        verkstaden.ShowVehicle();

                        break;


                    case 4:

                        break;


                }



            }


            }












        }
    }

