﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models.Heroes
{
    public class Warrior : BaseHero
    {
        private const int POWER = 100;
        public Warrior(string name) : base(name)
        {
            this.Power = POWER;
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name}"+$" - {this.Name} hit for {this.Power} damage";
        }
    }
}
