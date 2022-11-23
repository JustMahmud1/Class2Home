using AccessM.Encapsulation;
using System;

namespace TupleRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercedes mercedes = new Mercedes("Mercedes", "C63S", 122145, 20, 5);
            mercedes.CurrentFuel();
            Console.WriteLine($"Bundan sonra {mercedes.HowFar()} km yol gede biler");
            mercedes.Service();

            BMW bmw = new BMW("BMW", "M5", 10000, 30, 5);
            Ferrari ferrari = new Ferrari("Ferrari", "458 Italia", 1000, 50, 5);

        }


        
    }
}
