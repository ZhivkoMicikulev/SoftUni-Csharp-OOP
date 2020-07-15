using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;
using WildFarm.Models.Foods.Contracts;

namespace WildFarm.Factorys
{
 public   class FoodFactory
    {
        public IFood ProduceFood(string type,int quantity)
        {
            IFood food = null;
            if (type=="Vegetable")
            {
                food = new Vegetable(quantity);
            }
          else  if (type == "Fuit")
            {
                food = new Fruit(quantity);
            }
            else if (type == "Meat")
            {
                food = new Meat(quantity);
            }
            else if (type == "Seeds")
            {
                food = new Seeds(quantity);
            }
            return food;
        }
    }
}
