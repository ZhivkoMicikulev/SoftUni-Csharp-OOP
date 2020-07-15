using P07.MilitaryElite.Contracts;
using P07.MilitaryElite.Enumerations;
using P07.MilitaryElite.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, 
            string firstName,
            string lastName,
            decimal salary,
            string corps) : base(id, firstName, lastName, salary)
        {
            this.Corps = this.TryParse(corps);
        }

        public Corps Corps { get; private set; }

        private Corps TryParse(string corpsStr)
        {
            Corps corps;

            bool parsed = Enum.TryParse<Corps>(corpsStr,out corps);
            if (!parsed)
            {
                throw new InvalidCorpsException();
            }
            return corps;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                $"Corps: {Corps.ToString()}";
        }
    }
}
