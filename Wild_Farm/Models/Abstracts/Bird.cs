using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Models.Abstracts
{
    public abstract class Bird : Animal
    {
        private double wingSize;
        public double WingSize { get { return this.wingSize; } set { this.wingSize = value; } }
        //"{Type} {Name} {Weight} {WingSize}"
        public Bird(string name, double weight,double wingSize) : base(name, weight)
        {
           this.WingSize = wingSize;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize:f2}, {this.Weight:f1}, {this.FoodEaten}]";
        }

       
    }
}
