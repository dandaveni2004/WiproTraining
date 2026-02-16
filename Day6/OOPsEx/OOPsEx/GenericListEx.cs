using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsEx
{
    internal class GenericListEx
    {
        static void Main()
        {
            List<Employee> employs = new List<Employee>()
            {
                new Employee{Empno=101, Name="Manish",Basic=60000},
                new Employee{Empno=102, Name="Mani",Basic=70000},
                new Employee{Empno=103, Name="Karthik",Basic=80000},
                new Employee{Empno=104, Name="Nani",Basic=90000}
            };
            Console.WriteLine("Employ List Records Are  ");
            foreach (Employee employ in employs)
            {
                Console.WriteLine(employ);
            }
        }
    }
}
