using System;

namespace All_Basic_Programs.Fibonacci_Series
{
    internal class Using_Recursion
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
