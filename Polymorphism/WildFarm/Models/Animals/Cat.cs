using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    class Cat : Feline
    {
        private const double WEIGHT_MULTY = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override ICollection<Type> PrefferFood => new List<Type>()
        { typeof(Meat),typeof(Vegetable)};
        public override double WeightMultiplyer => WEIGHT_MULTY;

        public override string ProduceSound()
        {
            return $"Meow";
        }
    }
}
