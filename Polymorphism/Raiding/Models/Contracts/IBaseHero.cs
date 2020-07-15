using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models.Contracts
{
  public  interface IBaseHero
    {
        string Name { get; }
        int Power { get; }

        string CastAbility()
        {
            return $"{GetType().Name} - {this.Name} healed for {this.Power}";
        }
        
    }
}
