using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsEx
{
    internal class EmploySortExample
    {
        static void Main()
        {
            List<Employee> employs = new List<Employee>()
            {
                new Employee{Empno=101, Name="Nani",Basic=90000},
                new Employee{Empno=102, Name="Prabhas",Basic=80000},
                new Employee{Empno=103, Name="Mahesh Babu",Basic=70000},
                new Employee{Empno=104, Name="Pavan Kalyan",Basic=80000},
                new Employee{Empno=105, Name="Nithin",Basic=90000},
                new Employee{Empno=106, Name="BhAAi",Basic=99999}
            };
            employs.Sort(new NameComparator());
            foreach (Employee employ in employs)
            {
                Console.WriteLine(employ);
            }
            Console.WriteLine("Sort By Salary-Wise  ");
            employs.Sort(new BasicComparator());
            foreach (Employee employ1 in employs)
            {
                Console.WriteLine(employ1);
            }
        }
    }
}
