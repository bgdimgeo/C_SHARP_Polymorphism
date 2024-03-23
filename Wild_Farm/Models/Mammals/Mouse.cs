using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Abstracts;
using Wild_Farm.Models.Interfaces;

namespace Wild_Farm.Models.Mammals
{
    internal class Mouse : Mammal, IAnimalAction
    {
        //{AnimalType} [{AnimalName}, {AnimalWeight}, {AnimalLivingRegion}, {FoodEaten}]
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void Eat(string food, int qty)
        {
            if (food == "Vegetable" || food == "Fruit")
            {
                this.FoodEaten += qty;
                this.Weight += qty * 0.10;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food}!");
            }
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
