using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Abstracts;
using Wild_Farm.Models.Interfaces;

namespace Wild_Farm.Models.Birds
{
    internal class Hen : Bird, IAnimalAction
    {
        // "{Type} {Name} {Weight} {WingSize}"
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        
        public override void Eat(string food, int qty)
        {

            this.FoodEaten += qty;
            this.Weight += qty * 0.35;


        }

        public override string ProduceSound()
        {
            return "Cluck";
        }

    }
}
