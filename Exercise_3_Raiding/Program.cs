using Exercise_3_Raiding.Factory;
using Exercise_3_Raiding.Models;
using System;
using System.Collections.Generic;

namespace Exercise_3_Raiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Hero> heroes = new List<Hero>();
            int n = int.Parse(Console.ReadLine());
            ConcreteHeroFactory factory = new ConcreteHeroFactory();
            for (int i = 0; i < n; i++)
            {
                
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                Hero hero = factory.CreateHero(type, name);
                heroes.Add(hero);
                Console.WriteLine(hero.CastAbility());
            }

            int bossPower = int.Parse(Console.ReadLine());
            int heroesPower = 0;
            foreach (var kvp in heroes)
            {
                heroesPower += kvp.Power;
            }
            if (heroesPower > bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else 
            {
                Console.WriteLine("Defeat...");
            }

        }
    }
}
