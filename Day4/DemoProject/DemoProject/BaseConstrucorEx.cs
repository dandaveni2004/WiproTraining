using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class Employee
    {
        int empno;
        string name;
        double basic;
        public Employee(int empno, string name, double basic)
        {
            this.empno = empno;
            this.name = name;
            this.basic = basic;
        }
        public override string ToString()
        {
            return $"Employ No {empno} Employ Name {name} Basic {basic}";
        }
    }
    class Emp1 : Employee
    {
        public Emp1(int empno, string name, double basic) : base(empno, name, basic)
        {
        }
    }
    class Emp2 : Employee
    {
        public Emp2(int empno, string name, double basic) : base(empno, name, basic)
        {
        }
    }
    internal class BaseConstrucorEx
    {
        static void Main()
        {
            Employee[] emp = new Employee[]
        {
            new Emp1(101,"Ganesh",45000),
            new Emp2(102,"Karthik",50000)
        };
            foreach (Employee employee in emp)
            {
                Console.WriteLine(employee);
            }    
            
     }
   }
}
