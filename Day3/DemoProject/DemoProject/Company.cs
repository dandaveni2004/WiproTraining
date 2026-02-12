using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Company
    {
        static double total_salary;

        public void PaySalary(double salary)
        {
            total_salary += salary;
        }

        static void Main()
        {
            Company objGanesh = new Company();
            Company objYash = new Company();
            Company objKishore = new Company();
            Company objTushar = new Company();

            objGanesh.PaySalary(1000);
            objYash.PaySalary(4000);
            objKishore.PaySalary(3000);
            objTushar.PaySalary(2000);

            Console.WriteLine($"Total Salary is {total_salary}");
        }
    }
}
