using System;
using System.Collections.Generic;
using System.Linq;
using Wild_Farm.Models.Abstracts;
using Wild_Farm.Models.Birds;
using Wild_Farm.Models.Felines;
using Wild_Farm.Models.Mammals;

namespace Wild_Farm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Animal> animals = new List<Animal>();
            int index = 0;

            while (input != "End") 
            {
                
                string[] animalArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
               if (animalArgs[0] == "Cat") 
                {
                    //{Type} {Name} {Weight} {LivingRegion} {Breed}
                    Cat currAnimal = new Cat(animalArgs[1], double.Parse(animalArgs[2]), animalArgs[3], animalArgs[4]);
                    Console.WriteLine(currAnimal.ProduceSound());
                    animals.Add(currAnimal);
                    Eat(currAnimal);
                }
                else if (animalArgs[0] == "Tiger")
                {
                    //{Type} {Name} {Weight} {LivingRegion} {Breed}
                    Tiger currAnimal = new Tiger(animalArgs[1], double.Parse(animalArgs[2]), animalArgs[3], animalArgs[4]);
                    Console.WriteLine(currAnimal.ProduceSound());
                    animals.Add(currAnimal);
                    Eat(currAnimal);
                }
                else if (animalArgs[0] == "Dog")
                {
                    
                    Dog currAnimal = new Dog(animalArgs[1], double.Parse(animalArgs[2]), animalArgs[3]);
                    Console.WriteLine(currAnimal.ProduceSound()); 
                    animals.Add(currAnimal);
                    Eat(currAnimal);
                }
                else if (animalArgs[0] == "Mouse")
                {                    
                    Mouse currAnimal = new Mouse(animalArgs[1], double.Parse(animalArgs[2]), animalArgs[3]);
                    Console.WriteLine(currAnimal.ProduceSound());
                    animals.Add(currAnimal);
                    Eat(currAnimal);
                }
                else if (animalArgs[0] == "Hen")
                {
                    
                    Hen currAnimal = new Hen(animalArgs[1], double.Parse(animalArgs[2]), double.Parse(animalArgs[3]));
                    Console.WriteLine(currAnimal.ProduceSound());
                    animals.Add(currAnimal);
                    Eat(currAnimal);
                }
                else if (animalArgs[0] == "Owl")
                {
                    Owl currAnimal = new Owl(animalArgs[1], double.Parse(animalArgs[2]), double.Parse(animalArgs[3]));
                    Console.WriteLine(currAnimal.ProduceSound());
                    animals.Add(currAnimal);
                    Eat(currAnimal);
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in animals) 
            {
                Console.WriteLine(kvp.ToString());
            }
        }
        public static void Eat(Animal animal) 
        {
            string[] eatArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            animal.Eat(eatArgs[0], int.Parse(eatArgs[1]));
        }
    }
}
