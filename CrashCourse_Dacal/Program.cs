﻿using System;
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
                                  "\n[13] Lesson 11 : Inheritance" +
                                  "\n[14] Lesson 12 : Encapsulation " +
                                  "\n[15] Lesson 13 : Polymorphism " +
                                  "\n[16] Lesson 14 : Abstraction " +
                                  "\n[17] Lesson 15 : Exception Handling" +
                                  "\n[18] Lesson 16 : Arrays, List, Collections" +
                                  "\n[19] Lesson 17 : Events and Delegates" +
                                  "\n[20] Lesson 18 : Async, Await and Tasks" +
                                  "\n[21] Lesson 19 : Working With Strings" +
                                  "\n[22] Lesson 20 : Final Project+" +
                                  "\n[0] Exit");
            while (true)
            { 
                Console.Write("Choose a Lesson: ");
                choice = Convert.ToInt32(Console.ReadLine());

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
                        Lesson10.L10_Constructor();
                        Console.WriteLine("\n");
                        break;
                    case 12:
                        L10_Student.L10_ObjectMethods();
                        Console.WriteLine("\n");
                        break;
                    case 13:
                        L11_Vehicle.L11_Inheritance();
                        Console.WriteLine("\n");
                        break;
                    case 14:
                        L12_Bank.Lesson12();
                        Console.WriteLine("\n");
                        break;
                    case 15:
                        L13_Notification.L13_Polymorphism();
                        Console.WriteLine("\n");
                        break;
                    case 16:
                        Lesson14.L14_Payment();
                        Console.WriteLine("\n");
                        break;
                    case 17:
                        Lesson15.L15_AgeValidator();
                        Console.WriteLine("\n");
                        break;
                    case 18:
                        Lesson16.L16_ArrayListCollection();
                        Console.WriteLine("\n");
                        break;
                    case 19:
                        Lesson17.L17_TemperatureAlert();
                        Console.WriteLine("\n");
                        break;
                    case 20:
                        Lesson18.RunLaundryProcess();
                        Console.ReadKey();
                        Console.WriteLine("\n");
                        break;
                    case 21:
                        Lesson19.RunContact();
                        Console.WriteLine("\n");
                        break;
                    case 22:
                        Lesson20.L20_Recipe();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Choose from 1 to 21 only.");
                        break;
                }
            }
        }
    }
}
