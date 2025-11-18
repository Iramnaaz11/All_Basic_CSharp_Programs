using System;
using System.Collections.Generic;

namespace All_Basic_Programs.Fibonacci_Series
{
    internal class Using_List
    {
        static void Main()
        {
            Console.Write("Enter the number of terms here : ");
            int n = int.Parse(Console.ReadLine());

            List<int> fib = new List<int> { 0, 1 };

            for (int i = 2; i < n; i++)
            {
                fib.Add(fib[i - 1] + fib[i - 2]);
            }

            Console.Write("Fibonacci series : ");
            foreach (var item in fib)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.ReadLine(); // So console doesn't close
        }
    }
}
