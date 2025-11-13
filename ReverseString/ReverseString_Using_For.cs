using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Basic_Programs.ReverseString
{
    internal class ReverseString_Using_For
    {
        static void Main()
        {
            Console.Write("Enter a string you want to reverse : ");
            string str = Console.ReadLine();
            string rev = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
                Console.Write("This is a reversed string : ");
                Console.WriteLine(rev);
              
        }
    }
}
