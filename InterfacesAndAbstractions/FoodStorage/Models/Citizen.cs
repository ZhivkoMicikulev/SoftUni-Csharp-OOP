using FoodStorage.Contractors;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodStorage.Models
{
    public class Citizen : IPerson,IBuyer
    {
        public Citizen(string name,int age,string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Birthdate = birthdate;
            this.Id = id;
            this.BuyedFood = 0;
        }
        public string Name { get; private set; }

        public int Age { get; private set; }

       public string Id { get; private set; }
        public string Birthdate { get;private set; }

        public int BuyedFood { get; private set; }

        public void BuyFood()
        {
            BuyedFood += 10;
        }
    }
}
