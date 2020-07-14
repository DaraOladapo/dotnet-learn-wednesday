using System;
using System.Collections.Generic;

namespace _09_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
        // int[] MyIntArray=new int[5];
        // MyIntArray[4]=1;
        // int[] MyIntArray={1,5,8,5,8,5,9};
        // for (int i = 0; i < MyIntArray.Length; i++)
        // {
        //     Console.WriteLine(MyIntArray[i]);
        // }
        List<int> MyIntList=new List<int>(){1,2,3,45,6,67,7};
        foreach (var IntElement in MyIntList)
        {
         Console.WriteLine(IntElement);
        }
        }
    }
}
