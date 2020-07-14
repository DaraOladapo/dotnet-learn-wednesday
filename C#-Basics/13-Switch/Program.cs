using System;

namespace _13_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
        //    string UserInput=Console.ReadLine();
        //    switch (UserInput)
        //    {
        //      case "A":
        //      Console.WriteLine("a");
        //      break;  
        //     case "B":
        //      Console.WriteLine("b");
        //     break;
        //     default:
        //      Console.WriteLine("c-z");
        //     break; 
        //    }
        int UserInput=int.Parse(Console.ReadLine());
        switch (UserInput)
        {
            case 1:
             Console.WriteLine("a");
             break;
            case 2:
             Console.WriteLine("b");
            break;
            case 3:
            case 4:
            case 5:
             Console.WriteLine("c-e");            
            break;
            default:
            Console.WriteLine("f-z");
            break;
        }
        }
    }
}
