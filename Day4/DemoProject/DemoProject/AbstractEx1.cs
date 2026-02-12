using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    abstract class Training
    {
        public abstract void Name();
        public abstract void Email();
    }

    class Nithu : Training
    {
        public override void Email()
        {
            Console.WriteLine("Email is Nithu@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine("Hi I am Nithu...");
        }
    }

    class Raj : Training
    {
        public override void Email()
        {
            Console.WriteLine("Email is Raj@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine("Hi I am Raj Vivek...");
        }
    }

    class Madhu : Training
    {
        public override void Email()
        {
            Console.WriteLine("Email is Madhu@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine("Hi I am Madhu...");
        }
    }
    internal class AbstractEx1
    {
        static void Main()
        {
            Training[] arr = new Training[]
            {
                new Raj(), new Nithu(), new Madhu()
            };

            foreach (Training training in arr)
            {
                training.Name();
                training.Email();
            }
        }
    }
}
