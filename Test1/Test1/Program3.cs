using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Program3
    {
        static void Main()
        {
            Console.WriteLine("Enter a String");
            string str=Console.ReadLine();
            Console.WriteLine("Enter value of k");
            int k=Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                flag = false;
                string res = "";
                int i = 0;
                while (i < str.Length)
                {
                    int count = 1;
                    while(i+1< str.Length && str[i] == str[i+1])
                    {
                        count++;
                        i++;
                    }
                    if(count!=k)
                    {
                        for(int j = 0; j < count; j++)
                        {
                            res += str[i];
                        }
                    }
                    else
                    {
                        flag = true;
                    }
                    i++;
                }
                str = res;
            }
            Console.WriteLine("Reduced string :"+str);
        }
    }
}
