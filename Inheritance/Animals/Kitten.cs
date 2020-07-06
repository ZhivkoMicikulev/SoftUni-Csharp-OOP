using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {

        private const string Def_gender = "Female";
        public Kitten(string name, int age)
            : base(name, age, Def_gender)
        {

        }




        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
