using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Klasser
{
    public class Bil : Vehicle
    {


        public bool HaveTowBar { get; set; }

   
        public Bil()
        {
            _userInputFordon = "Bil";
        }

        public override void ShowVehicles()
        {
            base.ShowVehicles();

            if (HaveTowBar)
            {

                Console.WriteLine("Bilen har en dragkrok");
            }
            else
            {
                Console.WriteLine("Bilen har inte en dragkrok");
            }




        }





















        public static List<Bil> bilar = new List<Bil>();
        internal static List<Bil> ShowCar()
        {


           

                foreach (var item in bilar)
                {
                
                    Console.WriteLine($"Detta är en bil");

                    Console.WriteLine($"Fordonet är av modellen {item.ModellNamn}");

                    Console.WriteLine($"Milmätaren står på {item.Matare}");

                    Console.WriteLine($"Fordonet registrerades {item.Registeringsdatum}");

                    Console.WriteLine($"Fordonets registreringsnummer är: {item.Registeringsnummer}");

                if (item.HaveTowBar == true)
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









      



        


    

