using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    internal class HashTable1
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add(45, "Rohith Sharma");
            ht.Add(1, "KL Rahul");
            ht.Add(18, "Virat Kohli");
            ht.Add(33, "Hardik pandya");
            ht.Add(93, "Bumrah");

            int key;
            Console.WriteLine("Enter Key  ");
            key = Convert.ToInt32(Console.ReadLine());
            string res = (string)ht[key];
            //Console.WriteLine(res.Length);
            if (res == null)
            {
                Console.WriteLine("Key Not Found");
            }
            else
            {
                Console.WriteLine(res);
            }
        }
    }
}
