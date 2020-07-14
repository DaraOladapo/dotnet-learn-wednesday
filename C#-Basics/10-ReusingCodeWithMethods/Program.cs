using System;

namespace _10_ReusingCodeWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
           int A=int.Parse(Console.ReadLine());
           int B=int.Parse(Console.ReadLine());
           //Add(A,B);
           int C=Add(A,B);
           Console.WriteLine($"The sum of {A} and {B} is {C}");
        }
        //does not return a value/object
        // static void Add(int A, int B)
        // {
        //    Console.WriteLine($"The sum of {A} and {B} is {A+B}"); 
        // }
        //returns a value/object
        static int Add(int A,int B){
            int C=A+B;
            return C;
        }
    }
}
