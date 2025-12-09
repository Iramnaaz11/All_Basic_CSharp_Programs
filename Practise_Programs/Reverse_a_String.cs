using System;

namespace All_Basic_Programs.Practise_Programs
{
    internal class Reverse_a_String
    {
        static void Main()
        {
            Console.WriteLine("Enter a string to reverse: ");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine("Reversed string: " + reversedString);
        }
    }
}

//Another Method to Reverse a String : 

/*{
string str = "Hello";
char[] arr = str.ToCharArray();
Array.Reverse(arr);
Console.WriteLine(new string(arr));
}*/