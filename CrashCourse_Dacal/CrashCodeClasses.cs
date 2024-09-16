using System;
using System.Collections.Specialized;
using System.Net.NetworkInformation;

namespace CrashCourse_Dacal
{
    internal class CrashCodeClasses
    {
        public static class Functions
        {
            public static void Lesson1()
            {
                Console.WriteLine("Hello World! Welcome to the universe.");
            }

            public static void Lesson2()
            {
                String name = "Russell Ann Dacal";
                int age = 24;

                Console.WriteLine("Hi! My name is " + name + ". I am " + age + " years old.");
            }

            public static void Lesson3()
            {
                string name, address;
                int age;

                Console.Write("Name    : ");
                name = Console.ReadLine();

                Console.Write("Address : ");
                address = Console.ReadLine();

                Console.Write("Age     : ");
                age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("I am " + name + ". I live in " + address + ". I am " 
                                   + age + " years old.");
            }

            public static void Lesson4()
            {
                int num1, num2, num3, sum, sub,prod, quotient;

                //Addition
                Console.Write("Enter the numbers you want to Add:\n");
                Console.Write("\n1st Number:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2nd Number:");
                num2 = Convert.ToInt32(Console.ReadLine());
                sum = num1 + num2;
                Console.WriteLine("The sum of the two numbers is " + sum);

                //Subtraction
                Console.WriteLine("\n\n\nEnter the numbers you want to Subtract:");
                Console.Write("\n1st Number:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2nd Number:");
                num2 = Convert.ToInt32(Console.ReadLine());
                sub = num1 - num2;
                Console.WriteLine("The difference of the two numbers is " + sub);

                //Multiplication
                Console.WriteLine("\n\n\nEnter the numbers you want to Multiply:");
                Console.Write("\n1st Number:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2nd Number:");
                num2 = Convert.ToInt32(Console.ReadLine());
                prod = num1 * num2;
                Console.WriteLine("The product of the two numbers is " + prod);

                //Division
                Console.WriteLine("\n\n\nEnter the numbers you want to Divide:");
                Console.Write("\n1st Number:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2nd Number:");
                num2 = Convert.ToInt32(Console.ReadLine());
                quotient = num1 / num2;
                Console.WriteLine("The quotient of the two numbers is " + quotient);
            }

            public static void Lesson5()
            {
                Console.Write("Input the Grades of each subject to know the average and its recognition.");
                Console.Write("\n\nEnglish  : ");
                float english = Convert.ToSingle(Console.ReadLine());

                Console.Write("Math     : ");
                float math = Convert.ToSingle(Console.ReadLine());

                Console.Write("Filipino : ");
                float filipino = Convert.ToSingle(Console.ReadLine());

                Console.Write("TLE      : ");
                float TLE = Convert.ToSingle(Console.ReadLine());

                float ave = (english + math + filipino + TLE) / 4;
                Console.WriteLine("\nAverage : " + ave);

                if (ave > 100)
                {
                    Console.WriteLine("Invalid Grade");
                }
                else if (ave >= 98)
                {
                    Console.WriteLine("With Highest Honors");
                }
                else if (ave >= 95)
                {
                    Console.WriteLine("With High Honors");
                }
                else if (ave >= 90)
                {
                    Console.WriteLine("With Honors");
                }
                else if (ave >= 75)
                {
                    Console.WriteLine("Passed");
                }
                else if (ave < 75)
                {
                    Console.WriteLine("You Failed!");
                }
            }

            public static void Lesson6()
            {
                int month, day, year;
                string monthvalue;

                Console.Write("Month : ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Day  : ");
                day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Year  : ");
                year = Convert.ToInt32(Console.ReadLine());
                
                switch (month)
                {
                    case 1:
                        monthvalue = "January";
                        break;
                    case 2:
                        monthvalue = "February ";
                        break;
                    case 3:
                        monthvalue = "March ";
                        break;
                    case 4:
                        monthvalue = "April ";
                        break;
                    case 5:
                        monthvalue = "May ";
                        break;
                    case 6:
                        monthvalue = "June ";
                        break;
                    case 7:
                        monthvalue = "July ";
                        break;
                    case 8:
                        monthvalue = "August ";
                        break;
                    case 9:
                        monthvalue = "September ";
                        break;
                    case 10:
                        monthvalue = "October ";
                        break;
                    case 11:
                        monthvalue = "November ";
                        break;
                    case 12:
                        monthvalue = "December ";
                        break;
                    default:
                        monthvalue = " ";
                        Console.WriteLine("Invalid Month");
                        break;
                    }

                if (day <= 31)
                {
                    if (monthvalue != " ")
                    {
                        Console.Write("\nYour birthday is " + monthvalue + day + ", " + year + "\n.");
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid day! Day is only up to 31.\n");
                }
               
                
            }

            public static void Lesson7a()
            {
                int lives = 3;
                string answer, correctAnswer = "sampaguita";
                
                while(lives > 0){
                    Console.WriteLine("Lives: " + lives);
                    Console.WriteLine("What is the national flower of the Philippines?");
                    Console.Write("Answer: ");
                    answer = Console.ReadLine();
                    Console.WriteLine();

                    if (answer.ToLower() == correctAnswer)
                    {
                        Console.WriteLine("That's Correct! \nCongratulations! You Won!");
                        break;
                    }
                    else  lives--; 
                    
                    if(lives == 0)
                        Console.WriteLine("Sorry, you lose.");
                }

               
            }

            public static void Lesson7b()
            {
                string[] firstname = { "Marian" , "Angel" , "Moshi", "Jackie", "Charo" };
                string[] lastname = { "Rivera", "Locsin", "Mosh", "Chan", "Santos"};
                string fname, lname;
                bool found = false;

                Console.Write("First Name : ");
                fname = Console.ReadLine();
                Console.Write("Last Name  : ");
                lname = Console.ReadLine();

                for (int i = 0; i < firstname.Length; i++)
                {
                    if (fname.Equals(firstname[i]) && lname.Equals(lastname[i]))
                    {
                        Console.WriteLine("\nHi, " + firstname[i] + " " + lastname[i] + "! Have a nice day.");
                        found = true;
                        break;
                    }
                } 
                
                if (!found)
                    Console.WriteLine("Person Not FoundCha.");
            }

            public static void Lesson8()
            {
                string[] name = { "Bruce Lee", 
                                  "Jackie Chan", 
                                  "Manny Pacquiao",
                                  "Carlos Yulo" };

                string[] profession = { "Martial Artist", 
                                        "Martial Artist/Actor", 
                                        "Professional Boxer", 
                                        "Gymnast" };

                int[] age = { 83, 70, 45, 24 };
                int i;

                Console.Write("Index: ");
                i = Convert.ToInt32(Console.ReadLine());
              
                    Console.WriteLine("Name       : " + name[i]);
                    Console.WriteLine("Profession : " + profession[i]);
                    Console.WriteLine("Age        : " + age[i] + " years old");
            }

            public static void Lesson9()
            {
                /*
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
                }*/
            }

        }
    }
}
