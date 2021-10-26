using System;

namespace Lesson5
{
    class Program
    {
        // Task3: Write a program in C# to read 5 numbers from keyboard and find their sum and average.
        static void Main3(string[] args)
        {
            Console.Write("number1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("number2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("number3: ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("number4: ");
            int number4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("number5: ");
            int number5 = Convert.ToInt32(Console.ReadLine());
            int sum = number1 + number2 + number3 + number4 + number5;
            int average = sum/5;

            Console.WriteLine("Sum of numbers: " + sum);
            Console.WriteLine("average of numbers: " + average);
        }

            //Task2: Write a C# program to find the sum of first 20 odd natural numbers.
        static void Main2(string[] args)
        {
            int count = 0;
            int length = 20;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                if (i%2 == 0)
                {
                    sum += i;
                    count++;
                    length++;
                }
                if(count > 20)
                {
                    break;
                }

            }
            Console.WriteLine(sum);
        }

        //Task1: Write a program in C# to display the first 10 natural numbers
        static void Main1(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
