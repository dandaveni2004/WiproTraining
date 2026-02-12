using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Cricket
    {
        static int score;
        public void Increment(int x)
        {
            score += x;
        }
        static void Main()
        {
            Cricket fb = new Cricket();
            Cricket sb = new Cricket();
            Cricket ext = new Cricket();

            fb.Increment(45);
            sb.Increment(1);
            ext.Increment(18);

            Console.WriteLine($"Total Score {score}");
        }
    }
}
