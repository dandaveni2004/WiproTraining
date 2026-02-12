using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class InterfaceDemo:InterfaceProg1,InterfaceProgram2
    {
        public void Email()
        {
            Console.WriteLine("Email from Demo Class");
        }

        public void Name()
        {
            Console.WriteLine("Name from Demo Class...");
        }
    }
}
