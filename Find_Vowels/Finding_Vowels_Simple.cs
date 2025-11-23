using System;

namespace All_Basic_Programs
{
    internal class Finding_Vowels_Simple
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine().ToLower();

            string vowels = "aeiou";
            int count = 0;

            Console.Write("Vowels in your name: ");

            foreach (char ch in name)
            {
                if (vowels.Contains(ch.ToString()))
                {
                    Console.Write(ch + " ");
                    count++;
                }
            }

            Console.WriteLine("\nTotal vowels: " + count);

            Console.WriteLine();      
            Console.ReadLine();       
        }
    }
}
