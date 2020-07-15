using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        private const double WEIGHT_MULTY = 1;
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override ICollection<Type> PrefferFood => new List<Type>()
        { typeof(Meat)};

        public override double WeightMultiplyer => WEIGHT_MULTY;
        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
