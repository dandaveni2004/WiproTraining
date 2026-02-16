using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"c:/files/filecs.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Welcome to C# Files from Wipro...");
            sw.WriteLine("Thank You All...");
            sw.WriteLine("Playing with Output Data...");
            sw.Flush();
            sw.Close();
            fs.Close();
            Console.WriteLine("*** File Created Successfully ***");
        }
    }
}
