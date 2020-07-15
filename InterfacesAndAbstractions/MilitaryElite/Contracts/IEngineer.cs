using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Contracts
{
    public interface IEngineer:ISpecialisedSoldier
    {
        IReadOnlyCollection<IRepair> Repairs { get; }

        void AddRepair(IRepair repair);
    }
}
