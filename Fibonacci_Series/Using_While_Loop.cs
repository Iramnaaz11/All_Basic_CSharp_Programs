using System;


namespace All_Basic_Programs.Fibonacci_Series
{
    internal class Using_While_Loop
    {
        static void Main()
        {
            Console.Write("Enter the Count : ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c, count = 0;

            Console.Write("Fibonacci series : ");

            while (count <= n)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
                count++;
            }
        }
    }
}
