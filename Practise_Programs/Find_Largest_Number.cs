using System;

namespace All_Basic_Programs.Practise_Programs
{
    internal class Find_Largest_Number
    {
        static void Main()
        {
            Console.WriteLine("Enter number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1  > num2 )
                Console.WriteLine("Largest number is : " + num1);
            else
                Console.WriteLine("Largest number is : " + num2);


        }
    }
}