using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Basic_Programs.ReverseString
{
    internal class Using_Recursion
    {
        static void Main()

        {
            Console.Write("Enter a string : ");
            string rev = Console.ReadLine();

            string Reverse(string s)
            {
                if (s.Length <= 1)
                    return s;

                return Reverse(s.Substring(1)) + s[0];
            }

            Console.WriteLine("Reversed string is : " + Reverse(rev));
        }
    }
}
