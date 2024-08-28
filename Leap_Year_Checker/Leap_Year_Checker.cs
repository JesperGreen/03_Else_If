// Leap Year Checker

using System;
public class Demo
{
    public static void Main()
    {
        Console.Write("input a year (4 digits) to see if it is a leap year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Year = " + year);
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("This is a leap year");
        }
        else
        {
            Console.WriteLine("This is NOT a leap year");
        }
    }
}
