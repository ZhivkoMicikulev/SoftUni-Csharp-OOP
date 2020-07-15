using P07.MilitaryElite.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Contracts
{
    public interface IMission
    {
        string CodeName { get; }

        State State { get; }

        void CompleteMission();
    }
}
