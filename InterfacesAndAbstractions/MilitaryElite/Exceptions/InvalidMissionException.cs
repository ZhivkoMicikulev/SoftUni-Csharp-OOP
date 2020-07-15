using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Exceptions
{
    public class InvalidMissionException : Exception
    {
        private const string DEF_EXC_MSG = "Mission already completed!";
        public InvalidMissionException()
            :base(DEF_EXC_MSG)
        {
        }

        public InvalidMissionException(string message) : base(message)
        {
        }
    }
}
