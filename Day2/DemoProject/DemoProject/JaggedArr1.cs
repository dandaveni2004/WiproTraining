using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class JaggedArr1
    {
        static void Main()
        {
            int[] a = new int[] { 1, 2, 3, 4 };
            int[] b = new int[] { 5, 6, 7 };
            int[] c = new int[] { 8, 9, 10, 11, 12 };
            int[][] jag = new int[3][];
            jag[0] = a;
            jag[1] = b;
            jag[2] = c;
            Console.WriteLine("Jagged Array Data is  ");
            for (int i = 0; i < jag.Length; i++)
            {
                Console.WriteLine("Row  " + i + ":   ");
                foreach (int n in jag[i])
                {
                    Console.Write(n + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}
