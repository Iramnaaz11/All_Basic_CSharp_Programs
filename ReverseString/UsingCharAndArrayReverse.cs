using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Basic_Programs.ReverseString
{
    internal class UsingCharAndArrayReverse
    {
        static void Main()
        {
            Console.Write("Enter your string2 : ");
            string str = Console.ReadLine();

            char[] arr = str.ToCharArray();
            Array.Reverse(arr);

            string reversed = new string(arr);
            Console.WriteLine(reversed);

            if (str.ToLower() == reversed.ToLower())
            {
                Console.WriteLine("Is Palindrome.");
            }
            else
            {
                Console.WriteLine("Is not Palindrome");
            }
        }
    }
}
