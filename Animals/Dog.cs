using System;

namespace Zoo.Animals
{
    
    public sealed class Dog : Animal
    {
        
        public override void Talk()
        {
            Console.WriteLine("Woof!");
        }

        public override void Move()
        {
            Console.WriteLine("*Rolls*");
        }
        
    }
    
}
