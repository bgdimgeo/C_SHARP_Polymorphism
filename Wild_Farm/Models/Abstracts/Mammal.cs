using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Models.Abstracts
{
    public abstract class Mammal:Animal
    {
        private string livingRegion;
        public string LivingRegion { get { return this.livingRegion; } set { this.livingRegion = value; } }
        //{Type} {Name} {Weight} {LivingRegion}
        public Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight:f1}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        
    }
}
