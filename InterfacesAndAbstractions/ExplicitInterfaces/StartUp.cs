using ExplicitInterfaces.Contracts;
using ExplicitInterfaces.Models;
using System;
using System.Linq;

namespace ExplicitInterfaces
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string cmd;
            while ((cmd=Console.ReadLine())!="End")
            {
                var tokens = cmd.Split().ToArray();
                var name = tokens[0];
                var country = tokens[1];
                var age = int.Parse(tokens[2]);
                var citizen = new Citizen(name, country, age);
                IPerson person = citizen;
                IResident resident = citizen;
                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName()+" "+person.GetName());
                Console.WriteLine();

            }
        }
    }
}
