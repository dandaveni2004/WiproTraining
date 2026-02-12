using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class BoxEx2
    {
        public void Show(object ob)
        {
            string type = ob.GetType().Name;
            Console.WriteLine(type);
            if (type.Equals("Int32"))
            {
                int x = (Int32)ob;
                Console.WriteLine("Integer Casting " + x);
            }
            if (type.Equals("String"))
            {
                string x = (String)ob;
                Console.WriteLine("String Casting  " + x);
            }
            if (type.Equals("Double"))
            {
                double x = (Double)ob;
                Console.WriteLine("Double Casting  " + x);
            }
        }
        static void Main()
        {
            int x = 12;
            string str = "Hello";
            double y = 12.5;
            BoxEx2 boxTest = new BoxEx2();
            boxTest.Show(x);
            boxTest.Show(str);
            boxTest.Show(y);
        }
    }
}
