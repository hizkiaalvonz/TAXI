using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();
            taxi.driverName = "Hizkia.Loelan";
            taxi.onDuty = true;
            taxi.NumPassenger = 20;

            taxi.TaxiInfo();
            Console.WriteLine("\n");
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();
            Console.ReadKey();
        }
    }
}