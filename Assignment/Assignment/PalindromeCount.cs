using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class PalindromeCount
    {
        static void Main()
        {
            Console.WriteLine("Enter a Sentance");
            string input = Console.ReadLine();
            input = input.ToLower();
            string[] words = input.Split(' ');
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                string reversed = "";
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    reversed += word[j];
                }
                if (word == reversed)
                {
                    count++;
                }
            }
            Console.WriteLine("Count of Palindrome words: " + count);
        }
    }
}
