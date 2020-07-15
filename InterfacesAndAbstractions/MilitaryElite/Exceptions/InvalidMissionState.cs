using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Exceptions
{
    public class InvalidMissionState : Exception
    {
        private const string DEF_EXC_MSG = "Invalid mission state!";
        public InvalidMissionState()
            :base(DEF_EXC_MSG)
        {
        }

        public InvalidMissionState(string message) : base(message)
        {
        }
    }
}
