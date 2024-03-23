using Exercise_3_Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3_Raiding.Models
{
    public class Rogue : Hero
    {


         public Rogue(string name) :base(name)
        {
            this.Power = 80;
        }
        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
        
}
