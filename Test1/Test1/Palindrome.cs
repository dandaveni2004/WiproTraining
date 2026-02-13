using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Palindrome
    {
        static void Main()
        {
            Console.WriteLine("Enter a string");
            string input=Console.ReadLine();
            input = input.ToLower();
            string res = "";
            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= '0' && input[i] <= '9'))
                {
                    res += input[i];
                }
                
            }
            bool isPal = true;
            for (int i = 0;i < res.Length/2; i++)
            {
                if(res[i] != res[res.Length - 1-i])
                {
                    isPal = false;
                    break;
                }
            }
            Console.WriteLine(isPal);
        }
    }
}
