using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Employ
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public double Sal { get; set; }
        public override string ToString()
        {
            return $"Employ No {Empno} Employ Name {Name} Salary {Sal}";
        }
    }
    internal class AutoProperty
    {
        static void Main()
        {
            Employ emp1 = new Employ();
            emp1.Empno = 201;
            emp1.Name = "Karthik";
            emp1.Sal = 90000;

            Employ emp2 = new Employ();
            emp2.Empno = 202;
            emp2.Name = "Nani";
            emp2.Sal = 85000;

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
        }
    }
}
