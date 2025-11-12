using System;

namespace All_Basic_Programs.Palindrome
{
    internal class PalindromeCheckUsingFor_String
    {
        static void Main()
        {
            Console.Write("Enter a String you want to : ");
            string str = Console.ReadLine();
            string rev = "";

            for (int i = str.Length - 1; i > 0; i--)
            {
                rev += str[i];
            }
            if (rev.ToLower() == str.ToLower())
            {
                Console.WriteLine("Entered string is a palindrome");
            }
            else
            {
                Console.WriteLine("Entered string is not a palindrome");
            }
        }
    }
}
