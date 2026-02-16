using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsEx
{
    internal class Nullable1
    {
        static void Main()
        {
            Emp emp1 = new Emp();
            emp1.Empno = 101;
            emp1.Name = "Pradeep";


            Emp emp2 = new Emp();
            emp2.Empno = 102;
            emp2.Name = "Raj";
            emp2.LeaveDays = 3;

            if (emp1.LeaveDays.HasValue)
            {
                Console.WriteLine($"You{emp1.Name} are taken leave Already...");
            }
            else
            {
                Console.WriteLine($" You {emp1.Name}No Leave Taken You Can take leave now...");
            }

            if (emp2.LeaveDays.HasValue)
            {
                Console.WriteLine($"You{emp2.Name} are taken leave Already...");
            }
            else
            {
                Console.WriteLine($" You {emp2.Name}No Leave Taken You Can take leave now...");
            }
        }
    }
}
