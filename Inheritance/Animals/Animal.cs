using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
   public  abstract class Animal
    {
        private const string ERROR_MESSAGE = "Invalid input!";
        private string name;
        private int age;
        private string gender;
        public Animal(string name,int age,string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException
                        (ERROR_MESSAGE);
                }
                else
                {
                    this.name = value; 
                }
            }
        }
        public int Age
        {
            get
            {
                return this.age;

            }
           private set
            {
                if (value<0)
                {
                    throw new ArgumentException
                        (ERROR_MESSAGE);
                }
                else
                {
                    this.age = value;
                }
            }
        }
        public virtual string Gender
        {
            get
            {
                return this.gender;

            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value)||(value!="Male" && value!="Female"))
                {
                    throw new ArgumentException(ERROR_MESSAGE);
                }
                else
                {
                    this.gender = value;
                }
            }
        }
        public abstract string ProduceSound();
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}")
                .AppendLine($"{Name} {Age} {Gender}")
                .AppendLine($"{this.ProduceSound()}");
            return sb.ToString().TrimEnd();
        }

    }
}
