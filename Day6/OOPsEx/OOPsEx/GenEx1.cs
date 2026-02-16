using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPsEx
{
    internal class GenEx1
    {
        public static void Swap<T>(ref T a,ref T b)
        {
            T t;
            t = a;
            a = b;
            b = t;
        }
        static void Main()
        {
            int a = 5, b = 7;
            Console.WriteLine($"A value {a} B value {b}");
            Swap(ref a, ref b);
            Console.WriteLine("Data After Swapping...");
            Console.WriteLine($"A value {a} B value {b}");
            string s1 = "Aman", s2 = "Tushar";
            Console.WriteLine("Data after Swapping ");
            Swap(ref s1, ref s2);
            Console.WriteLine($"S1 value {s1} S2 value {s2}");
            bool b1 = true, b2 = false;
            Console.WriteLine("Data after Swapping ");
            Swap(ref b1, ref b2);
            Console.WriteLine($"S1 value {b1} S2 value {b2}");

            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            emp1.Empno = 101;
            emp1.Name = "Mani";
            emp1.Basic = 90000;

            emp2.Empno = 102;
            emp2.Name = "Sushi";
            emp2.Basic = 80000;

            Swap(ref emp1, ref emp2);
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
        }
    }
}
