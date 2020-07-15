
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models.Heroes
{
    public class Druid : BaseHero
    {
        private const int POWER = 80;

        public Druid(string name) 
            : base(name)
        {
            this.Power = POWER;
        }
        
       

        public override string CastAbility()
        {

            return $"Druid - {this.Name} healed for {this.Power}";
        }
    }
}
