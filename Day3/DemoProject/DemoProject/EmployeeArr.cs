using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class EmployeeArr
    {
        static void Main()
        {
            Employee emp1 = new Employee();
            emp1.empno = 101;
            emp1.name = "Raj";
            emp1.basic = 90000;

            Employee emp2 = new Employee();
            emp2.empno = 102;
            emp2.name = "Karthik";
            emp2.basic = 100000;

            Employee emp3 = new Employee();
            emp3.empno = 103;
            emp3.name = "Ganesh";
            emp3.basic = 80000;

            Employee[] employArray = new Employee[] { emp1, emp2, emp3 };
            foreach (Employee emp in employArray)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
