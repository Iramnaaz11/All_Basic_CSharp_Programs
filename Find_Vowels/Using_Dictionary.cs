using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Basic_Programs.Find_Vowels
{
    internal class Using_Dictionary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine().ToLower();

            // Dictionary to store vowel counts
            Dictionary<char, int> vowelCount = new Dictionary<char, int>()
            {
                { 'a', 0 },
                { 'e', 0 },
                { 'i', 0 },
                { 'o', 0 },
                { 'u', 0 }
            };

            foreach (char ch in name)
            {
                if (vowelCount.ContainsKey(ch))
                {
                    vowelCount[ch]++;   // increment count for that vowel
                }
            }

            Console.WriteLine("\nVowel Counts:");

            int total = 0;
            foreach (var item in vowelCount)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
                total += item.Value;
            }

            Console.WriteLine("\nTotal vowels: " + total);
            Console.ReadLine();
        }
    }
}
