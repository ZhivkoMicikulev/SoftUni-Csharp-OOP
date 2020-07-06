using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Beverages.Cold
{
    public class ColdBeverage : Beverages
    {
        public ColdBeverage(string name, decimal price, double mililiters) 
            : base(name, price, mililiters)
        {
        }
    }
}
