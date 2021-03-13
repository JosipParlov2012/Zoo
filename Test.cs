using Zoo.Animals;

using System;
using System.Collections.Generic;

namespace Zoo
{
    
    public static class Test
    {
        
        private static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            
            // Add animals.
            animals.Add(new Snake());
            animals.Add(new Dog());
            animals.Add(new Cat());
            
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.GetType().UnderlyingSystemType.Name);
                animal.Talk();
                animal.Move();
                Console.WriteLine();
            }
        }

    }
    
}
