using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_Dacal
{
    class Lesson9
    {
        public static void L9_functions()
        {
            int choice, num1, num2, numberOfInputs;
            float fnum1, fnum2;
            bool exit = true;

            while (exit)
            {
                Console.WriteLine("\n\n[1] Addition" +
                                  "\n[2] Subtraction" +
                                  "\n[3] Multiplication" +
                                  "\n[4] Division" +
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
                        Console.WriteLine("The Sum of all numbers is " + add(numbers) + ".\n\n");
                        break;
                    case 2: //Subtraction
                        Console.Write("1st Number: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("2nd Number: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("The difference of two numbers is " + subtract(num1, num2) + ".\n\n");
                        break;

                    case 3: //Multiplication
                        Console.Write("How many numbers do you want to multiply? ");
                        numberOfInputs = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter " + numberOfInputs + " numbers: ");
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
                }
            }
        }

            //Addition
            static int add(int[] numbers)
            {
                int sum = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                return sum;
            }
            //Subtraction
            static int subtract(int num1, int num2)
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
