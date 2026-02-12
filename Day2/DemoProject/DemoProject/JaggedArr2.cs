using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class JaggedArr2
    {
        static void Main()
        {
            string[] mt1 = new string[] { "T20-1", "T20-2", "T20-3" ,"T20-4","T20-5" };
            string[] mt2 = new string[] { "TEST-1", "TEST-2" };
            string[] mt3 = new string[] { "ODI-1", "ODI-2", "ODI-3" };
            string[] mt4 = new string[] { "Final Match" };
            string[][] dynamics = new string[4][];

            dynamics[0] = mt1;
            dynamics[1] = mt2;
            dynamics[2] = mt3;
            dynamics[3] = mt4;

            Console.WriteLine("Team India Matches sheduled on next month");
            for (int i = 0; i < dynamics.Length; i++)
            {
                foreach (string s in dynamics[i])
                {
                    Console.Write(s + "    ");
                }
                Console.WriteLine();
            }
        }
    }
}
