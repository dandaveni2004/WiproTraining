using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsEx
{
    internal class DictionaryEx2
    {
        static string GetValue(Dictionary<int, string> dict, int key)
        {
            string res;
            dict.TryGetValue(key, out res);
            return res;
        }
        static void Main()
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Abhishek Sharma");
            students.Add(2, "Ishan Kishan");
            students.Add(3, "Nithish Kumar Reddy");
            students.Add(4, "Henrich Klassen");
            students.Add(5, "Pat Cummins");
            string res;
            res = GetValue(students, 1);
            Console.WriteLine(res);
        }

        
    }
}
