using System;

namespace All_Basic_Programs.Fibonacci_Series
{
    internal class Using_Array
    {

        static void Main()
        {
            Console.Write("Enter the Number of terms : ");
            int n = int.Parse(Console.ReadLine());

            int[] fib = int[n];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            Console.Write("Fibonacci Series : ");
            foreach (var x in fib)
                Console.Write(x + " ");
        }
    }
}