using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Basic_Programs.ReverseString
{
    internal class Using_foreach
    {
        static void Main()
        {
            Console.WriteLine("Enter your string : ");
            string str = Console.ReadLine();
            string reversed = "";

            foreach (char c in str)
            {
                reversed = c + reversed;
            }
            Console.WriteLine("Reversed string is : ");
            Console.WriteLine(reversed);
        }
    }
}
