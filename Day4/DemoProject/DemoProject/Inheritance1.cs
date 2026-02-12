using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Inheritance1
    {
        class G1
        {
            public void Show()
            {
                Console.WriteLine("Show Method 1");
            }
        }

        class G2 : G1
        {
            public void Display()
            {
                Console.WriteLine("Display Method 2");
            }
        }
        internal class Inh1
        {
            static void Main()
            {
                G2 g = new G2();
                g.Show();
                g.Display();
            }
        }
    }
}
