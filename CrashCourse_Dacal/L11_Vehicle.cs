using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CrashCourse_Dacal
{
    class L11_Vehicle
    {
        public string brand {  get; set; }
        public string model { get; set; }
        public int year { get; set; }

        public L11_Vehicle(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Brand : " +  brand + "\nModel : " + model + "\nYear  : " + year);
        }
    }
}
