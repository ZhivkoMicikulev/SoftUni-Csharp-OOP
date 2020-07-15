using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Dog : Mammal
    {
        private const double WEIGHT_MULTY = 0.40;
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override ICollection<Type> PrefferFood => new List<Type>()
        { typeof(Meat)};


        public override double WeightMultiplyer => WEIGHT_MULTY;
        public override string ProduceSound()
        {
            return "Woof!";
        }

        public override string ToString()
        {
            return base.ToString() +
                $" {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
