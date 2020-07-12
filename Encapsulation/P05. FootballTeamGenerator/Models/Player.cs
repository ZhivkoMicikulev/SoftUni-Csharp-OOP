using P05.FootballTeamGenerator.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace P05.FootballTeamGenerator
{
  public  class Player
    {
        private string name;
        
        public Player(string name,Stats stats)
        {
            this.Name = name;
            this.Stats = stats;
        }
       
        public  string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExeptionMessages.EmptyName);
                }
                this.name = value;
            }
        }

        public Stats Stats { get;private set; }

        public double OverrollSkill => this.Stats.AverageStats;

    }
}
