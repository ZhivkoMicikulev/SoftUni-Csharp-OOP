using P05.FootballTeamGenerator.Common;
using P05.FootballTeamGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05.FootballTeamGenerator.Core
{
    public class Engine
    {
        private List<Team> teams;
        public Engine()
        {
            this.teams = new List<Team>();
        }

        public void Run()
        {
            string cmd;
            while ((cmd=Console.ReadLine())!="END")
            {
                try
                {
                    var cmdArgs = cmd
                   .Split(';', StringSplitOptions.None)
                   .ToArray();

                    var cmdType = cmdArgs[0];

                    if (cmdType == "Team")
                    {
                        AddTeam(cmdArgs);
                    }
                    else if (cmdType == "Add")
                    {
                        AddPlayerToTeam(cmdArgs);

                    }
                    else if (cmdType == "Remove")
                    {
                        RemovePlayer(cmdArgs);

                    }
                    else if (cmdType == "Rating")
                    {
                        PrintRating(cmdArgs);
                    }
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
                
            }
        }

        private void PrintRating(string[] cmdArgs)
        {
            var teamName = cmdArgs[1];

            ValidateTeamExist(teamName);
            var team = teams.First(t => t.Name == teamName);

            Console.WriteLine(team);
        }

        private void RemovePlayer(string[] cmdArgs)
        {
            var teamName = cmdArgs[1];
            var playerName = cmdArgs[2];

            ValidateTeamExist(teamName);
            var team = teams.First(a => a.Name == teamName);

            team.RemovePlayer(playerName);
        }

        private void AddPlayerToTeam(string[] cmdArgs)
        {
            var teamName = cmdArgs[1];
            var playerName = cmdArgs[2];

            ValidateTeamExist(teamName);
            var team = teams.First(a => a.Name == teamName);
            Stats stats = this.CreateStats(cmdArgs.Skip(3).ToArray());

            var player = new Player(playerName, stats);
            team.AddPlayer(player);
        }

        private Stats CreateStats(string[] cmdArgs)
        {
            var endurance = int.Parse(cmdArgs[0]);
            var sprint = int.Parse(cmdArgs[1]);
            var drible = int.Parse(cmdArgs[2]);
            var passing= int.Parse(cmdArgs[3]);
            var shooting = int.Parse(cmdArgs[4]);
            var stats = new Stats(endurance, sprint, drible, passing, shooting);
            return stats;

        }
        
        private void ValidateTeamExist(string name)
        {
            if (!teams.Any(t=>t.Name==name))
            {
                throw new ArgumentException
                    (string.Format
                    (ExeptionMessages.MissingTeam,name));
            }
        }

        private void AddTeam(string[] cmdArgs)
        {
            var teamName = cmdArgs[1];

            var team = new Team(teamName);
            teams.Add(team);
        }
    }
}
