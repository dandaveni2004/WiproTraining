using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class RefReturn3
    {
        public ref string GetResult(string[] names)
        {
            string[] arrResult = { "Not Found", "Found" };
            ref string result = ref arrResult[0];

            foreach (string name in names)
            {
                if (name.Equals("Josh"))
                {
                    result = arrResult[1];
                    return ref result;
                }
            }
            return ref result;
        }
        static void Main()
        {
            string[] students = { "Akhi", "Prapti", "Aish", "Josh" };
            ref string result = ref new RefReturn3().GetResult(students);
            Console.WriteLine(result);

        }
    }
}
