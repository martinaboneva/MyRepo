using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
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
            bool isPalindrome = false;
            var reversed = input.Reverse().ToArray();
            if (input == new string(reversed))
                isPalindrome = true;

            return isPalindrome;
        }
    }
}
