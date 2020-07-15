using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods.Contracts;
using WildFarm.Models.Animals.Contracts;
using WildFarm.Exceptions;

namespace WildFarm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        private const string DEF_EXC_MSG =
            "{0} does not eat {1}!";

        protected Animal(string name,double weight)
        {
            this.Name = name;
            this.Weight = weight;

        }
        
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }
        
        
        public abstract ICollection<Type> PrefferFood { get; }

        public abstract double WeightMultiplyer { get; }
        public abstract string ProduceSound();

        public void Feed(IFood food)
        {
            if (!this.PrefferFood.Contains(food.GetType()))
            {
                throw new UneatableFood(string.Format
                    (DEF_EXC_MSG,
                    this.GetType().Name,
                    food.GetType().Name));
            }
            this.Weight += this.WeightMultiplyer * food.Quantity;
            this.FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name},";
        }



    }
}
