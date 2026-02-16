using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class LadderEx
    {
        public void Show(int choice)
        {
            if (choice == 1)
            {
                Console.WriteLine("Hi I am Ganesh");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Hi I am Karthik");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Hi I am Raj");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Hi I am Pradeep");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Hi I am Karthik...");
            }
            else
            {
                Console.WriteLine("Unknown Value...");
            }
        }
        static void Main()
        {
            int choice;
            Console.WriteLine("Enter Your Choice    ");
            choice = Convert.ToInt32(Console.ReadLine());
            LadderEx ladder = new LadderEx();
            ladder.Show(choice);
        }
    }
}
