using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class TupleEx1
    {
        static (int empno, string name, double basic) EmployInfo()
        {
            return (empno: 101, name: "Raj", basic: 90000);
        }
        static void Main()
        {
            var obj = EmployInfo();
            Console.WriteLine($"Employ No {obj.empno}");
            Console.WriteLine($"Employ Name {obj.name}");
            Console.WriteLine($"Basic {obj.basic}");
        }
    }
}
