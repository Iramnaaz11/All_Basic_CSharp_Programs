using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Basic_Programs.Programs_Basic
{
    internal class PalindromeCheckForInt
    {
        static void Main()
        {
            Console.Write("Enter a Number of your Choice : ");
            int num = int.Parse(Console.ReadLine());
            int rev = 0;
            int temp = num;

            while (num > 0)
            {

                int digit = num % 10;
                rev = rev *10 + digit;
                num = num / 10;
            }
                if (rev == temp)
                {
                    Console.WriteLine("Entered number is a Palindrome");
                }
                else
                {
                    Console.WriteLine("Entered number is not a Palidrome");
                }


        }
    }
}
