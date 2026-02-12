using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class ReverseAltWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Sentance");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (i % 2 == 1)
                {
                    string reversed = "";
                    for (int j = words[i].Length - 1; j >= 0; j--)
                    {
                        reversed = reversed + words[i][j];
                    }
                    words[i] = reversed;
                }
            }
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i] + " ");
            }
        }
    }
}
