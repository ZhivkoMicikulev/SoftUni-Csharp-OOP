using Raiding.Models.Contracts;
using Raiding.Models.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Constants
{
  public static  class Colection
    {
        public static ICollection<Type> heroes = new List<Type>()
        {typeof(Druid),
            typeof(Paladin),
            typeof(Rogue),
            typeof(Warrior)
      };
    }
}
