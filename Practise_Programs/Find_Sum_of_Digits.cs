using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Basic_Programs.Practise_Programs
{
    internal class Find_Sum_of_Digits
    {
        static void Main()
        {
            int num = 1234;
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            Console.WriteLine("Sum: " + sum);
        }
    }
}
