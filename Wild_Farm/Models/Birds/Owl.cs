using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Abstracts;
using Wild_Farm.Models.Interfaces;

namespace Wild_Farm.Models.Birds
{
    internal class Owl : Bird, IAnimalAction
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void Eat(string food,int qty)
        {
            if (food == "Meat")
            {
                this.FoodEaten += qty;
                this.Weight += qty * 0.25;
            }
            else 
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food}!");
            }
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
