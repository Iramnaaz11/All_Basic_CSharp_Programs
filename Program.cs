using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Basic_Programs
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a String you want to : ");
            string str = Console.ReadLine();
            string rev = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            if (rev.ToLower() == str.ToLower())
            {
                Console.WriteLine("Entered string is a palindrome");
            }
            else
            {
                Console.WriteLine("Entered string is not a palindrome");
            }
        }
    }
}
