using Exercise_3_Raiding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3_Raiding.Factory
{
    internal class ConcreteHeroFactory:HeroFactory
    {
        public ConcreteHeroFactory():base()
        {

        }

        public override Hero CreateHero(string heroType, string heroName)
        {
            switch (heroType)
            {
                case "Druid":
                    return new Druid(heroName);
                case "Paladin":
                    return new Paladin(heroName);
                case "Warrior":
                    return new Warrior(heroName);
                case "Rogue":
                    return new Rogue(heroName);
                default:
                    throw new ApplicationException(string.Format("Invalid hero!"));
            }
        }
    }
}
