using Raiding.Exceptions;
using Raiding.Models.Contracts;
using Raiding.Models.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Factory
{
   public class HeroFactory

    {
        public IBaseHero ProduceHero(string name,string type)
        {
            IBaseHero hero = null;
            if (type=="Druid")                
            {
                hero = new Druid(name);

            }
            else if (type=="Paladin")
            {
                hero = new Paladin(name);
            }
            else if (type == "Rogue")
            {
                hero = new Rogue(name);
            }
            else if (type == "Warrior")
            {
                hero = new Warrior(name);
            }
            else
            {
                throw new InvalidHero();
            }
            return hero;
        }
       

    }
}
