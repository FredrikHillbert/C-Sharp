using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Klasser
{

    class Program
    {
        /// <summary>
        /// Se instruktionenr i Uppgift.txt
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Bil> bilar = new List<Bil>();
            bilar.Add(new Bil("BMW", "ABC 132", DateTime.Now, 1500, true));
            bilar.Add(new Bil("Audi", "DFC 456", DateTime.Now, 4300, false));
            bilar.Add(new Bil("Volvo", "NST 456", DateTime.Now, 2300, false));
            bilar.Add(new Bil("Tesla", "LOL 324", DateTime.Now, 1700, true));

            while (true)
            {

                foreach (var bilarna in bilar)
                {
                    Console.WriteLine($"Modellen: {bilarna.GetModell()}");
                    Console.WriteLine($"Registreringsnummer: {bilarna.GetRegnummer()}");
                    Console.WriteLine($"Registrerades: {bilarna.GetDate()}");
                    Console.WriteLine($"Vikt: {bilarna.GetVikt()}");
                     if (bilarna.GetElbil () == true)
                    {
                        Console.WriteLine("Detta är en Elbil");

                    }

                    Console.ReadLine();




                }











            }









        }


    }
}