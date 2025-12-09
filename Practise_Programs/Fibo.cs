using System;
using System.Data;

namespace All_Basic_Programs.Practise_Programs
{
    internal class Fibo
    {
        static void Main()
        {
            int a = 0, b = 1, c;
            Console.WriteLine("Fibonacci Series:");

            Console.Write(a + " " + b + " ");
            for (int i = 2; i < 10; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
