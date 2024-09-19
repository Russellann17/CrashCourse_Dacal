using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourse_Dacal
{
    internal class Lesson16
    {
        public static void L16_ArrayListCollection()
        {
            Lesson16 L16 = new Lesson16();
            L16.Student();

        }

        public void Student() 
        { 
            string[] students = new string[3];

            var grades = new List<int>[3];

            for (int i = 0; i < students.Length; i++) 
            {
                Console.Write("Name of Student " + i + ": ");
                students[i] = Console.ReadLine();

                grades[i] = new List<int>();
                Console.Write("Enter the grades of student " + students[i] + " (type -1 to stop):");
                
                while (true)
                {
                    Console.Write("Enter a grade: ");
                    int grade = Convert.ToInt32(Console.ReadLine());

                    if (grade == -1) break;
                    grades[i].Add(grade);
                }
            }

            Console.WriteLine("\nThe Average Grades of the students: ");
            for (int i = 0; i < students.Length; i++)
            {
                float average = CalculateAverage(grades[i]);
                Console.WriteLine(students[i] + "'s Average Grade:" + average);
            }
        }

        public float CalculateAverage(List<int>grade)
        {
            if(grade.Count == 0) return 0.0f;

            float sum = 0;
            foreach (var grades in grade)
            {
                sum += grades;
            }
            return sum / grade.Count;
        }
    }
}
