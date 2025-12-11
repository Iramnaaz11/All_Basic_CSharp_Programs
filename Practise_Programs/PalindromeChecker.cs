using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Basic_Programs.Practise_Programs
{
    internal class PalindromeChecker
    {
        static void Main()
        {
            Console.WriteLine("Enter a string : ");
            string str = Console.ReadLine();

            string rev = new string(str.Reverse().ToArray());
            Console.WriteLine(rev);

            if (str == rev)
            {
                Console.WriteLine("Entered string is Palindrome");
            }
            else
            {
                Console.WriteLine("Entered string is not a Palindrome");
            }
        }
    }
}
