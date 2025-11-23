using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Basic_Programs.Find_Vowels
{
    internal class Using_LINQ
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine().ToLower();

            var vowels = "aeiou";

            var vowelChars = name.Where(c => vowels.Contains(c.ToString()));

            Console.Write("Vowels: ");

            foreach (var v in vowelChars)
                Console.Write(v + " ");

            Console.WriteLine("\nTotal vowels: " + vowelChars.Count());

            Console.ReadLine();
        }
    }
}
