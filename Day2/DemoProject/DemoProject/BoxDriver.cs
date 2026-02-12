using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class BoxDriver
    {
        static void Main()
        {
            Employee e1 = new Employee();
            e1.empno = 101;
            e1.name = "Madhu";
            e1.basic = 80000;
            Employee e2 = new Employee();
            e2.empno = 102;
            e2.name = "Raj";
            e2.basic = 70000;
            Employee e3 = new Employee();
            e3.empno = 103;
            e3.name = "Rohit";
            e3.basic = 60000;
            Student s1 = new Student();
            s1.sid = 101;
            s1.sname = "Nithin";
            s1.city = "Mancherial";
            Student s2 = new Student();
            s2.sid = 102;
            s2.sname = "Rajuu";
            s2.city = "Hyd";

            object[] arr = new object[] { e1, s1, e2, s2, e3 };
            foreach (object o in arr)
            {
                if (o is Employee)
                {
                    Employee employ = (Employee)o;
                    employ.ShowEmployDetails();
                    Console.WriteLine("-----------------------------------");
                }
                if (o is Student)
                {
                    Student s = (Student)o;
                    s.ShowStudentInfo();
                }
            }
        }
    }
}
