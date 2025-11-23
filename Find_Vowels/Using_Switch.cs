using System;


namespace All_Basic_Programs.Find_Vowels
{
    internal class Using_Switch
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine().ToLower();

            int count = 0;

            Console.Write("Vowels: ");

            foreach (char ch in name)
            {
                switch (ch)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.Write(ch + " ");
                        count++;
                        break;
                }
            }

            Console.WriteLine("\nTotal vowels: " + count);
            Console.ReadLine();
        }
    }
}
