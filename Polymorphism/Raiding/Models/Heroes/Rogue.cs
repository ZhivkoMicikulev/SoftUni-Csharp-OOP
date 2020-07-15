
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models.Heroes
{
    public class Rogue : BaseHero
    {
        private const int POWER = 80;
        public Rogue(string name) 
       
            : base(name)
        {
            this.Power = POWER;
        }

        public override string CastAbility()
        {
           return $"Rogue - {this.Name} hit for {this.Power} damage";
        }
    }
}
