using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_Dacal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            bool exit = true;

            while (exit)
            { 
                Console.WriteLine("[1] Lesson 1 : Hello World" +
                                  "\n[2] Lesson 2 : Variables" +
                                  "\n[3] Lesson 3 : Input & Output" +
                                  "\n[4] Lesson 4 : Operators & Expressions" +
                                  "\n[5] Lesson 5 : Conditional Statements" +
                                  "\n[6] Lesson 6 : Switch Statements" +
                                  "\n[7] Lesson 7a: While Loop" +
                                  "\n[8] Lesson 7b: For Loop" +
                                  "\n[9] Lesson 8 : Arrays" +
                                  "\n[10] Lesson 9 : Functions" +
                                  "\n[11] Lesson 10a : Constructor" +
                                  "\n[12] Lesson 10b : Object Methods" +
                                  "\n[0] Exit");

                Console.Write("Choose: ");
                choice = Convert.ToInt32(Console.ReadLine());
                
                if (choice == 0)
                {
                    exit = false;
                    Console.WriteLine("Byeee, Thank you!");
                }

                switch (choice)
                {
                    case 1:
                        CrashCodeClasses.Functions.Lesson1();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        CrashCodeClasses.Functions.Lesson2();
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        CrashCodeClasses.Functions.Lesson3();
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        CrashCodeClasses.Functions.Lesson4();
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        CrashCodeClasses.Functions.Lesson5();
                        Console.WriteLine("\n");
                        break;
                    case 6:
                        CrashCodeClasses.Functions.Lesson6();
                        Console.WriteLine("\n");
                        break;
                    case 7:
                        CrashCodeClasses.Functions.Lesson7a();
                        Console.WriteLine("\n");
                        break;
                    case 8:
                        CrashCodeClasses.Functions.Lesson7b();
                        Console.WriteLine("\n");
                        break;
                    case 9:
                        CrashCodeClasses.Functions.Lesson8();
                        Console.WriteLine("\n");
                        break;
                    case 10:
                        Lesson9.L9_functions();
                        Console.WriteLine("\n");
                        break;
                    case 11:
                        Console.WriteLine("\n\nEnter the details of the car: ");
                        Console.Write("Brand : ");
                        string brand = Console.ReadLine();
                        Console.Write("Model : ");
                        string model = Console.ReadLine();
                        Console.Write("Year  : ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        
                        Lesson10 car = new Lesson10(brand,model,year);
                        break;
                    case 12:
                        Console.WriteLine("\n\nWelcome student! Please enter the fields below. ");
                        Console.Write("\nFirst Name     : ");
                        string firstName = Console.ReadLine();
                        Console.Write("Last Name      : ");
                        string lastName = Console.ReadLine();
                        Console.Write("Year           : ");
                        int yearlvl = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Course         : ");
                        string course = Console.ReadLine();
                        Console.Write("Section        : ");
                        string section = Console.ReadLine();
                        Console.Write("Midterm Grade  : ");
                        float midtermGrade = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Final Grade    : ");
                        float finalGrade = Convert.ToSingle(Console.ReadLine());
                  
                        L10_Student s = new L10_Student(firstName, lastName, yearlvl, course, section, midtermGrade, finalGrade);
                        s.introduceSelf();
                        s.evaluateGrade();
                        break;
                }
            }
        }
    }
}
