using P04.BorderControl.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.BorderControl.Models
{
    public class Pet : IPet, IBirthdate
    {
        public Pet(string name,string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
        public string Birthdate { get; private set; }

        public string Name { get; private set; }
    }
}
