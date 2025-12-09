using All_Basic_Programs.ReverseString;
using System;
using System.Linq;


namespace All_Basic_Programs.Practise_Programs
{
    internal class Count_Vowels
    {

        static void Main()
        {
            string str = "iravira";
            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in str)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }

            }
            Console.WriteLine("Number of vowels in the string: " + count);

        }
    }    
}