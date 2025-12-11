using System;


namespace All_Basic_Programs
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            int rev = 0;
            int temp = num;

            while (num > 0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num = num / 10;

            }
                if (rev == temp)
                {
                    Console.WriteLine("Entered number is Palindrome");
                }
                else
                {
                    Console.WriteLine("Entered number is not a Palindrome");
                }

            }
        }
    }

