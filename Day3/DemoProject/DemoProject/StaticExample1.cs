using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class StaticExample1
    {
        static int count;
        public void Increment()
        {
            count++;
            Console.WriteLine($"Count {count}");
        }
        static void Main()
        {
            StaticExample1 obj1 = new StaticExample1();
            StaticExample1 obj2 = new StaticExample1();
            StaticExample1 obj3 = new StaticExample1();

            obj1.Increment();
            obj2.Increment();
            obj3.Increment();
        }
    }
}
