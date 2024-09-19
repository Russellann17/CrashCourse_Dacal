using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_Dacal
{
    class Lesson18
    {
        public static async Task RunLaundryProcess()
        {
            Console.WriteLine("\nStarting the laundry process....");

            string[] clothesType = { "Whites", "Colors", "Delicate", "Towels" };
            int[] washingTime = { 10, 8, 7, 4 };

            await WashLaundryAsync(clothesType, washingTime);

            Console.WriteLine("All laundry loads are done!");

            Console.WriteLine("\n\nPlease click enter to exit");
            Console.ReadKey();
        }

        static async Task WashLoadAsync(string clothesType, int washingTime)
        {
            Console.WriteLine("Washing "+ clothesType + " for " +  washingTime + " seconds....");

            await Task.Delay(washingTime * 1000);

            Console.WriteLine(clothesType+" is done washing!");
        }

        static async Task WashLaundryAsync(string[] clothesType, int[] washingTime)
        {
            if (clothesType.Length != washingTime.Length)
            {
                throw new ArgumentException("The cloth types and washing time arrays must have the same length.");
            }

            Task[] washingTasks = new Task[clothesType.Length];

            for (int i = 0; i < clothesType.Length; i++)
            {
                washingTasks[i] = WashLoadAsync(clothesType[i], washingTime[i]);
            }

            await Task.WhenAll(washingTasks);
        }
    }
}
