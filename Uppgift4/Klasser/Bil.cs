using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Klasser
{
    public class Bil : Vehicle
    {




        public Bil(string vehicleType, string modellNamn, string registeringsnummer, int matare, string registeringsdatum, bool towbar) : base(vehicleType, modellNamn, registeringsnummer, matare, registeringsdatum)
        {

            _haveTowBar = towbar;

        }

       public static List<Bil> bilar = new List<Bil>();






        internal static void AddCar()
        {
            string userInputFordon, userInputModell, userInputRegnr, userInputDatum, userInputTowBarText = "";
            int userInputMatare;
            bool userInputTowbar = false;
            Console.WriteLine("Stämmer det att det är en bil du vill lägga til?");
            userInputFordon = Console.ReadLine();

                if (userInputFordon == "Ja")
            {

                userInputFordon = "Bil";
            }

                else
            {

                //gå tillbaka
            }

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

            if (userInputTowBarText =="Ja")
            {

                userInputTowbar = true;


            }
            else
            {
                userInputTowbar = false;
            }

            

            bilar.Add(new Bil(userInputFordon, userInputModell, userInputRegnr, userInputMatare, userInputDatum, userInputTowbar ));
            

        }

        

        internal static List<Bil> ShowCar()
        {


           

                foreach (var item in bilar)
                {
                
                    Console.WriteLine($"Detta är en bil");

                    Console.WriteLine($"Fordonet är av modellen {item.ModellNamn}");

                    Console.WriteLine($"Milmätaren står på {item.Matare}");

                    Console.WriteLine($"Fordonet registrerades {item.Registeringsdatum}");

                    Console.WriteLine($"Fordonets registreringsnummer är: {item.Registeringsnummer}");

                if (item._haveTowBar == true)
                {
                    Console.WriteLine("Bilen har en dragkrok");

                }             

                else
                {
                    Console.WriteLine("Bilen har inte en dragkrok");
                }

                }

            Console.WriteLine("\t----------------------");


                return bilar;


            }


        }




        }









      



        


    

