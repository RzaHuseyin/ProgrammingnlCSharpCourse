using System;

namespace Lesson2
{
    class Program
    {

        //Make a lot of exercises with different types and try to understand important aspects
        static void Main()
        {
            int a;
            string b;
            double c;
            decimal d;
            bool e;
            float f;
            char h;
            byte g;
            sbyte k;
            short l;
            uint m;
            long n;
            ulong o;
            object u;
            DateTime z;
        }

        //Write a C# program that takes the radius of a circle as input and calculate the perimeter and area of the circle and print it in console
        static void Main3()
        {
            double radius;
            Console.Write("Enter radius of circle to calculate perimeter and area: ");
            radius = Convert.ToDouble(Console.ReadLine());
            double perimeter = 3.14 * 2 * radius;
            double area = 3.14 * radius * radius;

            Console.WriteLine(perimeter + " is perimeter and " + area + " is area of circle");
        }
        //Task2: Write a C# program that takes 2 inputs form user respectively name and surname, and then print it as "NAME SURNAME" (both uppercase) in console
        static void Main2()
        {
            string firstName;
            string lastName;
            Console.Write("Enter First name: ");
            firstName = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Last name: ");
            lastName = Convert.ToString(Console.ReadLine());

            Console.WriteLine((firstName + " " + lastName).ToUpper());
        }

        //Task 1: Write a C# program that takes three letters as input and display them in reverse order.
        static void Main1(string[] args)
        {
            string firstLetter;
            string secondLetter;
            string thirdLetter;
            Console.Write("Enter the first letter: ");
            firstLetter = Convert.ToString(Console.ReadLine()); 

            Console.Write("Enter the second letter: ");
            secondLetter = Convert.ToString(Console.ReadLine()); 
            Console.Write("Enter the third letter: ");
            thirdLetter = Convert.ToString(Console.ReadLine());


            Console.WriteLine(thirdLetter + " " + secondLetter + " " + firstLetter);
        }
    }
}
