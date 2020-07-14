using System;

namespace _12_InitializingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
           Vehicle MyVehicle=new Vehicle();
           MyVehicle.Make="Toyota";
           MyVehicle.Model="CH-R";
           MyVehicle.Year=2020;
           MyVehicle.NumberOfTires=4;
           Console.WriteLine($"{MyVehicle.Make} {MyVehicle.Model} {MyVehicle.Year} has {MyVehicle.NumberOfTires} tires.");
        
          Vehicle MyOtherVehicle=new Vehicle(){
              Make="Tesla",
              Model="Model S",
              Year=2019,
              NumberOfTires=4
          };
           Console.WriteLine($"{MyOtherVehicle.Make} {MyOtherVehicle.Model} {MyOtherVehicle.Year} has {MyOtherVehicle.NumberOfTires} tires.");

        }
    }
    public class Vehicle{
        public Vehicle(){
            Console.WriteLine("Starting up...");
        }
       public string Make { get; set; } 
       public string Model { get; set; } 
       public int Year { get; set; } 
       public int NumberOfTires { get; set; } 
    }
}
