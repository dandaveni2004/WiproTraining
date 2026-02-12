using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    internal class EmpList2
    {
        static void Main()
        {
            EmpList1 e1 = new EmpList1();
            e1.Empno = 101;
            e1.Name = "Karthik";
            e1.Sal = 100000;

            EmpList1 e2 = new EmpList1();
            e2.Empno = 102;
            e2.Name = "Rajj";
            e2.Sal = 90000;

            EmpList1 e3 = new EmpList1();
            e3.Empno = 103;
            e3.Name = "Pradeep";
            e3.Sal = 100000;
            ArrayList arrayList = new ArrayList();
            arrayList.Add(e1);
            arrayList.Add(e2);
            arrayList.Add(e3);

            foreach (object obj in arrayList)
            {
                EmpList1 employ = (EmpList1)obj;
                Console.WriteLine(employ);
            }
        }
    }

    
}
