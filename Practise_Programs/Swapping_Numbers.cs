using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Basic_Programs.Practise_Programs
{
    internal class Swapping_Numbers
    {
        static void Main()
        {
            int a = 10, b = 20;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a = " + a + ", b = " + b);
        }
    }
}
