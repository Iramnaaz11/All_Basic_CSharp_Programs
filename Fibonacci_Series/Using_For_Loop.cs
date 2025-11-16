using System;
using System.Runtime.ExceptionServices;

namespace All_Basic_Programs.Fibonacci_Series
{
    internal class Using_For_Loop
    {
        static void Main()
        {
            Console.Write("Enter the count : ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c;

            Console.Write("Fibonacci series :");

            for (int i = 2; i <= n; i++)
            {
                Console.Write(a + " ");

                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}

