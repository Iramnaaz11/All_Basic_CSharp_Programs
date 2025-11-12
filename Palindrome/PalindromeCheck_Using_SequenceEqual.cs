using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Basic_Programs.Palindrome
{
    internal class PalindromeCheck_Using_SequenceEqual
    {
        static void Main()
        {
            Console.Write("Enter a string 1 : ");
            string str = Console.ReadLine();

            if (IsPalindrome(str))
                Console.WriteLine("String is Palindrome");
            else Console.WriteLine("String is not Palindrome");
        }

        static bool IsPalindrome(string str)
        {
            str = str.ToLower();
            return str.SequenceEqual(str.Reverse());
        }
    }
}
