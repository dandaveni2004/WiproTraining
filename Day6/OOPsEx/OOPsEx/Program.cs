using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            Console.WriteLine(operation.PosNeg(5));
            Console.WriteLine(operation.EvenOdd(4));
            Console.WriteLine(operation.Voting(18));
            string s = "Hello";
            Console.WriteLine(s.ShowName("Gannu"));
        }
    }
}
