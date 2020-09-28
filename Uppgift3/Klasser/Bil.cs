using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    class Bil
    {

        private string Modell;
        private string Regnummer;
        private DateTime Reggades;
        private int Vikt;
        private bool Elbil;




        public Bil (string Modell, string Regnummer, DateTime Reggades, int Vikt, bool Elbil)
        {

            this.Modell = Modell;
            this.Regnummer = Regnummer;
            this.Reggades = Reggades;
            this.Vikt = Vikt;
            this.Elbil = Elbil;



        }

        public string GetModell()
        {
            return Modell;

        }

        public void SetModell(string Modell)
        {

            this.Modell = Modell;

        }

        public string GetRegnummer()
        {
            return Regnummer;

        }

        public void SetRegnummer(string Regnummer)
        {

            this.Regnummer = Regnummer;
        }

        public int GetVikt()
        {
            return Vikt;

        }

        public void SetVikt (int Vikt)
        {

            this.Vikt = Vikt;

        }

        public DateTime GetDate()
        {

            return Reggades;
        }

        public void SetDate(DateTime Reggades)
        {

            this.Reggades = Reggades;
        }

        public bool GetElbil()
        {

            return Elbil;
        }

        public void SetElbil (bool Elbil)
        {

            this.Elbil = Elbil;
        }


    }
}
