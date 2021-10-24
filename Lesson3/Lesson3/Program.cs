using System;

namespace Lesson3
{
    class Program
    {
        // Task 1: Write a C# program that takes two numbers as input and returns true or false when both numbers are even or odd
        static void Main1(string[] args)
        {
            int numberOne;
            int numberTwo;
            Console.Write("Enter the first number: ");
            numberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number ");
            numberTwo = Convert.ToInt32(Console.ReadLine());
            if ((numberOne%2 == 0 && numberTwo%2 == 0) || (numberOne % 2 == 1 && numberTwo % 2 == 1))
            {
                Console.WriteLine("true");

            }
            else
            {
                Console.WriteLine("false");
            }

        }
        
        //Task 2: Write a C# program which takes 2 string input from user and return if second string is in first string. Example. 1st input: Azərbaycan, 2nd input: can, Result should be true because can is in Azərbaycan
        static void Main2(string[] args)
        {
            string firstString;
            string secondString;
            Console.Write("Enter the first number: ");
            firstString = Convert.ToString(Console.ReadLine());

            Console.Write("Enter the first number: ");
            secondString = Convert.ToString(Console.ReadLine());
            Console.WriteLine(firstString.Contains(secondString));
        }
        //Tzak 3: Get 2 int number input from user and calculate the exact input1 / input2.Example: 16, 5. Result should be 3.2 not 3.
        static void Main3(string[] args)
        {
            float numberOne;
            float numberTwo;
            Console.Write("Enter the first number: ");
            numberOne = (float)Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the second number ");
            numberTwo = (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine((float)(numberOne/ numberTwo));
        }


        //Task 4: Practise type conversions(different options), types and operators
        static void Main(string[] args)
        {
            int number1 = 32;
            float numberFloat = (float)number1;
            Console.WriteLine("Hello World!");
        }
    }
}
