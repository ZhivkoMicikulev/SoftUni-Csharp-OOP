using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
   

    public class Hen : Bird
    {
        private const double WEIGHT_MULTY = 0.35;

        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override ICollection<Type> PrefferFood => new List<Type>
        { typeof(Vegetable),
        typeof(Fruit),
        typeof(Meat),
        typeof(Seeds)};

        public override double WeightMultiplyer => WEIGHT_MULTY;
        public override string ProduceSound()
        {
            return $"Cluck";
        }
    }
}
