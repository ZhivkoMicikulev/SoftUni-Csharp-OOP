using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Beverages.Hot
{
    public class Coffee : HotBeverage
    {
        private const double CoffeMilliters = 50;
        private const decimal CoffeePrice = 3.5m;
        public Coffee(string name,
            decimal price,
            double mililiters,
            double caffeine)
            : base(name, CoffeePrice, CoffeMilliters)
        {
            this.Caffeine = caffeine;
        }
        public double Caffeine { get; set; }

    }
}
