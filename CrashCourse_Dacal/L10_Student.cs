using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_Dacal
{
    internal class L10_Student
    {
        public static void L10_ObjectMethods()
        {
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
        }

        public string firstName;
        public string lastName;
        public int year;
        public string course;
        public string section;
        public float midtermGrade;
        public float finalGrade;

        public L10_Student(string firstName, string lastName, int year, string course, string section, float midtermGrade, float finalGrade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.year = year;
            this.course = course;
            this.section = section;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
        }

        public void introduceSelf()
        {
            Console.WriteLine("\nSTUDENT INFORMATION:\n");
            Console.WriteLine("Name           : " + firstName + " " + lastName);
            Console.WriteLine("Course         : " + course);
            Console.WriteLine("Year & Section : " + year + " - " + section);
        }

        public void evaluateGrade()
        {
            float ave = (midtermGrade + finalGrade) / 2;
            Console.WriteLine("Average        : " + ave);

            if (ave > 100)       Console.WriteLine("\nINVALID GRADE!\n");
            else if (ave >= 98)  Console.WriteLine("\nCONGRATULATIONS! You are With Highest Honor.\n");
            else if (ave >= 95)  Console.WriteLine("\nCONGRATULATIONS! You are With High Honor.\n");
            else if (ave >= 90)  Console.WriteLine("\nCONGRATULATIONS! You are With Honor.\n");
            else if (ave >= 75)  Console.WriteLine("\nCONGRATULATIONS! You passed.\n");
            else                 Console.WriteLine("\nSorry but you failed.\n");
        }
    }
}
