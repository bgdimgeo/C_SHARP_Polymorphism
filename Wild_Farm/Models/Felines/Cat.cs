using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Abstracts;
using Wild_Farm.Models.Interfaces;

namespace Wild_Farm.Models.Felines
{
    public class Cat : Feline, IAnimalAction
    {
        //{Type} {Name} {Weight} {LivingRegion} {Breed}
        public Cat(string name,double weight,  string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(string food, int qty)
        {
            if (food == "Meat" || food == "Vegetable")
            {
                this.FoodEaten += qty;
                this.Weight += qty*0.30;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food}!");
            }
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
