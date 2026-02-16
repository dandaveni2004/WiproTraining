using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsEx
{
    internal class SortingExample
    {
        static void Main()
        {
            string[] names = { "Surya Kumar Yadav", "Hardik", "Abhishek", "Dube", "Ishan", "Axar", "Rinku" };

            Array.Sort(names);

            Console.WriteLine("Names after Sorting...");
            foreach (string s in names)
            {
                Console.WriteLine(s);
            }
        }
    }
}
