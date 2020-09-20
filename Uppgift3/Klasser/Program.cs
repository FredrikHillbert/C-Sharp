using System;

namespace Klasser
{


    public class Bil
    {

        public int hej { get; set; }
        public string registreringsnummer;
        public DateTime registrerades = DateTime.Now;
        public bool elbil;
        public int vikt;
        public string name;


        public void MetodBil ()
        {

            Console.Write($"Model: {name}");
            Console.WriteLine();
            Console.Write($"Vikt: {vikt}");
            Console.WriteLine();
            Console.Write($"Registrerades: {registrerades}");
            Console.WriteLine();
            Console.Write($"Registreringsnummer: {registreringsnummer}");
            Console.WriteLine();
              if (elbil == true)
            {

                Console.Write("Detta är en dessutom en Elbil");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Klicka på Enter för att se nästa bil");
            Console.WriteLine();
            Console.ReadLine();
            


        }

        


            


    }





    class Program
    {
        /// <summary>
        /// Se instruktionenr i Uppgift.txt
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Bil volvo = new Bil();

            volvo.name = "Volvo";
            volvo.vikt = 140;
            volvo.registreringsnummer = "ABC 123";
            volvo.registrerades = DateTime.Now;
            volvo.elbil = false;

            Bil audi = new Bil();

            audi.name = "Audi";
            audi.vikt = 160;
            audi.registreringsnummer = "BCD 342";
            audi.registrerades = DateTime.Now;
            audi.elbil = true;

            Bil bmw = new Bil();

            bmw.name = "BMW";
            bmw.vikt = 180;
            bmw.registreringsnummer = "ABC 321";
            bmw.registrerades = DateTime.Now;
            bmw.elbil = true;



            while (true)
            {
                volvo.MetodBil();

             
                audi.MetodBil();


                bmw.MetodBil();

                

            }
        }
    }

    
    
}