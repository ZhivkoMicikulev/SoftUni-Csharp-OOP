using FoodStorage.Contractors;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodStorage.Models
{
    public class Rebel : IPerson,IBuyer
    {
        public Rebel(string name,int age,string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.BuyedFood = 0;
        }
        
        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Group { get;private set; }

        public int BuyedFood { get; private set; }

        public void BuyFood()
        {
            BuyedFood += 5;
        }
    }
}
