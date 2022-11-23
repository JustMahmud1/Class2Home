using System;
using System.Collections.Generic;
using System.Text;

namespace AccessM.Encapsulation
{
    class Car
    { 
        public string Model { get; set; }
        public string Marka { get; set; }
        public int Kilometer { get; set; }
        public int CurrFuel { get; set; }
        public int FuelUsage { get; set; }

        public void CurrentFuel()
        {
            Console.WriteLine($"Hal hazirda {CurrFuel}L yanacaq var");
        }

        public int HowFar()
        {
            return CurrFuel * 100 / FuelUsage; ;
        }

        public void Service()
        {
            int HowManyTimes = Kilometer / 5000;
            int FromNow = 5000 - Kilometer % 5000;
            Console.WriteLine($"Indiye qeder {HowManyTimes} defe servisde olub. {FromNow} kilometrden sonra servise getmelidir");

        }

    }
}
