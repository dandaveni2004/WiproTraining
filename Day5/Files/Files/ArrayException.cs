using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    internal class ArrayException
    {
        static void Main()
        {
            int[] a = { 1, 2, 3 };
            try
            {
                a[5] = 5;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Array Size small");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
