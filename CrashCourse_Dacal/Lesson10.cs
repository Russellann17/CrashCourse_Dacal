using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_Dacal
{
    class Lesson10
    {
        public string carBrand;
        public string carModel;
        public int carYear;

        public Lesson10(string carBrand, string carModel, int carYear)
        {
            this.carBrand = carBrand;
            this.carModel = carModel;
            this.carYear = carYear;

            Console.WriteLine("\nMy vehicle is a " + carYear + " " + carBrand + " " + carModel +
                              ", showcasing both elegance and reliability.\n\n");
        }
    }
}
