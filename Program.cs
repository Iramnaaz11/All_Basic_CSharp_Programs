using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Basic_Programs
{
    class Program
    {
        static int Fib(int n)
        {

            if (n <= 1)
                return n;
            return Fib(n - 1) + Fib(n - 2);
        }

        static void Main()
        {
            Console.Write("Enter the number : ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Fibonacci Series : ");

            for (int i = 0; i <= n; i++)
            {
                Console.Write(Fib(i) + " ");
            }
        }
    }
}
 

