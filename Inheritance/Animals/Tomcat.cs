using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        private const string Def_gender = "Male";

        public Tomcat(string name, int age) 
            : base(name, age, Def_gender)
        {

        }
        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
