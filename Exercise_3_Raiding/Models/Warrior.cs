using Exercise_3_Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3_Raiding.Models
{
    public class Warrior : Hero
    {
     
        public Warrior(string name) :base(name)
        {
            this.Power = 100;
        }
        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
        
}
