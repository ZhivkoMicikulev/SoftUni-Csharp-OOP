using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Food.Desert
{
    public class Cake : Dessert
    {
        private const double CakeGrams = 250;
        private const double CakeCalories = 1000;
        private const decimal CakePrice = 5.0m;
        public Cake(string name, decimal price, double grams, double calories) 
            : base(name, CakePrice,CakeGrams,CakeCalories)
        {

        }
    }
}
