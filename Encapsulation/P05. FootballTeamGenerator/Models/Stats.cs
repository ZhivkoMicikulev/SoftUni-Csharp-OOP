using P05.FootballTeamGenerator.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace P05.FootballTeamGenerator
{
   public class Stats
    {
        private const int MIN_STAT = 0;
        private const int MAX_STAT = 100;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        public Stats(int endu,int sprint,int drible,int pass,int shoot)
        {
            this.Endurance = endu;
            this.Sprint = sprint;
            this.Dribble = drible;
            this.Passing = pass;
            this.Shooting = shoot;
        }
        public int Endurance
        {
            get=> this.endurance;
            private set
            {
                ValidateStat(value,nameof(this.Endurance));
                this.endurance = value;
            }
        }
        public int Sprint
        {
            get => this.sprint;
            private set
            {
                ValidateStat(value, nameof(this.Sprint));
                 this.sprint = value;
            }
        }
        public int Dribble
        {
            get => this.dribble;
            private set
            {
                ValidateStat(value, nameof(this.Dribble));
                this.dribble = value;
            }
        }

        public int Passing
        {
            get => this.passing;
            private set
            {
                ValidateStat(value, nameof(this.Passing));
                this.passing = value;
            }
        }
        public int Shooting
        {
            get => this.shooting;
            private set
            {
                ValidateStat(value, nameof(this.Shooting));
                this.shooting = value;
            }
        }

        public double AverageStats => (Endurance + Dribble + Sprint + Passing + Shooting) / 5.0;
        private void ValidateStat(int value,string statName)
        {
            if (value < MIN_STAT || value > MAX_STAT)
            {
                throw new ArgumentException(string.Format
                    (ExeptionMessages.InvalidStatMessage,
                    statName,
                    MIN_STAT, MAX_STAT));
            }
        }

       


      
    }
}
