﻿using System;

namespace _15_Overloading
{
    class Program
    {
        // static int PlusMethodInt(int x, int y)
        // {
        //     return x + y;
        // }

        // static double PlusMethodDouble(double x, double y)
        // {
        //     return x + y;
        // }

        static void Main(string[] args)
        {
            // int myNum1 = PlusMethodInt(8, 5);
            // double myNum2 = PlusMethodDouble(4.3, 6.26);
            // Console.WriteLine("Int: " + myNum1);
            // Console.WriteLine("Double: " + myNum2);

            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
    }
}
