using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Exceptions
{
    public  class InvalidHero :Exception
    {
        public const string INVALID_HERO = "Invalid hero!";

        public InvalidHero():base(INVALID_HERO)
        {
          
        }

        public InvalidHero(string message) : base(message)
        {
        }
    }
}
