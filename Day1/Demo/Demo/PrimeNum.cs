using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class PrimeNum
    {
        public void Show(int n)
        {
            bool flag = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Prime Number...");
            }
            else
            {
                Console.WriteLine("Not Prime Number...");
            }
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter N value   ");
            n = Convert.ToInt32(Console.ReadLine());
            PrimeNum prime = new PrimeNum();
            prime.Show(n);
        }
    }
}
