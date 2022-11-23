using System;
using System.Collections.Generic;
using System.Text;

namespace AccessM.Encapsulation
{
    class BMW : Car
    {
        public BMW(string model, string marka, int kilometer, int currentfuel , int fuelusage)
        {
            this.Model = model;
            this.Marka = marka;
            this.Kilometer = kilometer;
            this.CurrFuel = currentfuel;
            this.FuelUsage = fuelusage;
        }

    }
}
