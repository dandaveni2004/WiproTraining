using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class EmployeeMain
    {
        static void Main()
        {
            Employee emp1 = new Employee();
            emp1.empno = 101;
            emp1.name = "Rajuu";
            emp1.basic = 80000;

            Console.WriteLine(emp1);
        }
    }
}
