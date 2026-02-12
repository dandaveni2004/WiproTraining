using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    internal class Stack1
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("Madhu");
            stack.Push(22);
            stack.Push("HYd");
            stack.Push(30);
            stack.Push(45.5);

            Console.WriteLine("Stack Data  ");
            foreach (object ob in stack)
            {
                Console.WriteLine(ob);
            }
            stack.Pop();
            stack.Pop();
            Console.WriteLine("Stack Data After Pop Operation  ");
            foreach (object ob in stack)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
