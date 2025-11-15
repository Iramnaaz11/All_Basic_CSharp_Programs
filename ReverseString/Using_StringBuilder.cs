using System;
using System.Text;


namespace All_Basic_Programs.ReverseString
{
    internal class Using_StringBuilder
    {
        static void Main()
        {
            Console.WriteLine("Enter a string3 : ");
            string str = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            
            for(int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
