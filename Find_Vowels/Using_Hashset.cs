using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Basic_Programs.Find_Vowels
{
    internal class Using_Hashset
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine().ToLower();

            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;

            Console.Write("Vowels: ");

            foreach (char ch in name)
            {
                if (vowels.Contains(ch))
                {
                    Console.Write(ch + " ");
                    count++;
                }
            }

            Console.WriteLine("\nTotal vowels: " + count);
            Console.ReadLine();
        }
    }
}
