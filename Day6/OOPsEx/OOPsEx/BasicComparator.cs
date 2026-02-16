using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsEx
{
    internal class BasicComparator : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.Basic >= y.Basic)
            {
                return 1;
            }
            return -1;
        }
    }
}
