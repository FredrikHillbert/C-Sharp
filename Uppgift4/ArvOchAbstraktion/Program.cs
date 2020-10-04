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


            Console.WriteLine("Hej och välkommen till verkstaden!");
            Console.WriteLine("Börja med och klicka enter...");
                

            Console.ReadLine();

  
                while (true)
                {
                

                    Console.WriteLine("1) Lägg till en nytt fordon");
                    Console.WriteLine("2) Ta bort ett existerande fordon");
                    Console.WriteLine("3) Visa alla fordon i en lista");
                    Console.WriteLine("4) Avsluta programmet");

                int.TryParse(Console.ReadLine(), out int userInputNum);



                    switch (userInputNum)
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
    
