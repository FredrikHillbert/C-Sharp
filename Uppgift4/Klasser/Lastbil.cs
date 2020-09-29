using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    class Lastbil : Vehicle
    {
        private int maxLast;

        public int GetMaxLast()
        {
            return maxLast;
        }

        public void SetMaxLast(int value)
        {
            maxLast = value;
        }

        public Lastbil (string vehicleType, string modellNamn, string registeringsnummer, int matare, string registeringsdatum, int maxLast) : base(vehicleType, modellNamn, registeringsnummer, matare, registeringsdatum)
        {

            this.SetMaxLast(maxLast);


        }



        internal static void AddLastbil()
        {






        }















    }
}
