using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class StringBuilder2
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("Students\n");
            sb.AppendLine("Karthik");
            sb.AppendLine("Raju");
            sb.AppendLine("Pradeep");
            sb.AppendLine("Karthik");
            sb.AppendLine("Ganesh");
            Console.WriteLine(sb);
        }
    }
}
