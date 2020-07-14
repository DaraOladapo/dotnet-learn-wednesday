using System;

namespace _06_Dates_And_Time
{
    class Program
    {
        static void Main(string[] args)
        {
           DateTime MyDateTime=DateTime.Now;
        //    Console.WriteLine(MyDateTime);
        //    Console.WriteLine($"My current time in short format is {MyDateTime.ToShortTimeString()}");
        //    Console.WriteLine($"My current date in short format is {MyDateTime.ToShortDateString()}");
        //     Console.WriteLine($"My current time in short format is {MyDateTime.ToLongTimeString()}");
        //    Console.WriteLine($"My current date in short format is {MyDateTime.ToLongDateString()}");
           Console.WriteLine($"The day 5 years ago from today was {MyDateTime.AddYears(-5).DayOfWeek}");
           Console.WriteLine(MyDateTime.Year);
           Console.WriteLine(MyDateTime.Month);
           Console.WriteLine(MyDateTime.DayOfWeek);
        }
    }
}
