using System;
using System.Collections.Generic;
using System.Linq;

namespace All_Basic_Programs
{
    internal class Program
    {
        static void Main()
        {
            int a = 10, b = 20;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Before swapping :  a = 10 , b = 20  After swapping :  " + "a = " + a + ", b = " + b);
        }

    }

}