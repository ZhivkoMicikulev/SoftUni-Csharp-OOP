using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Core.Models.Comands
{
    public class ByeCommand : ICommand
    {
        public string Execute(string[] args)
        {
            return $"Bye , {args[0]}";
        }
    }
}
