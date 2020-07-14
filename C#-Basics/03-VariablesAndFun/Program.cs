using System;

namespace _03_VariablesAndFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this application. Let's get rolling.");
            Console.WriteLine("Input a number: ");
            int myFirstNumber=int.Parse(Console.ReadLine());
            //int myFirstNumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input another number: ");
            int mySecondNumber=int.Parse(Console.ReadLine());
            int mySum=myFirstNumber+mySecondNumber;
            Console.WriteLine($"The sum of {myFirstNumber} and {mySecondNumber} is {mySum}");

            //valid variable names
            int MyInt;
            int myInt;
            int _09MyInt;
            int My_Int;
            int My9Int;
            int My_9_Int;
        }
    }
}
