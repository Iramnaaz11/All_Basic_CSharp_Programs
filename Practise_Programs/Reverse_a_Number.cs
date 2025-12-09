using System;


namespace All_Basic_Programs.Practise_Programs
{
    internal class Reverse_a_Number
    {
        static void Main()
        {
            {
                int num = 3264;
                int rev = 0;

                while (num > 0)
                {
                    int digit = num % 10;
                    rev = rev * 10 + digit;
                    num = num / 10;
                }
                Console.WriteLine("Reversed Number: " + rev);
            }
        }
    }
}
