using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class InheritanceCon
    {
        static InheritanceCon()
        {
            Console.WriteLine("Base Class Static Constructor...");
        }
        public InheritanceCon()
        {
            Console.WriteLine("Base Class Constructor...");
        }
    }

    class InheritanceCon2 : InheritanceCon
    {
        static InheritanceCon2()
        {
            Console.WriteLine("Derived Class Static Constructor...");
        }
        public InheritanceCon2()
        {
            Console.WriteLine("Derived Class Constructor...");
        }

        static void Main()
        {
            InheritanceCon2 inhcon = new InheritanceCon2();
        }
    }
}
