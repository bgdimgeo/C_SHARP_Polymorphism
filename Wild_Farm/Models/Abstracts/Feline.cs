﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Models.Abstracts
{
    public abstract class Feline : Mammal
    {
        private string breed;
      
        public Feline(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion)
        {
            this.Breed = breed;
            }
        public string Breed { get { return this.breed; } set { this.breed = value; } }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight:f1}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}