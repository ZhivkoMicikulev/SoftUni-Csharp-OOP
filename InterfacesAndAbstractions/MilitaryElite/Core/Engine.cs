using P07.MilitaryElite.Contracts;
using P07.MilitaryElite.Core.Contracts;
using P07.MilitaryElite.Exceptions;
using P07.MilitaryElite.IO.Contracts;
using P07.MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P07.MilitaryElite.Core
{
  public  class Engine:IEngine
    {
        private IReader reader;
        private IWriter writer;
        private ICollection<ISoldier> soldiers;
      private Engine()
        {
            this.soldiers = new List<ISoldier>();
        }
        
        public Engine(IReader reader,IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;

        }

        public void Run()
        {
            string command;
            while ((command=reader.ReadLine())!="End")
            {
                var cmdArg = command
                    .Split()
                    .ToArray();
                
                var solderType = cmdArg[0];
                var id = int.Parse(cmdArg[1]);
                var firstName = cmdArg[2];
                var lastName = cmdArg[3];

                ISoldier soldier = null;

                if (solderType=="Private")
                {
                    var salary = decimal.Parse(cmdArg[4]);
                    soldier = new Private(id, firstName, lastName, salary);
                }
                else if (solderType=="LieutenantGeneral")
                {
                    var salary = decimal.Parse(cmdArg[4]);
                    LieutenantGeneral general = new LieutenantGeneral(id, firstName, lastName, salary);
                    foreach (var pid in cmdArg.Skip(5))
                    {
                        ISoldier privateToAdd = this.soldiers
                            .First(s => s.Id == int.Parse(pid));
                        soldier = general;
                    }
                }
                else if (solderType=="Engineer")
                {
                    var salary = decimal.Parse(cmdArg[4]);
                    var corps = cmdArg[5];
                    try
                    {
                       IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);
                        var repairArg = cmdArg
                                 .Skip(6)
                                 .ToArray();
                        for (int i = 0; i < repairArg.Length; i+=2)
                        {
                            var partName = repairArg[i];
                            var hoursWorked = int.Parse(repairArg[i + 1]);
                            IRepair repair = new Repair(partName, hoursWorked);
                            engineer.AddRepair(repair);
                        }
                    }
                    catch (InvalidCorpsException )
                    {

                        continue;
                    }
                    

                }
                else if (solderType=="Commando")
                {
                    var salary = decimal.Parse(cmdArg[4]);
                    var corps = cmdArg[5];
                    try
                    {
                        ICommando commando = new Commando(id, firstName, lastName, salary, corps);

                        var missionArg = cmdArg
                            .Skip(6)
                            .ToArray();

                        for (int i = 0; i < missionArg.Length; i+=2)
                        {
                            try
                            {
                                var missionCode = missionArg[i];
                                var missionState = missionArg[i + 1];
                                IMission mission = new Mission(missionCode, missionState);
                                commando.AddMission(mission);
                            }
                            catch (InvalidMissionState)
                            {

                                continue;
                            }
                          

                        }
                        soldier = commando;
                    }
                    catch (InvalidCorpsException)
                    {

                        continue;
                    }

                }
                else if (solderType=="Spy")
                {

                    var codeNumber = int.Parse(cmdArg[4]);
                    soldier = new Spy(id, firstName, lastName, codeNumber);

                }
                if (soldier!=null)
                {
                    this.soldiers.Add(soldier);
                }
                
              

            }
            foreach (var soldier in soldiers)
            {
                writer.WriteLine(soldier.ToString());
            }
        }
    }
}
