using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class StringBuilder1
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("Welcome to C# Programming...");
            Console.WriteLine(sb);
            sb.Insert(5, "Raju");
            Console.WriteLine(sb);
            sb.Remove(5, 6);
            Console.WriteLine(sb);
            sb.Append(" Karthik");
            Console.WriteLine(sb);
        }
    }
}
