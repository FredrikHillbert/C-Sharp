using System;
using System.ComponentModel;
using Klasser;
namespace ArvOchAbstraktion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hej och välkommen till verkstaden " +
                "börja med att klicka på enter och välj sedan om du vill lägga till ett fordon eller ta bort ett existerande fordon");

            Console.ReadLine();


            IMyInterface verkstaden = new Verkstad();


         

            while (true)
            {
                int userInput;

                Console.WriteLine("1) Lägg till en nytt fordon");
                Console.WriteLine("2) Ta bort ett existerande fordon");
                userInput = int.Parse(Console.ReadLine());





                switch (userInput)
                {

                    case 1:
                        Vehicle.AddSpecificVehicle();
                        break;

                    case 2:
                        Vehicle.DeleteSpecificVehicle();
                        break;

                }











            }















            }












        }
    }

