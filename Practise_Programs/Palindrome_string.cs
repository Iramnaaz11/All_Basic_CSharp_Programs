using System;
using System.Linq;

namespace All_Basic_Programs.Practise_Programs
{
    internal class Palindrome_string
    {
        static void Main()
        {
            string str = "madam";
            string rev = new string(str.Reverse().ToArray());

            if (str == rev)
            {
                Console.WriteLine("Entered string is Palindrome.");
            }
            else
            {
                Console.WriteLine("Entered string is not a Palindrome.");
            }
        }
    }
}
