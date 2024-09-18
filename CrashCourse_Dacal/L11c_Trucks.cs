using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_Dacal
{
    class L11c_Trucks : L11_Vehicle
    {
        public float LoadCapacity { get; set; }

        public L11c_Trucks(string brand, string model, int year, float loadCapacity) : base(brand, model, year)
        {
            LoadCapacity = loadCapacity;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("\nTruck Details");
            base.DisplayInfo();
            Console.WriteLine("Load Capacity: " + LoadCapacity + "\n\n");
        }
    }
}
