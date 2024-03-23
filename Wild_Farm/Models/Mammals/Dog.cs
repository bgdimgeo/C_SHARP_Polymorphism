using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Abstracts;
using Wild_Farm.Models.Interfaces;

namespace Wild_Farm.Models.Mammals
{
    public class Dog : Mammal, IAnimalAction
    {
        
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void Eat(string food, int qty)
        {
            if (food == "Meat")
            {
                this.FoodEaten += qty;
                this.Weight += qty * 0.40;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food}!");
            }
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
