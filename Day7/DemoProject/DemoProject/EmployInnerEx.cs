using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class EmployInnerEx
    {
        public static void PrintEmployInfo(params Employee[] employs)
        {
            Console.WriteLine("Employ Information ");
            foreach (Employee employ in employs)
            {
                Console.WriteLine("Employ No " + employ.Empno + " Employ Name " + employ.Name + " Employ Basic "
                    + employ.Basic + " Tax is  " + Tax(employ.Basic));
            }

            double TotalSalary()
            {
                double total = 0;
                foreach (Employee employ in employs)
                {
                    total += employ.Basic;
                }
                return total;

            }

            double Tax(double basic)
            {
                return basic * 0.10;
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Total Salary {TotalSalary()}");
        }
        static void Main()
        {
            Employee[] arrEmploy = new Employee[]
            {
                new Employee{Empno=1,Name="Aman",Basic=52334.44},
                new Employee{Empno=2,Name="Simha",Basic=88223},
                new Employee{Empno=3,Name="Yash",Basic=92234}
            };

            PrintEmployInfo(arrEmploy);
        }
    }
}
