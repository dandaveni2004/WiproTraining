using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    internal class EmpList1
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public double Sal { get; set; }

        public override string ToString()
        {
            return $"EMPNO:{Empno} Name:{Name} Sal:{Sal}";
        }
    }
}
