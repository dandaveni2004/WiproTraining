using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class EventEx1
    {
        public delegate void EventExample();
        public static event EventExample ShowName;

        public static void Ganesh()
        {
            Console.WriteLine("Hi I am Ganesh");
        }

        public static void Karthik()
        {
            Console.WriteLine("Hi I am Karthik");
        }

        public static void Rajj()
        {
            Console.WriteLine("Hi I am Rajj");
        }

        public static void Pradeep()
        {
            Console.WriteLine("Hi I am Pradeep");
        }

        public static void Execute(string name)
        {
            if (name.Equals("Rajj"))
            {
                ShowName = new EventExample(Rajj);
                ShowName.Invoke();
            }

            if (name.Equals("Karthik"))
            {
                ShowName = new EventExample(Karthik);
                ShowName.Invoke();
            }

            if (name.Equals("Ganesh"))
            {
                ShowName = new EventExample(Ganesh);
                ShowName.Invoke();
            }

            if (name.Equals("Pradeep"))
            {
                ShowName = new EventExample(Pradeep);
                ShowName.Invoke();
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter Name  ");
            string name = Console.ReadLine();
            Execute(name);
        }
    }
}
