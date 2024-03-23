using Exercise_3_Raiding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3_Raiding.Factory
{
    public abstract class HeroFactory
    {
        public abstract Hero CreateHero(string type, string name);
    }
}
