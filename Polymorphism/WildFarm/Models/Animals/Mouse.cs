using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Mouse : Mammal
    {
        private const double WEIGHT_MULTY = 0.10;
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {

        }

        public override ICollection<Type> PrefferFood => new List<Type>
        { typeof(Vegetable),
        typeof(Fruit)};

        public override double WeightMultiplyer => WEIGHT_MULTY;
        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override string ToString()
        {
            return base.ToString() +
                $" {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
