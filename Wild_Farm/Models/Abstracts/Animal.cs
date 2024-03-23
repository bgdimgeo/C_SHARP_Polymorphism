using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Interfaces;

namespace Wild_Farm.Models.Abstracts
{
    public abstract class Animal
    {
        private string name;
        private double weight;
        private int foodEaten;

        
        public Animal(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
            this.FoodEaten = 0;
        }
        public int FoodEaten { get { return this.foodEaten; } set { this.foodEaten = value; } }
        public double Weight { get { return this.weight; } set { this.weight = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }

        public abstract void Eat(string food, int qty);
        public abstract string ProduceSound();



    }
}
