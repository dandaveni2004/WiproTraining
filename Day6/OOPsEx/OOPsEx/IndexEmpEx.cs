using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsEx
{
    internal class IndexEmpEx
    {

        Employee[] arr = new Employee[5];

        public Employee this[int i]
        {
            get { return arr[i]; }
            set
            {
                arr[i] = value;
            }
        }
        static void Main()
        {
            IndexEmpEx obj = new IndexEmpEx();
            obj[0] = new Employee { Empno = 201, Name = "Karthik", Basic = 90000 };
            obj[1] = new Employee { Empno = 202, Name = "Raj", Basic = 92000 };
            obj[2] = new Employee { Empno = 203, Name = "Pradeep", Basic = 95000 };
            obj[3] = new Employee { Empno = 204, Name = "Ganesh", Basic = 85000 };
            obj[4] = new Employee { Empno = 205, Name = "Karthik", Basic = 980000 };

            foreach (Employee v in obj.arr)
            {
                Console.WriteLine(v);
            }

        }
    }
}
