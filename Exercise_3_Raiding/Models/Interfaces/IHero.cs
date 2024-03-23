using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3_Raiding.Models.Interfaces
{
    public interface IHero
    {
        string Name { get; set; }
        int Power { get; set; }


        string CastAbility();
      
    }
}
