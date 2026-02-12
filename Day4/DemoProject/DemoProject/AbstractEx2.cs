using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    abstract class Animal
    {
        public abstract void Name();
        public abstract void Type();
    }
    class Crocodile : Animal
    {
        public override void Name()
        {
            Console.WriteLine("Name is Crocodile...");
        }

        public override void Type()
        {
            Console.WriteLine("Its Water Animal...");
        }
    }

    class Cow : Animal
    {
        public override void Name()
        {
            Console.WriteLine("Name is Cow...");
        }

        public override void Type()
        {
            Console.WriteLine("Its Mammals Category...");
        }
    }
    class Lion : Animal
    {
        public override void Name()
        {
            Console.WriteLine("Name is Lion...");
        }
        public override void Type()
        {
            Console.WriteLine("Its Wild Animal...");
        }
    }
    internal class AbstractEx2
    {
        static void Main()
        {
            Animal[] arr = new Animal[]
            {
                new Lion(), new Crocodile(), new Cow()
            };
            foreach (Animal animal in arr)
            {
                animal.Name();
                animal.Type();
            }
        }
    }
}
