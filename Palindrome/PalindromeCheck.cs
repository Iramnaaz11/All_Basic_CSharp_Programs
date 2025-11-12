using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Basic_Programs.Programs_Basic
{
    internal class PalindromeCheck
    {
        static void Main()
        {
            Console.Write("Enter a String : ");
            string str = Console.ReadLine();

            string rev = new string (str.Reverse() .ToArray());
            if (str == rev) {
                Console.WriteLine("Entered string Is Palindrome."); }
            else
            {
                Console.WriteLine("Entered string Is not a Palindrome.");
            }

            //Console.WriteLine("press any key to exit .");
            //Console.ReadKey();
        }
    }
}
