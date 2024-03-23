using Exercise_3_Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3_Raiding.Models
{
    public abstract class Hero : IHero
    {
        
        private string name;
        private int power;

        public Hero(string name)
        {
            this.Name = name;

        }

        public string Name { get { return this.name; } set { this.name = value; } }
        public int Power { get { return this.power; } set { this.power = value; } }

        public abstract string CastAbility();
        

      
        
    }
}
