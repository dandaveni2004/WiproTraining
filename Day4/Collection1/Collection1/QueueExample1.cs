using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection1
{
    internal class QueueExample1
    {
        static void Main()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            Console.WriteLine("Queue Data is  ");
            foreach (object ob in queue)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
