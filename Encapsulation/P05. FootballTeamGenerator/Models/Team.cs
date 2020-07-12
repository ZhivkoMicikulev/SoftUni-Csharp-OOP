using P05.FootballTeamGenerator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05.FootballTeamGenerator.Models
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team()
        {
            this.players = new List<Player>();
        }
        public Team(string name)
            :this()
        {
            this.Name = name;
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
        public int Rating 
        {
            get
            {
                if (this.players.Count==0)
                {
                    return 0;
                }
                else
                {
                   return (int)Math.Round(this.players.Sum(o => o.OverrollSkill) / this.players.Count);

                }
            }
        }


        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string name)
        {
            if (!players.Any(p=>p.Name==name))
            {
                throw new InvalidOperationException(string.Format
                    (ExeptionMessages.RemovingMIssingPlayer, name, this.Name));
            }
            var player = players.FirstOrDefault(n => n.Name == name);
            this.players.Remove(player);

        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }

    }
}
