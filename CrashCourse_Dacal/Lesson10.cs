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
        public static void L10_Constructor()
        {
            Console.WriteLine("\n\nEnter the details of the car: ");
            Console.Write("Brand : ");
            string brand = Console.ReadLine();
            Console.Write("Model : ");
            string model = Console.ReadLine();
            Console.Write("Year  : ");
            int year = Convert.ToInt32(Console.ReadLine());

            Lesson10 car = new Lesson10(brand, model, year);
        }

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
