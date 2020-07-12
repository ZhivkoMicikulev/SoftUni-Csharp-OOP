using P04.PizzaCalories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.PizzaCalories.Models
{
    public class Topping
    {
        private string type;
        private int weight;

        public Topping(string type,int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get => this.type;
            private set
            {
                ValidateToping(value);
                this.type = GlobalConstants.PizzaInfo[value.ToLower()];
            }
        }

        public int Weight
        {
            get => this.weight;
            private set
            {
                if (value<GlobalConstants.WEIGHT_MIN_TOPPING||value>GlobalConstants.WEIGHT_MAX_TOPPING)
                {
                    var message = string.Format(GlobalConstants.INVALID_WEIGHT_TOPPING, this.Type, GlobalConstants.WEIGHT_MIN_TOPPING, GlobalConstants.WEIGHT_MAX_TOPPING);
                    throw new ArgumentException(message);
                }
                this.weight = value;
            }
        }

        public double Calories
            => (2 * Weight) * GlobalConstants.PizzaCaloriesInfo[Type];


        private static void ValidateToping(string value)
        {
            if (string.IsNullOrEmpty(value)
                || string.IsNullOrWhiteSpace(value)
                || !GlobalConstants.PizzaInfo.ContainsKey(value.ToLower()))
            {
                var message = string.Format(GlobalConstants.INVALID_TOPING,value);
                throw new ArgumentException(message);
            }
        }
    }
}
