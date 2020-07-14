using System;

namespace _04_BasicDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            var UserInput=Console.ReadLine();
            int myValue;
            var myValueResult=int.TryParse(UserInput,out myValue);
            if(myValueResult==true)
            {
                Console.WriteLine(myValue);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
