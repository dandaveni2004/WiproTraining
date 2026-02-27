using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class DelegateEx2
    {
        public delegate void TestDelegate(string str);

        public static void Show(string str)
        {
            Console.WriteLine("Good Morning " + str);
        }

        static void Main()
        {
            string str = "Yah....";
            TestDelegate obj = new TestDelegate(Show);
            obj(str);
        }
    }
}
