using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Emp
    {
        int empno;
        string name;
        double basic;

        public Emp()
        {
            empno = 102;
            name = "Nithin";
            basic = 80000;
        }

        public Emp(int empno, string name, double basic)
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
}
