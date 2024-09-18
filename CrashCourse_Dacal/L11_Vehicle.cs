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
        public static void L11_Inheritance()
        {
            Console.WriteLine("1\nWhat Do you want to add: Choose 1 or 2" +
                              "\n[1] Car" +
                              "\n[2] Truck");
            Console.Write("Choose :");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("\n\nFill the details below:");
                Console.Write("\nBrand              : ");
                string brand = Console.ReadLine();

                Console.Write("Model              : ");
                string model = Console.ReadLine();

                Console.Write("Year               : ");
                int year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Passenger Capacity : ");
                int pas = Convert.ToInt32(Console.ReadLine());
                L11b_Cars c = new L11b_Cars(brand, model, year, pas);
                c.DisplayInfo();
            }
            else if (choice == 2) 
            {
                Console.WriteLine("\n\nFill the details below:");
                Console.Write("\nBrand         : ");
                string brand = Console.ReadLine();

                Console.Write("Model         : ");
                string model = Console.ReadLine();

                Console.Write("Year          : ");
                int year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Load Capacity : ");
                int load = Convert.ToInt32(Console.ReadLine());
                L11c_Trucks t = new L11c_Trucks(brand, model, year, load);
                t.DisplayInfo();
            }
        }
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
