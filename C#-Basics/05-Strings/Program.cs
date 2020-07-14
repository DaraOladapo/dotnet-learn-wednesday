using System;

namespace _05_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome to this application. Let's get rolling.");
            // Console.WriteLine("Input a number: ");
            // int myFirstNumber=int.Parse(Console.ReadLine());
            // Console.WriteLine("Input another number: ");
            // int mySecondNumber=int.Parse(Console.ReadLine());
            // int mySum=myFirstNumber+mySecondNumber;
            // Console.WriteLine("The sum of "+ myFirstNumber + " and "+ mySecondNumber + " is " + mySum);
            // Console.WriteLine("The sum of {0} and {1} is {2}", myFirstNumber, mySecondNumber, mySum);
            // Console.WriteLine($"The sum of {myFirstNumber} and {mySecondNumber} is {mySum}");

            //escape sequences
            Console.WriteLine("I am a \ttab");
            Console.WriteLine("I am on a \nnew line");

            Console.WriteLine("I am an \"");

            string someString="Dara";
            Console.WriteLine(someString[3]);
        }
    }
}
