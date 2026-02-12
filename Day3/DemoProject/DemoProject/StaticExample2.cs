using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class StaticExample2
    {
        public static void Show()
        {
            Console.WriteLine("Wipro Training...");
        }

        public static void Trainer()
        {
            Console.WriteLine("Trainer is Prasanna Sir");
        }
    }
    internal class StaticExample
    {
        static void Main()
        {
            StaticExample2.Show();
            StaticExample2.Trainer();
        }
    }
}
