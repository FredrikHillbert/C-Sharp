using System;
using System.Runtime.InteropServices;

namespace Villkor_och_loopar
{

    /// <summary>
    
       
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            int startNummer, startTimme, startMinut, startSekund, malTimme, malMinut, malSekund;

            int sekundSummaStart, sekundSummaMal, sekundSumma;

            int NuvarandeLedare = int.MaxValue;

            int startNummerLedare = 0;


            int timmeStartLedare;
            int minutStartLedare;
            int sekundStartLedare;

            int timmeMålLedare;
            int minutMålLedare;
            int sekundMålLedare;


            bool maratonInmatning = true;


            int vinnadeTidTimmar=0;
            int vinnadeTidMinut=0;
            int vinnadeTidSek=0;
            //räknar vinnare


            int antalDeltagare = 0;
            //räknar deltagare

            


            while (maratonInmatning)
            {
                Console.Write("Ange startnummer: ");

                startNummer = int.Parse(Console.ReadLine());

                  if (startNummer < 1)
                {
                    maratonInmatning = false;

                    break;


                }

                Console.Write("Ange timme för start: ");

                startTimme = int.Parse(Console.ReadLine());

               


                Console.Write("Ange minut för start: ");

                startMinut = int.Parse(Console.ReadLine());

                Console.Write("Ange sekund för start: ");

                startSekund = int.Parse(Console.ReadLine());

                
                
                
                Console.Write("Ange timme för mål: ");

                malTimme = int.Parse(Console.ReadLine());


         




                Console.Write("Ange minut för mål: ");

                malMinut = int.Parse(Console.ReadLine());

                Console.Write("Ange sekund för mål: ");

                malSekund = int.Parse(Console.ReadLine());

                Console.Write("\tNär du har matat in alla tider skriver du in siffran '0' i 'Ange startnummer' för att gå vidare");

                Console.WriteLine();


                //uträkning om omvandling till sek 


                
                startTimme = startTimme * 3600;
                startMinut = startMinut * 60;

                malTimme = malTimme * 3600;
                malMinut = malMinut * 60;



                sekundSummaStart = (startTimme + startMinut + startSekund);
                sekundSummaMal = (malTimme + malMinut + malSekund);

                sekundSumma = sekundSummaMal - sekundSummaStart;



              





                //räkna ut vinnaren

                if (sekundSumma < NuvarandeLedare)
                {

                    NuvarandeLedare = sekundSumma;

                    startNummerLedare = startNummer;

                    timmeStartLedare = startTimme / 3600;
                    minutStartLedare = startMinut / 60;
                    sekundStartLedare = startSekund;
                    //omvandlar tillbaka startvärderna till timme min och sek

                    timmeMålLedare = malTimme / 3600;
                    minutMålLedare = malMinut / 60;
                    sekundMålLedare = malSekund;
                    //omvandlar tillbaka målvärderna till timme min och sek 



                    if (timmeMålLedare < timmeStartLedare)
                    {

                        

                        vinnadeTidTimmar = (23 + timmeMålLedare) - (timmeStartLedare);

                    }

                    else
                    {

                        vinnadeTidTimmar = timmeMålLedare - timmeStartLedare;

                    }
                   
                    if (minutMålLedare < minutStartLedare)
                    {

                        vinnadeTidMinut = (60 + minutMålLedare) - (minutStartLedare);
                    }


                    else
                    {

                        vinnadeTidMinut = minutMålLedare - minutStartLedare;


                    }


                    if (sekundMålLedare < sekundStartLedare)
                    {

                        vinnadeTidSek = (60 + sekundMålLedare) - (sekundStartLedare);
                    }

                    else
                    {

                        vinnadeTidSek = sekundMålLedare - sekundStartLedare;

                    }

                    



                }

                
                


       


                antalDeltagare++;


                



            }

            if (antalDeltagare == 0)
            {

                Console.WriteLine("Det var inga deltagare");
            }
            else
            {
                Console.WriteLine($"Antal deltagare i tävlingen var {antalDeltagare}, startnummer {startNummerLedare} vann med tiden {vinnadeTidTimmar}h {vinnadeTidMinut}m {vinnadeTidSek}s ");
            }


        }
    }
}
