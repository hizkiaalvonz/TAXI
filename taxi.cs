using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taxi
{
    public class Taxi
    {
        public string driverName { get; set; }
        public bool onDuty { get; set; }
        public int NumPassenger { get; set; }
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name          : {0}", driverName);
            if (onDuty)
            {
                Console.WriteLine("On Duty              : Yes");
            }
            else
            {
                Console.WriteLine("On Duty              : No");
            }
            Console.WriteLine("Number of Passenger  : {0}", NumPassenger);
        }
        public void PickUpPassenger()
        {
            if (onDuty)
            {
                Console.WriteLine("Driver {0} is picking up passengers", driverName);
            }
            else
            {
                Console.WriteLine("Driver {0} not picking up passengers", driverName);
            }
        }
        public void DropOffPassenger()
        {
            if (onDuty)
            {
                Console.WriteLine("Driver {0} finished delivering passengers", driverName);
            }
            else
            {
                Console.WriteLine("Driver {0} ", driverName);
            }
        }
    }
}

