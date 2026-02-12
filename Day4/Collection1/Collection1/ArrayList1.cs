using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    internal class ArrayList1
    {
        static void Main()
        {
            ArrayList a = new ArrayList();
            a.Add(10);
            a.Add("Ganesh");
            a.Add(30.6);
            a.Add("wipro");
            foreach (object obj in a)
            {
                Console.WriteLine(obj);
            }
            
        }
    }
}
