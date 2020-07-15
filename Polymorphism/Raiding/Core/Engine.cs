using Raiding.Exceptions;
using Raiding.Constants;
using Raiding.Core.Contracts;
using Raiding.Factory;
using Raiding.Models.Contracts;
using Raiding.Models.Heroes;
using System;
using System.Collections.Generic;

using System.Text;

namespace Raiding.Core
{

    public class Engine : IEngine
    {
        private ICollection<IBaseHero> heroes;
        private HeroFactory factory;
        public Engine()
        {
            this.factory = new HeroFactory();
            this.heroes = new List<IBaseHero>();
        }
        public void Run()
        {
            var n = int.Parse(Console.ReadLine());
            var powerOfHeroes = 0;
            while (heroes.Count!=n)
            {
                var heroName = Console.ReadLine();
               var heroType = Console.ReadLine();
                try
                {
                    IBaseHero hero = factory.ProduceHero(heroName, heroType);
                    heroes.Add(hero);
                    powerOfHeroes += hero.Power;
                }
                catch (InvalidHero eio)
                {
                    Console.WriteLine(eio.Message);
                }                               
            }
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }

            var enemyPower = int.Parse(Console.ReadLine());
            if (powerOfHeroes>=enemyPower)
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
