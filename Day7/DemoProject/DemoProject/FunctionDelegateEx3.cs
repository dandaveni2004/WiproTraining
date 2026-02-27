using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class FunctionDelegateEx3
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Mult(int x, int y)
        {
            return x * y;
        }

        static void Main()
        {
            Func<int, int, int> result1 = new FunctionDelegateEx3().Sum;
            int res = result1(14,4);
            Console.WriteLine("Sum is  " + res);

            Func<int, int, int> result2 = new FunctionDelegateEx3().Sub;
            res = result2(12, 5);
            Console.WriteLine("Sub is  " + res);

            Func<int, int, int> result3 = new FunctionDelegateEx3().Mult;
            res = result3(12, 5);
            Console.WriteLine("Mult is  " + res);

        }
    }
}
