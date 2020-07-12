using P04.PizzaCalories.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04.PizzaCalories.Models
{
   public class Dough
    {

        private string floar;
        private string bake;
        private int weight;

        public Dough(string floar,string bake,int weight)
        {
            this.Floar = floar;
            this.Bake = bake;
            this.Weight = weight;
        }

        public string Floar
        {
            get => this.floar;
            private set
            {
                ValidateDough(value);
                this.floar = GlobalConstants.PizzaInfo[value.ToLower()];

            }
        }
        public string Bake
        {
            get => this.bake;
            private set
            {
                ValidateDough(value);
                this.bake = GlobalConstants.PizzaInfo[value.ToLower()];

            }
        }

        public int Weight
        {
            get => this.weight;
            private set
            {
                if (value<GlobalConstants.WEIGHT_MIN_DOUGH ||value>GlobalConstants.WEIGHT_MAX_DOUGH)
                {
                    var message = string.Format(GlobalConstants.INVALID_WEIGHT, GlobalConstants.WEIGHT_MIN_DOUGH, GlobalConstants.WEIGHT_MAX_DOUGH);
                    throw new ArgumentException(message);
                }
                this.weight = value;
            }
        }

        public double Calories => (2 * Weight) * GlobalConstants.PizzaCaloriesInfo[Floar] * GlobalConstants.PizzaCaloriesInfo[Bake];

        private static void ValidateDough(string value)
        {
            if (string.IsNullOrEmpty(value)
                || string.IsNullOrWhiteSpace(value)
                || !GlobalConstants.PizzaInfo.ContainsKey(value.ToLower()))
            {
                throw new ArgumentException(GlobalConstants.INVALID_DOUGH);
            }
        }
    }
}
