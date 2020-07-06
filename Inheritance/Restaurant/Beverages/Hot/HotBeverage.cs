using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Beverages.Hot
{
    public class HotBeverage : Beverages
    {
        public HotBeverage(string name, decimal price, double mililiters) 
            : base(name, price, mililiters)
        {
        }
    }
}
