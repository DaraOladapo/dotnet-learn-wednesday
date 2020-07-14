using System;

namespace _14_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
        //   var MyDay=(int)DaysOfTheWeek.Tuesday;
        //   Console.WriteLine(MyDay);
        var CurrentMonth=Months.July;
        switch (CurrentMonth)
        {
            case Months.January:
            case Months.February:
            case Months.March:
            case Months.April:     
            case Months.May:
            case Months.June:
            Console.WriteLine("First Half");
            break;
            case Months.July:
            case Months.August:
            case Months.September:
            case Months.October:
            case Months.November:
            case Months.December:
            Console.WriteLine("Second Half");
            break;
        }
        }
        enum Months{
            January=1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        enum DaysOfTheWeek
        {
            Sunday=1,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
