using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class EmployeeInfo
    {
        static double TotalSalary(params Employee[] employs)
        {
            double total = 0;
            foreach (Employee employ in employs)
            {
                total += employ.Basic;
            }
            return total;
        }

        public static void PrintEmployInfo(params Employee[] employs)
        {
            Console.WriteLine("Employ Information ");
            foreach (Employee employ in employs)
            {
                Console.WriteLine("Employ No " + employ.Empno + " Employ Name " + employ.Name + " Employ Basic " + employ.Basic);
            }
        }
        static void Main()
        {
            Employee[] arrEmploy = new Employee[]
           {
                new Employee{Empno=101,Name="Ganesh",Basic=60000},
                new Employee{Empno=102,Name="Karthik",Basic=70000},
                new Employee{Empno=103,Name="Raju",Basic=80000}
           };

            PrintEmployInfo(arrEmploy);
            Console.WriteLine("Total Salary Paid to All Employs  " + TotalSalary(arrEmploy));
        }
    }
}
