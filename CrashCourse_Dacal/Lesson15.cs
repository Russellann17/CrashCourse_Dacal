using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_Dacal
{
    class Lesson15
    {
        public static void L15_AgeValidator()
        {
            Console.WriteLine("Simple Age Validator");

            try
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 0 || age > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 100. \n\n");
                }
                Console.WriteLine("You are " + age + " years old.");
            } 
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid numeric age.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
           
        }
    }
}
