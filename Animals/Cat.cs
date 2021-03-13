using System;

namespace Zoo.Animals
{
    
    public class Cat : Animal
    {
        
        public override void Talk()
        {
            Console.WriteLine("Meow!");
        }

        public override void Move()
        {
            Console.WriteLine("*Walks*");
        }
        
    }
    
}
