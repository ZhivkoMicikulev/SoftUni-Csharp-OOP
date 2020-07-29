﻿using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string COMMAND_POSTFIX = "Command";
        
        public CommandInterpreter()
        {

        }
        
        public string Read(string args)
        {
            string[] commandTokens = args
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            var commandName = commandTokens[0]+COMMAND_POSTFIX;
            var commandArgs = commandTokens.Skip(1)
                .ToArray();
           

            Assembly assembly = Assembly.GetCallingAssembly();
            Type commandType = assembly.GetTypes()
                .FirstOrDefault(
                t => t.Name.ToLower()==commandName.ToLower()
                );

            if (commandType==null)
            {
                throw new ArgumentException("Invalid command type !");
            }


            ICommand commandInstance = (ICommand)Activator.CreateInstance(commandType);


                var result = commandInstance.Execute(commandArgs);

            return result;
        }
    }
}
