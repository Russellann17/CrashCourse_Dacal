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
            int choice, num1, num2, numberOfInputs;
            float fnum1, fnum2;
            bool exit = true;

            while (exit)
            { 
                Console.WriteLine("[1] Addition" +
                              "\n[2] Subtraction" +
                              "\n[3] Multiplication" +
                              "\n[4] Division" +
                              "\n[5] Lesson 1 : Hello World" +
                              "\n[6] Lesson 2 : Variables" +
                              "\n[7] Lesson 3 : Input & Output" +
                              "\n[8] Lesson 4 : Operators & Expressions" +
                              "\n[9] Lesson 5 : Conditional Statements" +
                              "\n[10] Lesson 6 : Switch Statements" +
                              "\n[11] Lesson 7a: While Loop" +
                              "\n[12] Lesson 7b: For Loop" +
                              "\n[13] Lesson 8 : Arrays" +
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
                    case 1: //Addition
                        Console.Write("How many numbers do you want to add? ");
                        numberOfInputs = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter " + numberOfInputs + " numbers: ");
                        
                        int[] numbers = new int[numberOfInputs];
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("The Sum of all numbers is" + add(numbers) + ".\n\n");
                        break;

                    case 2: //Subtraction
                        Console.Write("1st Number: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("2nd Number: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("The difference of two numbers is "+ subtract(num1, num2) + ".\n\n");
                        break;

                    case 3: //Multiplication
                        Console.Write("How many numbers do you want to multiply? ");
                        numberOfInputs = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter "+ numberOfInputs +" numbers: ");
                        int[] number = new int[numberOfInputs];
                        for (int i = 0; i < number.Length; i++)
                        {

                            number[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("The product of all numbers is " + multiply(number) + ".\n\n");
                        break;

                    case 4: //Division
                        Console.Write("1st Number: ");
                        fnum1 = Convert.ToSingle(Console.ReadLine());
                        Console.Write("2nd Number: ");
                        fnum2 = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("The quotient of two numbers is " + divide(fnum1, fnum2) + ".\n\n");
                        break;
                    case 5:
                        CrashCodeClasses.Functions.Lesson1();
                        Console.WriteLine("\n");
                        break;
                    case 6:
                        CrashCodeClasses.Functions.Lesson2();
                        Console.WriteLine("\n");
                        break;
                    case 7:
                        CrashCodeClasses.Functions.Lesson3();
                        Console.WriteLine("\n");
                        break;
                    case 8:
                        CrashCodeClasses.Functions.Lesson4();
                        Console.WriteLine("\n");
                        break;
                    case 9:
                        CrashCodeClasses.Functions.Lesson5();
                        Console.WriteLine("\n");
                        break;
                    case 10:
                        CrashCodeClasses.Functions.Lesson6();
                        Console.WriteLine("\n");
                        break;
                    case 11:
                        CrashCodeClasses.Functions.Lesson7a();
                        Console.WriteLine("\n");
                        break;
                    case 12:
                        CrashCodeClasses.Functions.Lesson7b();
                        Console.WriteLine("\n");
                        break;
                    case 13:
                        CrashCodeClasses.Functions.Lesson8();
                        Console.WriteLine("\n");
                        break;
                }
            }
        }

        //Addition
        static int add(int[] numbers)
        {
            int sum = 0;

            for(int i = 0; i< numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        //Subtraction
        static int subtract(int num1, int num2 )
        {
            return (num1 - num2);
        }

        //Multiplication
        static int multiply(int[] number) 
        {
            int product = 1;

            for (int i = 0; i < number.Length; i++)
            {
                product *= number[i];
            }
            return product;
        }

        //Division
        static float divide(float num1, float num2) 
        {
            return num1 / num2;
        }

    }
}
