using System;

namespace Lesson4
{
    class Program
    {
        //Task 9: Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation.
        static void Main(string[] args)
        {
            int numberOne, numberSecond, processNumber;
            Console.Write("Enter first number: ");
            numberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second Integer : ");
            numberSecond = Convert.ToInt32(Console.ReadLine());
            Console.Write("Here are the options : 1 - Addition. 2 - Substraction. 3 - Multiplication. 4 - Division. 5 - Exit.");
            Console.Write("Input your choice : ");
            processNumber = Convert.ToInt32(Console.ReadLine());

            switch (processNumber)
            {
                case 1:
                    Console.WriteLine(numberOne + numberSecond);
                    break;
                case 2:
                    Console.WriteLine(numberOne - numberSecond);
                    break;
                case 3:
                    Console.WriteLine(numberOne * numberSecond);
                    break;
                case 4:
                    Console.WriteLine(numberOne / numberSecond);
                    break;
                case 5:
                    break;
            }

        }
        //Task 8: Write a program in C# Sharp to read any day number in integer and display day name in the word
        static void Main8(string[] args)
        {
            int day;
            Console.Write("Enter day of week with number to see its name: ");
            day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
        //Task 7: Write a C# Sharp program to find the largest of three numbers.
        static void Main7(string[] args)
        {
            int numberOne, numberSecond, NumberThird;
            Console.Write("Number 1: ");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            numberSecond = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 3: ");
            NumberThird = Convert.ToInt32(Console.ReadLine());
            if (numberOne > numberSecond)
            {
                if (numberOne > NumberThird)
                {
                    Console.WriteLine("The 1th Number is the greatest among three");
                } else
                {
                    Console.WriteLine("The 3th Number is the greatest among three");
                }
            }
            else
            {
                if (numberSecond > NumberThird)
                {
                    Console.WriteLine("The 2th Number is the greatest among three");
                }
                else
                {
                    Console.WriteLine("The 3th Number is the greatest among three");
                }
            }
        }

        //Task 6: Write a program in C# Sharp to find the last day of a week against a given date.
        static void Main6(string[] args)
        {
            string year, month, day;
            DateTime equality = new DateTime(1994, 03, 18, 0, 0, 0);
            Console.Write("Year");

            year = Console.ReadLine();
            Console.Write("Month");
            month = Console.ReadLine();

            Console.Write("Day");
            day = Console.ReadLine();

            DateTime YearEnd = DateTime.Parse(day + "/" + month + "/" + year);
            if (Convert.ToString(YearEnd.DayOfWeek) == "Sunday")
            {
                equality = YearEnd;
            }
            if (Convert.ToString(YearEnd.AddDays(1).DayOfWeek) == "Sunday")
            {
                equality = YearEnd.AddDays(1);
            }
            if (Convert.ToString(YearEnd.AddDays(2).DayOfWeek) == "Sunday")
            {
                equality = YearEnd.AddDays(2);
            }
            if (Convert.ToString(YearEnd.AddDays(3).DayOfWeek) == "Sunday")
            {
                equality = YearEnd.AddDays(3);
            }
            if (Convert.ToString(YearEnd.AddDays(4).DayOfWeek) == "Sunday")
            {
                equality = YearEnd.AddDays(4);
            }
            if (Convert.ToString(YearEnd.AddDays(5).DayOfWeek) == "Sunday")
            {
                equality = YearEnd.AddDays(5);
            }
            if (Convert.ToString(YearEnd.AddDays(6).DayOfWeek) == "Sunday")
            {
                equality = YearEnd.AddDays(6);
            }
            Console.WriteLine("The formatted Date is : " + YearEnd.Date);
            Console.WriteLine("The last day of the week for the above date is : " + equality);

        }
        //Task 5: Write a program in C# to get the day of week from last day of the current year against a given date
        static void Main5(string[] args)
        {
            string year, month, day;
            bool equality = true; ;
            Console.Write("Year");

            year = Console.ReadLine();
            Console.Write("Month");
            month = Console.ReadLine();

            Console.Write("Day");
            day = Console.ReadLine();

            DateTime YearEnd = DateTime.Parse(day + "/" + month + "/" + year);
            Console.WriteLine("The formatted Date is : " + YearEnd.Date);
            Console.WriteLine("The Last day of the year " + year + " is : " + DateTime.Parse("12/12/" + year).DayOfWeek);

        }
        //Task 4: Write a program in C# to check whether the given year, month and day are the current or not. Test Data :  Input the Day : 17 Input the Month : 09 Input the Year : 2016 Expected Output :
        static void Main4(string[] args)
        {
            string year, month, day;
            bool equality;
            Console.Write("Year");

            year = Console.ReadLine();
            Console.Write("Month");
            month = Console.ReadLine();

            Console.Write("Day");
            day = Console.ReadLine();

            DateTime YearEnd = DateTime.Parse(day + "/" + month + "/" + year);
            if (DateTime.Compare(YearEnd.Date, DateTime.Now.Date) == 0)
            {
                equality = true;
            }
            else
            {
                equality = false;
            }


           Console.WriteLine("The formatted Date is : " + YearEnd.Date + " The current date status : " + equality);
        }
        //Task 3: Write a C# program to calculate what day of the week is after 40 days from this moment
        static void Main3(string[] args)
        {
            Console.WriteLine(DateTime.Now.AddDays(40).DayOfWeek);
        }
        // Task 2: Write a C# that calculates you current life days (how many days past since your birth)
        static void Main2(string[] args)
        {
            DateTime blackDay = new DateTime(1994, 03, 18, 0, 0, 0);
            
            Console.WriteLine((DateTime.Now.Date - blackDay.Date).Days);
        }

        //Task 1: Write a C# that calculates the day of week (ex: Monday) of your birthday
        static void Main1(string[] args)
        {
            DateTime blackDay = new DateTime(1994, 03, 18, 0, 0, 0);
            Console.WriteLine(blackDay.DayOfWeek);
        }
    }
}
