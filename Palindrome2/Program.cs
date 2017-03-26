using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome2
{
    class Program
    {
            static void Main(string[] args)
        {
                Console.WriteLine("Write one-word string as an input: ");
                string input = Console.ReadLine();

                bool isPalindrome = IsPalindrome(input);
                Console.WriteLine($"Is the string a palindrome ? {isPalindrome}");

            }
        public static bool IsPalindrome(string input)
        {
            bool isPalindrome = true;
            for (int i = 0; i < input.Length/2; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
                    isPalindrome = false;
                }
            }
            return isPalindrome;
        }
    }
}
