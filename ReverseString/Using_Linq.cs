using System;
using System.Linq;

namespace All_Basic_Programs.ReverseString
{
    internal class Using_Linq
    {
        static void Main()
        {
            Console.WriteLine("Enter a string 4 : ");
            string str = Console.ReadLine();

            string reversed = new string(str.Reverse().ToArray());
            Console.WriteLine(reversed);
        }
    }
}
