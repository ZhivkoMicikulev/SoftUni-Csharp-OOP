using P07.MilitaryElite.Contracts;
using P07.MilitaryElite.Enumerations;
using P07.MilitaryElite.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName,string state)
        {
            this.CodeName = codeName;
            this.State = this.TryParseState(state);
        }
        public string CodeName { get; private set; }

        public State State { get; private set; }

        public void CompleteMission()
        {
            if (this.State==State.Finished)
            {
                throw new InvalidMissionException();
            }
            this.State = State.Finished;
        }

        private State TryParseState(string stateStr)
        {
            State state;
            bool parsed = Enum.TryParse<State>(stateStr, out state);
            if (!parsed)
            {
                throw new InvalidMissionState();
            }
            return state;

        }

        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {State.ToString()}";
        }
    }
}
