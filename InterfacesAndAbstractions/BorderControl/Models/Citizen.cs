﻿using P04.BorderControl.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.BorderControl.Models
{
    public class Citizen : ICitizen, IId, IBirthdate
    {
        public Citizen(string name,int age, string id,string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }
        public string Birthdate { get; private set; }
    }
}
