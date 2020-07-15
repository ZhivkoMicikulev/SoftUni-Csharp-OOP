using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;
using WildFarm.Models.Foods.Contracts;

namespace WildFarm.Models.Animals
{
    public class Owl : Bird
    {
        private const double WEIGHT_MULTY= 0.25;


        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {

        }

        public override ICollection<Type> PrefferFood => new List<Type>()
        {
            typeof(Meat)
        };

        public override double WeightMultiplyer => WEIGHT_MULTY;

        public override string ProduceSound()
        {
            return $"Hoot Hoot";
        }
    }
}
