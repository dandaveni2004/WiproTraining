using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Main1
    {
        static void Main()
        {
            ITtraining[] arr = new ITtraining[]
            {
                new Ganesh(), new Akhi(), new Dhruv()
            };

            foreach (ITtraining training in arr)
            {
                training.Name();
                training.Email();
            }
        }
    }
}
