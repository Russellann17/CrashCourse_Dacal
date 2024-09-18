using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_Dacal
{
    class L11b_Cars : L11_Vehicle
    {
        public int PassengerCapacity { get; set; }
        public L11b_Cars(string brand, string model, int year, int passengerCapacity) : base(brand, model, year)
        {
            PassengerCapacity = passengerCapacity;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("\nCar Details");
            base.DisplayInfo();
            Console.WriteLine("Passenger Capacity: " + PassengerCapacity);
        }
    }
}
