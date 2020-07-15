using P04.BorderControl.Contracts;
using P04.BorderControl.Core.Contracts;
using P04.BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04.BorderControl.Core
{
    public class Engine : IEngine
    {      
        public void Run()
        {
            string cmd;
            var data = new List<IBirthdate>(); 
            
            while ((cmd=Console.ReadLine())!="End")
            {
                var cmdArg = cmd
                    .Split()
                    .ToArray();
                IBirthdate person = null;
                var type = cmdArg[0];
                if (type=="Pet")
                {
                    var name = cmdArg[1];
                    var birthdate = cmdArg[2];
                    person = new Pet(name,birthdate);
                }
                else if (type=="Citizen")
                {
                    var name = cmdArg[1];
                    var age = int.Parse(cmdArg[2]);
                    var id = cmdArg[3];
                    var birthdate = cmdArg[4];
                    person = new Citizen(name, age, id, birthdate);
                }
                if (person!=null)
                {
                    data.Add(person);
                }
                
            }
            var wantedYear = Console.ReadLine();
            foreach (var person in data)
            {
                
                if (person.Birthdate.EndsWith(wantedYear))
                {
                    Console.WriteLine(person.Birthdate);
                }
            }
           
        }
    }
}
