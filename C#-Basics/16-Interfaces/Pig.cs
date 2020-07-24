using System;

namespace _16_Interfaces
{
    public class Pig : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Animal is making a sound.");
        }
        public void Breath()
        {
            Console.WriteLine("Animal is breathing.");
        }
    }
}
