using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsEx
{
    internal class DictionaryEx1
    {
        static void Main()
        {
            Dictionary<int,string> dic = new Dictionary<int,string>();
            dic.Add(45, "Rohith Sharma");
            dic.Add(18, "Virat Kohli");
            dic.Add(1, "KL Rahul");
            dic.Add(33, "Hardik Pandya");
            dic.Add(93, "Bumrah");
            foreach(KeyValuePair<int,string> k in dic)
            {
                Console.WriteLine($"Key ${k.Key}, Value : ${k.Value}");
            }
        }
    }
}
