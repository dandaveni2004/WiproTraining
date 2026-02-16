using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsEx
{
    internal class GenEx2
    {
        static void Main()
        {
            List<string> names = new List<string>();
            names.Add("Ganesh");
            names.Add("Nithin");
            names.Add("Raj");
            names.Add("Madhukar");
            names.Add("Rohit");
            names.Add("Sharook");
            names.Add("Raj");
            Console.WriteLine("Names are");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
