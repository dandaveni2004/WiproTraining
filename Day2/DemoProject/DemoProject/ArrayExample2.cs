using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ArrayExample2
    {
        public void Show()
        {
            string[] names = new string[]
            {
                "Raju","Pradeep","Karthik","Abhishek","Ganesh","Raju","Karthik"
            };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        static void Main()
        {
            ArrayExample2 arrayExample2 = new ArrayExample2();
            arrayExample2.Show();
        }
    }
}
