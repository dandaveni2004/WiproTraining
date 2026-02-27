using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class TupleEx2
    {
        static void Main()
        {
            ShowEmployTuple((101, "Rohith", 88888));
            ShowEmployTuple((102, "Madhu", 99999));
            ShowEmployTuple((103, "Sharook",77777));
        }

        static void ShowEmployTuple((int, string, double) employ)
        {
            Console.WriteLine($"Employ No {employ.Item1} Employ Name {employ.Item2} " +
                $"  Salary {employ.Item3}");
        }
    }
}
