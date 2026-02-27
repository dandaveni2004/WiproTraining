using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class AnonymousEx
    {
        public delegate void Show(string str);

        static void Main()
        {
            Show obj1 = delegate (string str)
            {
                Console.WriteLine("This is My First Anonymous Method "+str);
            };

            obj1("Pradeep");

            Show obj2 = delegate (string str)
            {
                Console.WriteLine("Good Morning to " + str);
            };

            obj2("Karthik");

            Show obj3 = delegate (string str)
            {
                Console.WriteLine("All the Best  " + str);
            };

            obj3("Raju Kumar");
        }
    }
}
