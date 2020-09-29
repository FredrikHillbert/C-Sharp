using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    class Buss : Vehicle
    {


        public int AntalPassagerare { get; private set; }

        public Buss (string vehicleType, string modellNamn, string registeringsnummer, int matare, string registeringsdatum, int antalPassagerare) : base(vehicleType, modellNamn, registeringsnummer, matare, registeringsdatum)
        {

            this.AntalPassagerare = antalPassagerare;

        }



        internal static void AddBuss()
        {






        }




    }
}
