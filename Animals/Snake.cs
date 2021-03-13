using System;

namespace Zoo.Animals
{
    
    public class Snake : Animal
    {
        
        public override void Talk()
        {
            Console.WriteLine("Hhhsssssssss!");
        }

        public override void Move()
        {
            Console.WriteLine("*Slithers*");
        }
        
    }
    
}
