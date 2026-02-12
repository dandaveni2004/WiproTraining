using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ArrayExample1
    {
        public void Show()
        {
            int[] a = new int[] { 12, 66, 31, 66, 23, 122 };
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
        static void Main()
        {
            ArrayExample1 ArrEx1 = new ArrayExample1();
            ArrEx1.Show();
        }
    }
}
