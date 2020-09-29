using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    class Motorcykel : Vehicle
    {
        private int maxFart;

        public Motorcykel(string vehicleType, string modellNamn, string registeringsnummer, int matare, string registeringsdatum, int maxFart) : base(vehicleType, modellNamn, registeringsnummer, matare, registeringsdatum)
        {

            this.SetMaxFart(maxFart);

        }


        public int GetMaxFart()
        {
            return maxFart;
        }

        public void SetMaxFart(int value)
        {
            maxFart = value;
        }


        internal static void AddMotorcykel()
        {






        }















    }
}
