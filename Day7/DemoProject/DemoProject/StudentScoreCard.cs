using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class StudentScoreCard
    {
        public static void PrintStudentInfo(int sid, params Student[] students)
        {
            Console.WriteLine($"Student Id {sid} Total Marks {TotalMarks()}");

            foreach (Student student in students)
            {
                Console.WriteLine($"Student Name {student.StudentName} " +
                    $" Marks {student.Marks}");
            }

            double TotalMarks()
            {
                double total = 0;
                foreach (Student s in students)
                {
                    total += s.Marks;
                }
                return total;
            }
        }
        static void Main()
        {
            Student[] students = new Student[]
            {
                 new Student
            {
                StudentName="Sandeep",Marks=92.5
            },
            new Student
            {
                StudentName="Shiva",Marks=90.5
            },
            new Student
            {
                StudentName="Maharshi",Marks=80.5
            }

            };

            PrintStudentInfo(1, students);
        }
    }
}
